
using ArzTiServer.Api.Model;
using ArzTiServer.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.xUnit
{
    class ArzTiVerwaltungServiceFake : IArzTiVerwaltungService
    {
        ICollection<Apotheke> _apos;
        public ArzTiVerwaltungServiceFake()
        {
            _apos = new List<Apotheke>()
            {
                new Apotheke(){ Ik ="1", Name ="Apo1" },
                new Apotheke(){ Ik ="12", Name ="Apo2" },
                new Apotheke(){ Ik ="123", Name ="Apo3" }
            };
        }
        public Task<Apotheke> GetApothekeByIKAsync(string apoik)
        {
            return Task.FromResult(_apos.Where(a => a.Ik == apoik).FirstOrDefault());
        }

        public Task<ICollection<Apotheke>> GetApothekenListAsync()
        {
            return Task.FromResult((ICollection<Apotheke>)_apos);
        }
    }
}
