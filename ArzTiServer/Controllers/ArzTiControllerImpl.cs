using ArzTiServer.OpenAPIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.Controllers
{
    public class ArzTiControllerImpl : IArzTiController
    {
        public Task<Rezept> DeleteRezeptAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Apotheke>> GetApothekeAsync(string apoik)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Apotheke>> GetApothekenListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Rezept> GetRezeptAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<RezeptStatus>> GetRezeptListByStatusAsync(string apoik, RezeptTyp? reztyp, string zeitraum)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Rezept>> GetRezeptListNewAsync(string apoik, RezeptTyp? reztyp, int? maxnum, string zeitraum)
        {
            throw new NotImplementedException();
        }

        public Task<Rezept> GetRezeptStatusAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            throw new NotImplementedException();
        }

        public Task<Rezept> PatchRezeptStatusAsync(string apoik, Reztyp reztyp, string rezid, RezeptStatus body)
        {
            throw new NotImplementedException();
        }

        public Task<Abholstatus> PutAbholstatusRezeptListAsync(string apoik, IEnumerable<Abholstatus> body)
        {
            throw new NotImplementedException();
        }

        public Task<RezeptPruefRes> PutRezeptPruefungAsync(string apoik, Rezept body)
        {
            throw new NotImplementedException();
        }
    }
}
