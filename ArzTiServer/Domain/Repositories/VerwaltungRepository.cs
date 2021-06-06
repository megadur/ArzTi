using ArzTiServer.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.Domain.Repositories
{
    public class VerwaltungRepository : IVerwaltungRepository
    {
        private readonly DbSet<ErApotheke> _dbSet;

        public VerwaltungRepository(DbSet<ErApotheke> dbSet)
        {
            _dbSet = dbSet;
        }
        public List<ErApotheke> GetApothekeList()
        {
            return _dbSet.ToList (); 
        }

        public ErApotheke GetApothekeDetails(string apoik)
        {
            long lapoik = long.Parse(apoik);
            return _dbSet.Where(a=> a.ApoIkNr == lapoik).FirstOrDefault ();

        }

    }
}
