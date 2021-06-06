using ArzTiServer.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.Domain.Repositories
{
    public interface IVerwaltungRepository
    {
        //IQueryable<ErApotheke> GetApothekeQueryable();


        List<ErApotheke> GetApothekeList();

        ErApotheke GetApothekeDetails(String apoik);
    }
}
