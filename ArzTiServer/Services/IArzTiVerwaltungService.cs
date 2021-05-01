using ArzTiServer.OpenAPIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.Services
{
    public interface IArzTiVerwaltungService
    {
        public Task<ICollection<Apotheke>> GetApothekenListAsync();

        public Task<ICollection<Apotheke>> GetApothekeAsync(string apoik);

    }
}
