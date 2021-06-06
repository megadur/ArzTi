using ArzTiServer.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzTiServer.xUnit
{
    class FakeData
    {
        public static List<ErSenderezepteErezeptStatus> getErSenderezepteErezeptStatus()
        {
            var data = new List<ErSenderezepteErezeptStatus>
            {
                new ErSenderezepteErezeptStatus{ IdSenderezepteErezept=0, RezeptStatus="Status1", RezeptCheck = false}
            };
            return data;
        }
        public static List<ErSenderezepteErezept> getErSenderezepteErezept()
        {
            var datens1 = new List<ErSenderezepteErezeptDaten>
            {
                new ErSenderezepteErezeptDaten{ RezeptUuid ="UUID1", TransferArz =false, XmlRequest="XML1"}
            };
            var datens2 = new List<ErSenderezepteErezeptDaten>
            {
                new ErSenderezepteErezeptDaten{ RezeptUuid ="UUID2", TransferArz =true, XmlRequest="XML2"}
            };
            var statuses1 = new List<ErSenderezepteErezeptStatus>
            {
                new ErSenderezepteErezeptStatus{ ErezeptId ="Id1", RezeptStatus="Status1", RezeptCheck = false}
            };
            var statuses2 = new List<ErSenderezepteErezeptStatus>
            {
                new ErSenderezepteErezeptStatus{ ErezeptId ="Id1", RezeptStatus="Status2", RezeptCheck = true}
            };
            var data = new List<ErSenderezepteErezept>
            {
                new ErSenderezepteErezept { IdSenderezepteErezept=0,ErezeptId = "A1Id1", ApoIkNr= 1L, ErSenderezepteErezeptDatens=datens1, ErSenderezepteErezeptStatuses=statuses1  } ,
                new ErSenderezepteErezept { IdSenderezepteErezept=1,ErezeptId = "A1Id2", ApoIkNr= 1L, ErSenderezepteErezeptDatens=datens2, ErSenderezepteErezeptStatuses=statuses2  } ,
                new ErSenderezepteErezept { IdSenderezepteErezept=2,ErezeptId = "A2Id1", ApoIkNr= 2L, ErSenderezepteErezeptDatens=datens1 , ErSenderezepteErezeptStatuses=statuses1  },
                new ErSenderezepteErezept { IdSenderezepteErezept=3,ErezeptId = "A3Id1", ApoIkNr= 3L, ErSenderezepteErezeptDatens=datens1 , ErSenderezepteErezeptStatuses=statuses2 },
            };
            foreach (var d in data)
            {
                d.ErSenderezepteErezeptDatens.First().IdSenderezepteErezept = d.IdSenderezepteErezept;
                d.ErSenderezepteErezeptStatuses.First().IdSenderezepteErezept = d.IdSenderezepteErezept;
            }

            return data;

        }
    }
}
