using ArzTiServer.ArzTiService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.Services
{
    public interface IArzTiVerwaltungService
    {

        public Task<ICollection<Apotheke>> GetApothekeByIKAsync(string apoik);

        public Task<ICollection<Apotheke>> GetApothekenListAsync();

    }
}
