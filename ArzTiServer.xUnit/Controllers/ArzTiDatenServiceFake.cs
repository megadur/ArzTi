using ArzTiServer.ArzTiService;
using ArzTiServer.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArzTiServer.Controllers.Tests
{
    internal class ArzTiDatenServiceFake : IArzTiDatenService
    {
        public Task<Rezept> DeleteRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            throw new System.NotImplementedException();
        }

        public Task<Rezept> DeleteRezeptUIdAsync(string ruid)
        {
            throw new System.NotImplementedException();
        }

        public Task<Rezept> GetRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<Rezept>> GetRezeptIdListAsync(string apoik, RezeptTyp? reztyp, int? maxnum, string zeitraum)
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<RezeptStatus>> GetRezeptIdListByStatusAsync(string apoik, RezeptTyp? reztyp, string zeitraum)
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<RezeptStatus>> GetRezeptIdListByTransferAsync(string apoik, RezeptTyp? reztyp, string zeitraum)
        {
            throw new System.NotImplementedException();
        }

        public Task<Rezept> GetRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<Rezept>> GetRezeptUIdAsync(string ruid)
        {
            throw new System.NotImplementedException();
        }

        public Task<Rezept> PatchRezeptIdStatusAsync(string apoik, Reztyp reztyp, string rezid, RezeptStatus body)
        {
            throw new System.NotImplementedException();
        }

        public Task<Rezept> PatchRezeptUIdStatusAsync(string ruid, RezeptStatus body)
        {
            throw new System.NotImplementedException();
        }

        public Task<Abholstatus> PutRezeptIdListAbholstatusAsync(string apoik, IEnumerable<Abholstatus> body)
        {
            throw new System.NotImplementedException();
        }

        public Task<RezeptPruefRes> PutRezeptIdListPruefungAsync(string apoik, Rezept body)
        {
            throw new System.NotImplementedException();
        }

        public Task<Abholstatus> PutRezeptUIdListAbholstatusAsync(IEnumerable<Abholstatus> body)
        {
            throw new System.NotImplementedException();
        }

        public Task<RezeptPruefRes> PutRezeptUidListPruefungAsync(Rezept body)
        {
            throw new System.NotImplementedException();
        }
    }
}