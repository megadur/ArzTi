using ArzTiServer.OpenAPIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.Services
{
    public interface IArzTiDatenService
    {
        public Task<ICollection<Rezept>> GetRezepteOffen(RezeptTyp? reztyp, string apoik, int? maxnum, string zeitraum);
        public Task<ICollection<Rezept>> GetRezepte(RezeptTyp reztyp, string apoik, int maxnum, string zeitraum);
        public Task<Rezept> GetRezept(RezeptTyp reztyp, string apoik, string rezid);

    }
}
