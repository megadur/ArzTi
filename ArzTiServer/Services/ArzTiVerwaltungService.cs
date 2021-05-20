
using ArzTiServer.Models;
using ArzTiServer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.Services
{
    public class ArzTiVerwaltungService : IArzTiVerwaltungService
    {
        IAsyncRepository<ErApotheke> _repository;
        public ArzTiVerwaltungService(IAsyncRepository<ErApotheke> repository)
        {
            _repository = repository;
        }

        public ArzTiVerwaltungService()
        {
        }

        public async Task<Apotheke> GetApothekeByIKAsync(string apoik)
        {
            var res = await _repository.GetWhere(a => a.ApoIkNr.ToString() == apoik);
            Apotheke apo = new();
            apo.Ik = res.First().ApoIkNr.ToString ();
            apo.Name = res.First().ApothekeName;
            return apo;
        }

        public async Task<ICollection<Apotheke>> GetApothekenListAsync()
        {
            var list = await _repository.GetAll();
            return getList(list);
        }

        internal ICollection<Apotheke> getList(IEnumerable<ErApotheke> list)
        {
            if (list == null)
            {
                return null;
            }
            var apoList = new List<Apotheke>();
            foreach (var item in list)
            {
                apoList.Add(getApotheke(item));
            }
            return apoList;
        }
        internal Apotheke getApotheke(ErApotheke item)
        {
            return new Apotheke()
            {
                Ik = item.ApoIkNr.ToString(),
                Name = item.ApothekeName
            };
        }

    }
}
