/*
 * Swagger - Svar-o-Matic
 *
 * This is the backend for a solution that allows employees of Miles AS to efficiently match incoming project requests with existing consultant expertise.  Some useful links: - [The Svar-o-Matic repository](https://github.com/miles-no/svar-o-matic)
 *
 * OpenAPI spec version: 1.0.11
 * Contact: drift@miles.no
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class StyleGuideApiController : ControllerBase
    { 
        /// <summary>
        /// Add/Replace the style guide used by all users of svar-o-matic
        /// </summary>
        /// <remarks>Add/Replace the style guide used by all users of svar-o-matic</remarks>
        /// <param name="body">A Style Guide</param>
        /// <response code="200">Successful operation</response>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/styleGuide/add")]
        [ValidateModelState]
        [SwaggerOperation("AddStyleGuide")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelApiResponse), description: "Successful operation")]
        public virtual IActionResult AddStyleGuide([FromBody]Object body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ModelApiResponse));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);
            string exampleJson = null;
            exampleJson = "{\n  \"code\" : 0,\n  \"type\" : \"type\",\n  \"message\" : \"message\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ModelApiResponse>(exampleJson)
                        : default(ModelApiResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Finds all CVs, skjemaer and style-guides applicable for a consultant
        /// </summary>
        /// <remarks>Multiple docs (CV, skjema and/or style guide) values can be provided with comma separated strings</remarks>
        /// <param name="consultantId">Id of the consultant that the search is limited to</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid status value</response>
        [HttpGet]
        [Route("/docsForConsultant/{consultantId}/get")]
        [ValidateModelState]
        [SwaggerOperation("FindDocsForConsultant")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Object>), description: "successful operation")]
        public virtual IActionResult FindDocsForConsultant([FromRoute][Required]long? consultantId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Object>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ \"\", \"\" ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<Object>>(exampleJson)
                        : default(List<Object>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Toggle the usage of a document for a consultant to generate answers
        /// </summary>
        /// <remarks>Toggle the usage of a document for a consultant to generate answers</remarks>
        /// <param name="body">A previous skjema that the consultant has used</param>
        /// <param name="consultantId">Id of the consultant that the document status is limited to</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Document not found</response>
        [HttpGet]
        [Route("/toggleUsage/{consultantId}")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ToggleDocUsageForConsultant")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelApiResponse), description: "successful operation")]
        public virtual IActionResult ToggleDocUsageForConsultant([FromBody]DocUsageRequest body, [FromRoute][Required]long? consultantId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ModelApiResponse));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"code\" : 0,\n  \"type\" : \"type\",\n  \"message\" : \"message\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ModelApiResponse>(exampleJson)
                        : default(ModelApiResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
