using ArzTiServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.Repositories
{
    public interface IVerwaltungRepository
    {
        //IQueryable<ErApotheke> GetApothekeQueryable();


        List<ErApotheke> GetApothekeList();

        ErApotheke GetApothekeDetails(String apoik);
    }
}
