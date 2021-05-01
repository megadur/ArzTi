using ArzTiServer.Models;
using ArzTiServer.OpenAPIService;
using ArzTiServer.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArzTiServer.Services
{

    public class ArzTiVerwaltungService: IArzTiVerwaltungService
    {
        IAsyncRepository<ErApotheke> _repository;
        public ArzTiVerwaltungService(IAsyncRepository<ErApotheke> repository)
        {
            _repository = repository;
        }

        public async Task<ICollection<Apotheke>> GetApothekenListAsync()
        {
            //throw new NotImplementedException();
            var list = await _repository.GetAll() ;
            return getList(list );

        }

        public async Task<ICollection<Apotheke>> GetApothekeAsync(string apoik)
        {
            var res= await _repository.GetWhere (a => a.ApoIkNr.ToString()  == apoik) ;
            return getList(res);
        }

        private ICollection<Apotheke> getList(IEnumerable<ErApotheke> list)
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
        private Apotheke getApotheke(ErApotheke item)
        {
            return new Apotheke()
            {
                Ik = item.ApoIkNr.ToString(),
                Name = item.ApothekeName
            };
        }

    }
}
