/*
 * Webservice ArzTI API
 *
 * Kommunikation des Webservers mit den jeweiligen Rechenzentren V.2021-05-20            
 *
 * The version of the OpenAPI document: V1
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using ArzTiServer.Attributes;
using ArzTiServer.Models;

namespace ArzTiServer.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public abstract class ApothekeApiController : ControllerBase
    { 
        /// <summary>
        /// liefert Details einer Apotheke
        /// </summary>
        /// <remarks>getApothekeByIK</remarks>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <response code="200">liefert Details einer Apotheke.</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">The specified resource was not found</response>
        [HttpGet]
        [Route("/v1/apotheke/{apoik}")]
        [ValidateModelState]
        [SwaggerOperation("GetApothekeByIK")]
        [SwaggerResponse(statusCode: 200, type: typeof(Apotheke), description: "liefert Details einer Apotheke.")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found")]
        public abstract Task<IActionResult> GetApothekeByIK([FromRoute (Name = "apoik")][Required]string apoik);

        /// <summary>
        /// liefert eine Liste aller Apotheken
        /// </summary>
        /// <remarks>getApothekenList</remarks>
        /// <response code="200">Liefert eine Liste mit den gefundenen Rezepten.</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">The specified resource was not found</response>
        [HttpGet]
        [Route("/v1/apotheke")]
        [ValidateModelState]
        [SwaggerOperation("GetApothekenList")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Apotheke>), description: "Liefert eine Liste mit den gefundenen Rezepten.")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found")]
        public abstract Task<IActionResult> GetApothekenList();
    }
}
