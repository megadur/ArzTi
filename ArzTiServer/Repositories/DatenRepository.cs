using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArzTiServer.Models;
using Microsoft.EntityFrameworkCore;

namespace ArzTiServer.Repositories
{
    public class DatenRepository : IDatenRepository
    {
        //private readonly DbSet<ErSenderezepteEmuster16> _dbSetMRezept;
        //private readonly DbSet<ErSenderezepteErezept> _dbSetERezept;
        //private readonly DbSet<ErSenderezeptePrezept> _dbSetPRezept;
        private readonly ArzDBContext _context;

        public DatenRepository(ArzDBContext context)
        {
            _context = context;
        }
        public IQueryable<ErSenderezepteEmuster16> GetMRezeptQueryable()
        {
            return _context.ErSenderezepteEmuster16s;
        }

        public List<ErSenderezepteEmuster16> GetMRezeptList() {
            return _context.ErSenderezepteEmuster16s.ToList();
        }
        
        public List<ErSenderezepteEmuster16> GetOffeneMRezeptList(String apoik, int MaxNum )
        {
            #region disable_format

            return _context.ErSenderezepteEmuster16s
                 .Where(a => a.ApoIkNr.ToString() == apoik)
                 .Take (MaxNum)
                 .ToList();
            #endregion
        }


        public IQueryable<ErSenderezeptePrezept> GetPRezeptQueryable()
        {
            return _context.ErSenderezeptePrezepts; 
        }

        public List<ErSenderezeptePrezept> GetPRezeptList()
        {
            return _context.ErSenderezeptePrezepts.ToList();
        }

        public List<ErSenderezeptePrezept> GetOffenePRezeptList(String apoik, int MaxNum)
        {
            #region disable_format

            return _context.ErSenderezeptePrezepts
                 .Where(a => a.ApoIkNr.ToString() == apoik)
                 .Take(MaxNum)
                 .ToList();
            #endregion
        }


        public IQueryable<ErSenderezepteErezept> GetERezeptQueryable()
        {
            return _context.ErSenderezepteErezepts;
        }

        public List<ErSenderezepteErezept> GetERezeptList()
        {
            return _context.ErSenderezepteErezepts.ToList();
        }

        public List<ErSenderezepteErezept> GetOffeneERezeptList(String apoik, int MaxNum)
        {
            #region disable_format
            return _context.ErSenderezepteErezepts
                 .Where(a => a.ApoIkNr.ToString() == apoik)
                 .Take(MaxNum)
                 .ToList();
            #endregion
        }

    }
}