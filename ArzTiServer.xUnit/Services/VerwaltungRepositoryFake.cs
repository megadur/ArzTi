using ArzTiServer.Api.Model;
using ArzTiServer.Domain.Model;
using ArzTiServer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzTiServer.xUnit
{
     class VerwaltungRepositoryFake : IVerwaltungRepository
    {
        private List<ErApotheke> _erApothekeList;
        public VerwaltungRepositoryFake()
        {
            _erApothekeList = new List<ErApotheke>()
            {
            new ErApotheke(){ ApoIkNr =1234L, ApothekeName = "Apotheke1" },
            new ErApotheke() { ApoIkNr = 12345L, ApothekeName = "Apotheke2" },
            new ErApotheke() { ApoIkNr = 123456L, ApothekeName = "Apotheke3" },
            };


        }
        public ErApotheke GetApothekeDetails(string apoik)
        {
            return _erApothekeList.Where(a => a.ApoIkNr.ToString () == apoik).FirstOrDefault();
        }

        public List<ErApotheke> GetApothekeList()
        {
            return _erApothekeList;
        }
    }
}
