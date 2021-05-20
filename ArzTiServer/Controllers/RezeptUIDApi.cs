/*
 * Webservice ArzTI API
 *
 * Kommunikation des Webservers mit den jeweiligen Rechenzentren * UC: Abruf der eRezept-Daten - neue (noch nicht gesendete) | eRezept-ID | Zeitraum * UC: Abruf der eMuster16-Daten - neue (noch nicht gesendete) | eRezept-ID | Zeitraum * UC: Abruf der pRezept-Daten - neue (noch nicht gesendete) | eRezept-ID | Zeitraum * UC: Aktualisierung des eRezept-Status - eRezept-ID * UC: Löschen eines eRezepts - eRezept-ID * UC: Aktualisierung von Kundendaten (Apotheke -> Rechenzentrum Zuordnung) - Apotheke-IK * UC: ... 
 *
 * OpenAPI spec version: V1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
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
    public class RezeptUIDApiController : ControllerBase
    {
        /// <summary>
        /// löscht ein Rezept
        /// </summary>
        /// <remarks>deleteRezeptUId</remarks>
        /// <param name="ruid">Die Rezept UID.</param>
        /// <response code="200">Liefert das Rezept für die ID</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">The specified resource was not found</response>
        [HttpDelete]
        [Route("/v1/rezept/{ruid}")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("DeleteRezeptUId")]
        [SwaggerResponse(statusCode: 200, type: typeof(Rezept), description: "Liefert das Rezept für die ID")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found")]
        public virtual IActionResult DeleteRezeptUId([FromRoute][Required] string ruid)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Rezept));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));
            string exampleJson = null;
            exampleJson = "{\n  \"uid\" : {\n    \"ruid\" : \"ruid\"\n  },\n  \"data\" : \"data\",\n  \"apoik\" : \"apoik\",\n  \"id\" : {\n    \"typ\" : \"ERezept\",\n    \"id\" : \"id\"\n  },\n  \"status\" : \"status\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Rezept>(exampleJson)
            : default(Rezept);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// liefert ein Rezept
        /// </summary>
        /// <remarks>getRezeptUId</remarks>
        /// <param name="ruid">Die Rezept UID.</param>
        /// <response code="200">Liefert das gefundene Rezepte.</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">The specified resource was not found</response>
        [HttpGet]
        [Route("/v1/rezept/{ruid}")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetRezeptUId")]
        [SwaggerResponse(statusCode: 200, type: typeof(Rezept), description: "Liefert das gefundene Rezepte.")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found")]
        public virtual IActionResult GetRezeptUId([FromRoute][Required] string ruid)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Rezept));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));
            string exampleJson = null;
            exampleJson = "{\n  \"uid\" : {\n    \"ruid\" : \"ruid\"\n  },\n  \"data\" : \"data\",\n  \"apoik\" : \"apoik\",\n  \"id\" : {\n    \"typ\" : \"ERezept\",\n    \"id\" : \"id\"\n  },\n  \"status\" : \"status\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Rezept>(exampleJson)
            : default(Rezept);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// liefert den Status eines Rezepts
        /// </summary>
        /// <remarks>getRezeptUIdStatus</remarks>
        /// <param name="ruid">Die Rezept UID.</param>
        /// <response code="200">Liefert das gefundene Rezepte.</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">The specified resource was not found</response>
        [HttpGet]
        [Route("/v1/rezept/{ruid}/status")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetRezeptUIdStatus")]
        [SwaggerResponse(statusCode: 200, type: typeof(RezeptStatus), description: "Liefert das gefundene Rezepte.")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found")]
        public virtual IActionResult GetRezeptUIdStatus([FromRoute][Required] string ruid)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(RezeptStatus));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));
            string exampleJson = null;
            exampleJson = "{\n  \"uid\" : {\n    \"ruid\" : \"ruid\"\n  },\n  \"id\" : {\n    \"typ\" : \"ERezept\",\n    \"id\" : \"id\"\n  },\n  \"status\" : \"status\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<RezeptStatus>(exampleJson)
            : default(RezeptStatus);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Statusänderung eines Rezeptes
        /// </summary>
        /// <remarks>patchRezeptUIdStatus</remarks>
        /// <param name="ruid">Die Rezept UID.</param>
        /// <param name="status">Status value</param>
        /// <response code="200">Liefert den Status des Rezeptes für die ID</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">The specified resource was not found</response>
        [HttpPatch]
        [Route("/v1/rezept/{ruid}/status")]
        [Authorize(AuthenticationSchemes = BasicAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("PatchRezeptUIdStatus")]
        [SwaggerResponse(statusCode: 200, type: typeof(RezeptStatus), description: "Liefert den Status des Rezeptes für die ID")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "The specified resource was not found")]
        public virtual IActionResult PatchRezeptUIdStatus([FromRoute][Required] string ruid, [FromQuery][Required()] string status)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(RezeptStatus));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));
            string exampleJson = null;
            exampleJson = "{\n  \"uid\" : {\n    \"ruid\" : \"ruid\"\n  },\n  \"id\" : {\n    \"typ\" : \"ERezept\",\n    \"id\" : \"id\"\n  },\n  \"status\" : \"status\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<RezeptStatus>(exampleJson)
            : default(RezeptStatus);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
