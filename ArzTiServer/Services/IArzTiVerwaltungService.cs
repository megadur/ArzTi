
using ArzTiServer.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.Services
{
    public interface IArzTiVerwaltungService
    {

        public Task<Apotheke> GetApothekeByIKAsync(string apoik);

        public Task<ICollection<Apotheke>> GetApothekenListAsync();

    }
}
