using ArzTiServer.Api.Model;
using ArzTiServer.Domain.Model;
using ArzTiServer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ArzTiServer.xUnit
{
    public class DatenRepositoryFake : IDatenERepository
    {
        private readonly List<ErSenderezepteErezept> _erSenderezepteErezept;
        private readonly List<ErSenderezeptePrezept> _erSenderezeptePrezept;
        private readonly List<ErSenderezepteEmuster16> _erSenderezepteMrezept;

        public DatenRepositoryFake()
        {
            _erSenderezepteErezept = FakeData.getErSenderezepteErezept();

            _erSenderezeptePrezept = new List<ErSenderezeptePrezept>()
            {
            new ErSenderezeptePrezept(){ IdSenderezeptePrezept =1, ApoIkNr =1L },
            new ErSenderezeptePrezept(){ IdSenderezeptePrezept =2, ApoIkNr =1L },
            new ErSenderezeptePrezept(){ IdSenderezeptePrezept =3, ApoIkNr =1L },
            };
            _erSenderezepteMrezept = new List<ErSenderezepteEmuster16>()
            {
            new ErSenderezepteEmuster16(){ IdSenderezepteEmuster16 =1, Muster16Id =1L},
            new ErSenderezepteEmuster16(){ IdSenderezepteEmuster16 =2, Muster16Id =2L},
            new ErSenderezepteEmuster16(){ IdSenderezepteEmuster16 =3, Muster16Id =3L},
            };
        }

        public Task<ErSenderezepteErezept> DeleteERezeptIdAsync(string apoik, string rezid)
        {
            throw new NotImplementedException();
        }

        public Task<ErSenderezepteErezept> DeleteERezeptUIdAsync(string ruid)
        {
            throw new NotImplementedException();
        }

        public Task<ErSenderezepteErezeptDaten> GetERezeptDatenAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ErSenderezepteErezept> GetERezeptIdAsync(string apoik, string rezid)
        {
            throw new NotImplementedException();
        }

        public Task<List<ErSenderezepteErezept>> GetERezeptIdListAsync(string apoik, int? maxnum, string zeitraum, bool? abgeholt)
        {
            return Task.FromResult(_erSenderezepteErezept);
        }

        public Task<List<ErSenderezepteErezept>> GetERezeptIdListByStatusAsync(string apoik, string zeitraum, IEnumerable<string> status)
        {
            return Task.FromResult(_erSenderezepteErezept);
        }

        public Task<List<ErSenderezepteErezept>> xGetERezeptIdListByTransferAsync(string apoik, string zeitraum)
        {
            return Task.FromResult(_erSenderezepteErezept);
        }

        public Task<ICollection<RezeptPruefResult>> GetERezeptIdListPruefResAsync(string apoik, string zeitraum, IEnumerable<string> status)
        {
            throw new NotImplementedException();
        }

        public Task<ErSenderezepteErezept> GetERezeptIdStatusAsync(string apoik, string status)
        {
            throw new NotImplementedException();
        }


        public Task<List<ErSenderezepteErezept>> GetERezeptListOffen(string apoik, int MaxNum)
        {
            throw new NotImplementedException();
        }

        public Task<ErSenderezepteErezeptStatus> GetERezeptStatusAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ErSenderezepteErezeptStatusinfo>> GetERezeptStatusinfoListAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ErSenderezepteErezept> GetERezeptUIdAsync(string ruid)
        {
            throw new NotImplementedException();
        }

        public Task<List<ErSenderezepteErezeptStatusinfo>> GetErSenderezepteErezeptStatusinfosAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ErSenderezepteEmuster16>> GetMRezeptList()
        {
            throw new NotImplementedException();
        }

        public Task<List<ErSenderezepteEmuster16>> GetMRezeptListOffen(string apoik, int MaxNum)
        {
            throw new NotImplementedException();
        }

        public Task<List<ErSenderezeptePrezept>> GetPRezeptList()
        {
            throw new NotImplementedException();
        }

        public Task<List<ErSenderezeptePrezept>> GetPRezeptListOffen(string apoik, int MaxNum)
        {
            throw new NotImplementedException();
        }

        public Task<Dictionary<string, bool>> PatchERezeptIdListAbholstatusAsync(string apoik, List<string> rezeptlist)
        {
            throw new NotImplementedException();
        }

        public Task<Dictionary<string, string>> PatchERezeptIdListStatusAsync(string apoik, Dictionary<string, string> rezeptlist)
        {
            throw new NotImplementedException();
        }

        public Task<RezeptStatus> PatchERezeptIdStatusAsync(string apoik, string rezid, string status)
        {
            throw new NotImplementedException();
        }

        public Task<ErSenderezepteErezeptStatus> PatchERezeptStatusAsync(int id, string status)
        {
            throw new NotImplementedException();
        }

        public Task<Dictionary<string, bool>> PatchERezeptUIdListAbholstatusAsync(List<string> rezeptlist)
        {
            throw new NotImplementedException();
        }

        public Task<Dictionary<string, string>> PatchERezeptUIdListStatusAsync(Dictionary<string, string> rezeptlist)
        {
            throw new NotImplementedException();
        }

        public Task<RezeptStatus> PatchERezeptUIdStatusAsync(string ruid, string status)
        {
            throw new NotImplementedException();
        }

        public Task<Dictionary<string, bool>> PutERezeptIdListPruefungAsync(string apoik, List<string> rezeptlist)
        {
            throw new NotImplementedException();
        }

        public Task<Dictionary<string, bool>> PutERezeptUidListPruefungAsync(List<string> rezeptlist)
        {
            throw new NotImplementedException();
        }


    }
}
