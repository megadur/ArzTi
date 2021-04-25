using ArzTiServer.OpenAPIService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RezController : IController
    {
        [HttpPut("/apotheke/{apoik}/erezept/{rezid}/abholstatus")]
        public Task<ActionResult<Abholstatus>> AendereAbholstatusERezeptListAsync(string apoik, string rezid, IEnumerable<Abholstatus> body)
        {
            throw new NotImplementedException();
        }

        [HttpPut("/apotheke/{apoik}/mrezept/{rezid}/abholstatus")]
        public Task<ActionResult<Abholstatus>> AendereAbholstatusMRezeptListAsync(string apoik, string rezid, IEnumerable<Abholstatus> body)
        {
            throw new NotImplementedException();
        }

        [HttpPut("/apotheke/{apoik}/prezept/{rezid}/abholstatus")]
        public Task<ActionResult<Abholstatus>> AendereAbholstatusPRezeptListAsync(string apoik, string rezid, IEnumerable<Abholstatus> body)
        {
            throw new NotImplementedException();
        }

        [HttpGet("/apotheke/{apoik}/erezept/{rezid}")]
        public Task<ActionResult<Rezept>> Erezept2Async(string apoik, string rezid)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<Rezept>> ErezeptAsync(string apoik, string rezid)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<ICollection<Rezept>>> GetERezeptListNewAsync(string apoik, int? maxnum, string zeitraum)
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public Task<ActionResult<ICollection<Rezept>>> GetMRezeptListNewAsync(string apoik, int? maxnum, string zeitraum)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<ICollection<Rezept>>> GetPRezeptListNewAsync(string apoik, int? maxnum, string zeitraum)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<Rezept>> Mrezept2Async(string apoik, string rezid)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<Rezept>> MrezeptAsync(string apoik, string rezid)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<Rezept>> Prezept2Async(string apoik, string rezid)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<Rezept>> PrezeptAsync(string apoik, string rezid)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<Rezept>> Pruefung2Async(string apoik, string rezid, Rezept body)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<Rezept>> Pruefung3Async(string apoik, string rezid, Rezept body)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<Rezept>> PruefungAsync(string apoik, string rezid, Rezept body)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<Rezept>> Status2Async(string apoik, string rezid, MRezeptStatus body)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<ICollection<ERezeptStatus>>> Status3Async(string apoik, string zeitraum)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<ERezeptStatus>> Status4Async(string apoik, string rezid)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<Rezept>> Status5Async(string apoik, string rezid, ERezeptStatus body)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<ICollection<ERezeptStatus>>> Status6Async(string apoik, string zeitraum)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<Rezept>> Status7Async(string apoik, string rezid)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<Rezept>> Status8Async(string apoik, string rezid, ERezeptStatus body)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<ICollection<MRezeptStatus>>> StatusAllAsync(string apoik, string zeitraum)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<ActionResult<Rezept>> StatusAsync(string apoik, string rezid)
        {
            throw new NotImplementedException();
        }
    }
}
