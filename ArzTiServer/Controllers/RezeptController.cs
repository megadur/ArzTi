using ArzTiServer.OpenAPIService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.Controllers
{
    public class RezeptController : IController
    {
        public Task<ActionResult<Rezept>> DeleteRezeptAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Rezept>> GetRezeptAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<ICollection<RezeptStatus>>> GetRezeptListByStatusAsync(string apoik, RezeptTyp? reztyp, string zeitraum)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<ICollection<Rezept>>> GetRezeptListNewAsync(string apoik, RezeptTyp? reztyp, int? maxnum, string zeitraum)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Rezept>> GetRezeptStatusAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Rezept>> PatchRezeptStatusAsync(string apoik, Reztyp reztyp, string rezid, RezeptStatus body)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Abholstatus>> PutAbholstatusRezeptListAsync(string apoik, IEnumerable<Abholstatus> body)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RezeptPruefRes>> PutRezeptPruefungAsync(string apoik, Rezept body)
        {
            throw new NotImplementedException();
        }
    }
}
