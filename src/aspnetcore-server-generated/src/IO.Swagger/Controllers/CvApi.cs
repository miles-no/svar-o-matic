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
    public class CvApiController : ControllerBase
    { 
        /// <summary>
        /// Add a new CV to a consultant profile
        /// </summary>
        /// <remarks>Add a new CV to a consultant profile</remarks>
        /// <param name="body">Add a new CV for a consultant in the app</param>
        /// <response code="200">Successful operation</response>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/cv")]
        [ValidateModelState]
        [SwaggerOperation("AddCV")]
        [SwaggerResponse(statusCode: 200, type: typeof(Cv), description: "Successful operation")]
        public virtual IActionResult AddCV([FromBody]Cv body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Cv));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);
            string exampleJson = null;
            exampleJson = "{\n  \"photoUrls\" : \"\",\n  \"name\" : \"\",\n  \"id\" : \"\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Cv>(exampleJson)
                        : default(Cv);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Finds CVs by consultant
        /// </summary>
        /// <remarks>Multiple CV values can be provided with comma separated strings</remarks>
        /// <param name="consultantId">Id of the consultant that the search is limited to</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid status value</response>
        [HttpGet]
        [Route("/cv/findByConsultant/{consultantId}")]
        [ValidateModelState]
        [SwaggerOperation("FindCVsByConsultant")]
        [SwaggerResponse(statusCode: 200, type: typeof(Object), description: "successful operation")]
        public virtual IActionResult FindCVsByConsultant([FromRoute][Required]Object consultantId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Object));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Object>(exampleJson)
                        : default(Object);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Find CV by ID
        /// </summary>
        /// <remarks>Returns a single CV</remarks>
        /// <param name="cvId">ID of CV to return</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">CV not found</response>
        [HttpGet]
        [Route("/cv/{cvId}")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetCVById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Cv), description: "successful operation")]
        public virtual IActionResult GetCVById([FromRoute][Required]Object cvId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Cv));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"photoUrls\" : \"\",\n  \"name\" : \"\",\n  \"id\" : \"\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Cv>(exampleJson)
                        : default(Cv);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update an existing CV
        /// </summary>
        /// <remarks>Update an existing CV by Id</remarks>
        /// <param name="body">Update an existent cv</param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">CV not found</response>
        /// <response code="405">Validation exception</response>
        [HttpPut]
        [Route("/cv")]
        [ValidateModelState]
        [SwaggerOperation("UpdateCV")]
        [SwaggerResponse(statusCode: 200, type: typeof(Cv), description: "Successful operation")]
        public virtual IActionResult UpdateCV([FromBody]Cv body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Cv));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);
            string exampleJson = null;
            exampleJson = "{\n  \"photoUrls\" : \"\",\n  \"name\" : \"\",\n  \"id\" : \"\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Cv>(exampleJson)
                        : default(Cv);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}