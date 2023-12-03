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
    public class SvarApiController : ControllerBase
    { 
        /// <summary>
        /// Accept a svar to a krav
        /// </summary>
        /// <remarks>Accept a svar to a krav</remarks>
        /// <param name="consultantId">Id of the consultant that the addition is related to</param>
        /// <param name="inquiryId">Id of the forespørsel that the deletion is related to</param>
        /// <param name="kravId">Id of the krav that the operation is related to</param>
        /// <response code="200">Successful operation</response>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/svar/{consultantId}/{inquiryId}/{kravId}/accept")]
        [ValidateModelState]
        [SwaggerOperation("AcceptSvar")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelApiResponse), description: "Successful operation")]
        public virtual IActionResult AcceptSvar([FromRoute][Required]long? consultantId, [FromRoute][Required]long? inquiryId, [FromRoute][Required]long? kravId)
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
        /// Manually edit a svar to a krav
        /// </summary>
        /// <remarks>Manually edit a svar to a krav</remarks>
        /// <param name="body">Data about the svar</param>
        /// <param name="consultantId">Id of the consultant that the addition is related to</param>
        /// <param name="inquiryId">Id of the forespørsel that the deletion is related to</param>
        /// <param name="kravId">Id of the krav that the operation is related to</param>
        /// <response code="200">Successful operation</response>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/svar/{consultantId}/{inquiryId}/{kravId}/edit")]
        [ValidateModelState]
        [SwaggerOperation("EditSvar")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelApiResponse), description: "Successful operation")]
        public virtual IActionResult EditSvar([FromBody]Svar body, [FromRoute][Required]long? consultantId, [FromRoute][Required]long? inquiryId, [FromRoute][Required]long? kravId)
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
        /// Generate answer for a Krav
        /// </summary>
        /// <remarks>Generate answer for a Krav</remarks>
        /// <param name="consultantId">Id of the consultant that the addition is related to</param>
        /// <param name="inquiryId">Id of the forespørsel that the deletion is related to</param>
        /// <param name="kravId">Id of the krav that the request is related to</param>
        /// <response code="200">Successful operation</response>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/svar/{consultantId}/{inquiryId}/{kravId}/generateSvar")]
        [ValidateModelState]
        [SwaggerOperation("GenerateAnswerForKrav")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelApiResponse), description: "Successful operation")]
        public virtual IActionResult GenerateAnswerForKrav([FromRoute][Required]long? consultantId, [FromRoute][Required]long? inquiryId, [FromRoute][Required]long? kravId)
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
    }
}
