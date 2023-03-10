/*
 * Swagger Petstore - OpenAPI 3.0
 *
 * This is an opeapi specification for lab project 1  Made by _Oleksandr Myroshnychenko_  Group - 6.04.121.10.19.2
 *
 * OpenAPI spec version: 1.0.11
 * 
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

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class SubjectApiController : ControllerBase
    { 
        /// <summary>
        /// Returns all subjects from db
        /// </summary>
        /// <response code="200">successful operation</response>
        [HttpGet]
        [Route("//api/subject")]
        [ValidateModelState]
        [SwaggerOperation("ApiSubjectGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Subject>), description: "successful operation")]
        public virtual IActionResult ApiSubjectGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Subject>));
            string exampleJson = null;
            exampleJson = "[ {\n  \"PracticeHours\" : 100,\n  \"LectureHours\" : 150,\n  \"LabHours\" : 50,\n  \"Id\" : 1,\n  \"Name\" : \"СТО\"\n}, {\n  \"PracticeHours\" : 100,\n  \"LectureHours\" : 150,\n  \"LabHours\" : 50,\n  \"Id\" : 1,\n  \"Name\" : \"СТО\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<Subject>>(exampleJson)
                        : default(List<Subject>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Deletes a subject
        /// </summary>
        /// <remarks>delete a subject</remarks>
        /// <param name="id">Id of a subject that need to be deleted</param>
        /// <response code="200">Student was successfully deleted</response>
        [HttpDelete]
        [Route("//api/subject/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ApiSubjectIdDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Subject>), description: "Student was successfully deleted")]
        public virtual IActionResult ApiSubjectIdDelete([FromRoute][Required]int? id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Subject>));
            string exampleJson = null;
            exampleJson = "[ {\n  \"PracticeHours\" : 100,\n  \"LectureHours\" : 150,\n  \"LabHours\" : 50,\n  \"Id\" : 1,\n  \"Name\" : \"СТО\"\n}, {\n  \"PracticeHours\" : 100,\n  \"LectureHours\" : 150,\n  \"LabHours\" : 50,\n  \"Id\" : 1,\n  \"Name\" : \"СТО\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<Subject>>(exampleJson)
                        : default(List<Subject>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Finds subject by id
        /// </summary>
        /// <param name="id">Id of a subject that needs to return</param>
        /// <response code="200">successful operation</response>
        [HttpGet]
        [Route("//api/subject/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ApiSubjectIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Subject>), description: "successful operation")]
        public virtual IActionResult ApiSubjectIdGet([FromRoute][Required]int? id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Subject>));
            string exampleJson = null;
            exampleJson = "[ {\n  \"PracticeHours\" : 100,\n  \"LectureHours\" : 150,\n  \"LabHours\" : 50,\n  \"Id\" : 1,\n  \"Name\" : \"СТО\"\n}, {\n  \"PracticeHours\" : 100,\n  \"LectureHours\" : 150,\n  \"LabHours\" : 50,\n  \"Id\" : 1,\n  \"Name\" : \"СТО\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<Subject>>(exampleJson)
                        : default(List<Subject>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Create a subject in db
        /// </summary>
        /// <param name="entityData">Data that will be added to db as a subject</param>
        /// <response code="200">Entity was successfully added</response>
        [HttpPost]
        [Route("//api/subject")]
        [ValidateModelState]
        [SwaggerOperation("ApiSubjectPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Subject), description: "Entity was successfully added")]
        public virtual IActionResult ApiSubjectPost([FromHeader]EntityData1 entityData)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Subject));
            string exampleJson = null;
            exampleJson = "{\n  \"PracticeHours\" : 100,\n  \"LectureHours\" : 150,\n  \"LabHours\" : 50,\n  \"Id\" : 1,\n  \"Name\" : \"СТО\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Subject>(exampleJson)
                        : default(Subject);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update an existing subject
        /// </summary>
        /// <remarks>Updates an existing subject</remarks>
        /// <param name="body">Update an existent subject</param>
        /// <response code="200">Successful operation</response>
        [HttpPut]
        [Route("//api/subject")]
        [ValidateModelState]
        [SwaggerOperation("ApiSubjectPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(Subject), description: "Successful operation")]
        public virtual IActionResult ApiSubjectPut([FromBody]Subject body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Subject));
            string exampleJson = null;
            exampleJson = "{\n  \"PracticeHours\" : 100,\n  \"LectureHours\" : 150,\n  \"LabHours\" : 50,\n  \"Id\" : 1,\n  \"Name\" : \"СТО\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Subject>(exampleJson)
                        : default(Subject);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
