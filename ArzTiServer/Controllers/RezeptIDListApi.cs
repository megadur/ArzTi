/*
 * Webservice ArzTI API
 *
 * Kommunikation des Webservers mit den jeweiligen Rechenzentren * UC: Abruf der eRezept-Daten - neue (noch nicht gesendete) | eRezept-ID | Zeitraum * UC: Abruf der eMuster16-Daten - neue (noch nicht gesendete) | eRezept-ID | Zeitraum * UC: Abruf der pRezept-Daten - neue (noch nicht gesendete) | eRezept-ID | Zeitraum * UC: Aktualisierung des eRezept-Status - eRezept-ID * UC: Löschen eines eRezepts - eRezept-ID * UC: Aktualisierung von Kundendaten (Apotheke -> Rechenzentrum Zuordnung) - Apotheke-IK * UC: ... 
 *
 * OpenAPI spec version: V1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using ArzTiServer.Attributes;
using ArzTiServer.Security;
using ArzTiServer.Models;
namespace IO.Swagger.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class RezeptIDListApiController : ControllerBase
    {
        /// <summary>
        /// Änderung des Abholstatus einer Liste von Rezepten
        /// </summary>
        /// <remarks>patchRezeptIdListAbholstatus: ändert Abholstatus einer Liste von Rezepten</remarks>
        /// <param name="body"></param>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <response code="200">Returns the newly created item</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="405">Validation exception</response>
        [HttpPatch]
        [Route("/v1/apotheke/{apoik}/rezept/abholung")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PatchRezeptIdListAbholstatus")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Abholstatus>), description: "Returns the newly created item")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found")]
        public virtual IActionResult PatchRezeptIdListAbholstatus([FromBody] List<RezeptId> body, [FromRoute][Required] string apoik)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Abholstatus>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);
            string exampleJson = null;
            exampleJson = "[ {\n  \"uid\" : {\n    \"ruid\" : \"ruid\"\n  },\n  \"abgeholt\" : true,\n  \"id\" : {\n    \"typ\" : \"ERezept\",\n    \"id\" : \"id\"\n  }\n}, {\n  \"uid\" : {\n    \"ruid\" : \"ruid\"\n  },\n  \"abgeholt\" : true,\n  \"id\" : {\n    \"typ\" : \"ERezept\",\n    \"id\" : \"id\"\n  }\n} ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Abholstatus>>(exampleJson)
            : default(List<Abholstatus>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Statusänderung einer Liste von Rezepten
        /// </summary>
        /// <remarks>patchRezeptIdListStatus</remarks>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="body"></param>
        /// <response code="200">Liefert den Status einer Liste von Rezepten</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">The specified resource was not found</response>
        [HttpPatch]
        [Route("/v1/apotheke/{apoik}/rezept/status")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PatchRezeptIdListStatus")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<RezeptStatus>), description: "Liefert den Status einer Liste von Rezepten")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found")]
        public virtual IActionResult PatchRezeptIdListStatus([FromRoute][Required] string apoik, [FromBody] List<RezeptStatus> body)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<RezeptStatus>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));
            string exampleJson = null;
            exampleJson = "[ {\n  \"uid\" : {\n    \"ruid\" : \"ruid\"\n  },\n  \"id\" : {\n    \"typ\" : \"ERezept\",\n    \"id\" : \"id\"\n  },\n  \"status\" : \"status\"\n}, {\n  \"uid\" : {\n    \"ruid\" : \"ruid\"\n  },\n  \"id\" : {\n    \"typ\" : \"ERezept\",\n    \"id\" : \"id\"\n  },\n  \"status\" : \"status\"\n} ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<RezeptStatus>>(exampleJson)
            : default(List<RezeptStatus>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// prüft eine Liste von Rezepten
        /// </summary>
        /// <param name="body">putRezeptIdListPruefung</param>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <response code="202">die Liste wurde akzeptiert</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">The specified resource was not found</response>
        [HttpPut]
        [Route("/v1/apotheke/{apoik}/rezept/pruefung")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PutRezeptIdListPruefung")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found")]
        public virtual IActionResult PutRezeptIdListPruefung([FromBody] List<RezeptId> body, [FromRoute][Required] string apoik)
        {
            //TODO: Uncomment the next line to return response 202 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(202);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            throw new NotImplementedException();
        }
    }
}
