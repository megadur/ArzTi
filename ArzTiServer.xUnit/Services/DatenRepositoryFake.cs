using ArzTiServer.ArzTiService;
using ArzTiServer.Models;
using ArzTiServer.Repositories;
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
            _erSenderezepteErezept = new List<ErSenderezepteErezept>()
            {
            new ErSenderezepteErezept(){ IdSenderezepteErezept=1,  ErezeptId="E1" },
            new ErSenderezepteErezept(){ IdSenderezepteErezept=2,  ErezeptId="E2" },
            new ErSenderezepteErezept(){ IdSenderezepteErezept=3,  ErezeptId="E3" }
            };
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

        public List<ErSenderezepteErezept> GetERezeptList()
        {
            return _erSenderezepteErezept;
        }
        public ErSenderezepteErezept GetERezept()
        {
            return _erSenderezepteErezept[0];
        }

        public IQueryable<ErSenderezepteErezept> GetERezeptQueryable()
        {
            throw new NotImplementedException();
        }

        public List<ErSenderezepteEmuster16> GetMRezeptList()
        {
            return _erSenderezepteMrezept;
        }

        public IQueryable<ErSenderezepteEmuster16> GetMRezeptQueryable()
        {
            throw new NotImplementedException();
        }

        public List<ErSenderezepteErezept> GetOffeneERezeptList(string apoik, int MaxNum)
        {
            throw new NotImplementedException();
        }

        public List<ErSenderezepteEmuster16> GetOffeneMRezeptList(string apoik, int MaxNum)
        {
            throw new NotImplementedException();
        }

        public List<ErSenderezeptePrezept> GetOffenePRezeptList(string apoik, int MaxNum)
        {
            throw new NotImplementedException();
        }


        public List<ErSenderezeptePrezept> GetPRezeptList()
        {
            return _erSenderezeptePrezept;
        }

        public IQueryable<ErSenderezeptePrezept> GetPRezeptQueryable()
        {
            throw new NotImplementedException();
        }

        public Task<ErSenderezepteErezept> GetERezeptIdAsync(string apoik, string rezid)
        {
            throw new NotImplementedException();
        }

        public Task<List<ErSenderezepteErezept>> GetERezeptIdListAsync(string apoik, int? maxnum, string zeitraum)
        {
            throw new NotImplementedException();
        }

        public Task<List<ErSenderezepteErezept>> GetERezeptIdListByStatusAsync(string apoik, string zeitraum)
        {
            throw new NotImplementedException();
        }

        public Task<List<ErSenderezepteErezept>> GetERezeptIdListByTransferAsync(string apoik, string zeitraum)
        {
            throw new NotImplementedException();
        }

        public Task<ErSenderezepteErezept> GetERezeptIdStatusAsync(string apoik, string rezid)
        {
            throw new NotImplementedException();
        }

        Task<List<ErSenderezepteEmuster16>> IDatenERepository.GetMRezeptList()
        {
            throw new NotImplementedException();
        }

        Task<List<ErSenderezepteEmuster16>> IDatenERepository.GetMRezeptListOffen(string apoik, int MaxNum)
        {
            throw new NotImplementedException();
        }

        Task<List<ErSenderezeptePrezept>> IDatenERepository.GetPRezeptList()
        {
            throw new NotImplementedException();
        }

        Task<List<ErSenderezeptePrezept>> IDatenERepository.GetPRezeptListOffen(string apoik, int MaxNum)
        {
            throw new NotImplementedException();
        }

        Task<List<ErSenderezepteErezept>> IDatenERepository.GetERezeptListOffen(string apoik, int MaxNum)
        {
            throw new NotImplementedException();
        }


        Task<List<ErSenderezepteErezept>> IDatenERepository.GetERezeptList()
        {
            throw new NotImplementedException();
        }
    }
}
