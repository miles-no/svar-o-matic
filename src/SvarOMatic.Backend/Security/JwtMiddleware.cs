using System;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace SvarOMatic.Security;

public class JwtClaimMiddleware
{
    private readonly RequestDelegate _next;
    private readonly string _openIdConnectConfigEndpoint;
    private readonly string _expectedAudience;
    private readonly string _expectedIssuer;

    public JwtClaimMiddleware(
        RequestDelegate next,
        string azureAdInstance,
        string tenantId,
        string clientId)
    {
        _next = next;
        _openIdConnectConfigEndpoint = $"{azureAdInstance}{tenantId}/v2.0/.well-known/openid-configuration";
        _expectedAudience = $"api://{clientId}";
        _expectedIssuer = $"https://sts.windows.net/{tenantId}/";
    }

    public async Task Invoke(HttpContext context)
    {
        var token = context.Request.Headers.Authorization.FirstOrDefault()?.Split(" ").Last();

        if (token != null)
            AttachUserInfoToContext(context, token);

        await _next(context);
    }

    private void AttachUserInfoToContext(HttpContext context, string token)
    {
        try
        {
            IConfigurationManager<OpenIdConnectConfiguration> configurationManager =
                new ConfigurationManager<OpenIdConnectConfiguration>(_openIdConnectConfigEndpoint, new OpenIdConnectConfigurationRetriever());
            OpenIdConnectConfiguration openIdConfig = configurationManager.GetConfigurationAsync(CancellationToken.None).Result;

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            var result = tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidAudience = _expectedAudience,
                ValidIssuer = _expectedIssuer,
                IssuerSigningKeys = openIdConfig.SigningKeys,
                ValidateIssuerSigningKey = true,
                ValidateAudience = true,
                ValidateIssuer = true,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            }, out var validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;
            var firstName = jwtToken.Claims.First(x => x.Type == "given_name").Value;
            var lastName = jwtToken.Claims.First(x => x.Type == "family_name").Value;
            var email = jwtToken.Claims.First(x => x.Type == "upn").Value;

            // attach user to context on successful jwt validation
            context.Items["User"] = new AuthorizedUser(firstName, lastName, email);
        }
        catch (Exception e)
        {
            // do nothing if jwt validation fails
            // user is not attached to context so request won't have access to secure routes
        }
    }
}