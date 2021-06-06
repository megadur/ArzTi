
using ArzTiServer.Api.Model;
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

        public Task<ICollection<Rezept>> GetRezeptIdListByTransferAsync(string apoik, RezeptTyp? reztyp, string zeitraum)
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<RezeptPruefResult>> GetRezeptIdListPruefResAsync(string apoik, RezeptTyp? reztyp, string zeitraum, IEnumerable<string> status)
        {
            throw new System.NotImplementedException();
        }

        public Task<Rezept> GetRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string status)
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<RezeptStatus>> GetRezeptIdStatusListAsync(string apoik, RezeptTyp? reztyp, string zeitraum, bool? abgeholt)
        {
            throw new System.NotImplementedException();
        }

        public Task<Rezept> GetRezeptUIdAsync(string ruid)
        {
            throw new System.NotImplementedException();
        }

        public Task<RezeptStatus> GetRezeptUIdStatusAsync(string ruid)
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<Abholstatus>> PatchRezeptIdListAbholstatusAsync(string apoik, IEnumerable<RezeptId> body)
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<RezeptStatus>> PatchRezeptIdListStatusAsync(string apoik, IEnumerable<RezeptStatus> body)
        {
            throw new System.NotImplementedException();
        }

        public Task<RezeptStatus> PatchRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string rezid, string body)
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<Abholstatus>> PatchRezeptUIdListAbholstatusAsync(IEnumerable<RezeptUId> body)
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<RezeptStatus>> PatchRezeptUIdListStatusAsync(IEnumerable<RezeptStatus> body)
        {
            throw new System.NotImplementedException();
        }

        public Task<RezeptStatus> PatchRezeptUIdStatusAsync(string ruid, string body)
        {
            throw new System.NotImplementedException();
        }

        public Task PutRezeptIdListPruefungAsync(string apoik, IEnumerable<RezeptId> body)
        {
            throw new System.NotImplementedException();
        }

        public Task PutRezeptUidListPruefungAsync(IEnumerable<RezeptUId> body)
        {
            throw new System.NotImplementedException();
        }
    }
}