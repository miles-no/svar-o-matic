/*
 * Swagger - Svar-o-Matic
 *
 * This is the backend for a solution that allows employees of Miles AS to efficiently match incoming project requests with existing consultant expertise.  Some useful links: - [The Svar-o-Matic repository](https://github.com/miles-no/svar-o-matic)
 *
 * OpenAPI spec version: 1.0.11
 * Contact: drift@miles.no
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using SvarOMatic.Attributes;
using SvarOMatic.Models;

namespace SvarOMatic.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class KravApiController : ControllerBase
    { 
        /// <summary>
        /// Add a new krav to a forespørsel
        /// </summary>
        /// <remarks>Add a new krav to a forespørsel</remarks>
        /// <param name="body">Data about the krav</param>
        /// <param name="consultantId">Id of the consultant that the addition is related to</param>
        /// <param name="inquiryId">Id of the forespørsel that the addition is related to</param>
        /// <response code="200">Successful operation</response>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/krav/{consultantId}/{inquiryId}/add")]
        [ValidateModelState]
        [SwaggerOperation("CreateKrav")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelApiResponse), description: "Successful operation")]
        public virtual IActionResult CreateKrav([FromBody]KravRequest body, [FromRoute][Required]long? consultantId, [FromRoute][Required]long? inquiryId)
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
        /// Delete a krav from a forespørsel
        /// </summary>
        /// <remarks>Delete a krav from a forespørsel</remarks>
        /// <param name="consultantId">Id of the consultant that the addition is related to</param>
        /// <param name="inquiryId">Id of the forespørsel that the deletion is related to</param>
        /// <param name="kravId">Id of the krav to delete</param>
        /// <response code="200">Successful operation</response>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/krav/{consultantId}/{inquiryId}/{kravId}/delete")]
        [ValidateModelState]
        [SwaggerOperation("DeleteKrav")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelApiResponse), description: "Successful operation")]
        public virtual IActionResult DeleteKrav([FromRoute][Required]long? consultantId, [FromRoute][Required]long? inquiryId, [FromRoute][Required]long? kravId)
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
        /// Edit an existing krav to a forespørsel
        /// </summary>
        /// <remarks>Edit an existing krav to a forespørsel</remarks>
        /// <param name="body">Data about the krav</param>
        /// <param name="consultantId">Id of the consultant that the addition is related to</param>
        /// <param name="inquiryId">Id of the forespørsel that the edit is related to</param>
        /// <param name="kravId">Id of the krav that the edit is related to</param>
        /// <response code="200">Successful operation</response>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/krav/{consultantId}/{inquiryId}/{kravId}/edit")]
        [ValidateModelState]
        [SwaggerOperation("EditKrav")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelApiResponse), description: "Successful operation")]
        public virtual IActionResult EditKrav([FromBody]KravRequest body, [FromRoute][Required]long? consultantId, [FromRoute][Required]long? inquiryId, [FromRoute][Required]long? kravId)
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
