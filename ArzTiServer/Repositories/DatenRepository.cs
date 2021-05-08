using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArzTiServer.ArzTiService;
using ArzTiServer.Models;
using Microsoft.EntityFrameworkCore;

namespace ArzTiServer.Repositories
{
    public class DatenRepository : IDatenRepository
    {
         private readonly ArzDBContext _context;
     
        public DatenRepository(ArzDBContext context)
        {
            _context = context;
        }


        public async Task<ErSenderezepteErezept> DeleteERezeptIdAsync(string apoik, string rezid)
        {
            #region disable_format
            var res = _context.ErSenderezepteErezepts
                        .Where(a => a.ApoIkNr.ToString() == apoik)
                        .Where(a => a.ErezeptId.ToString() == rezid)
                        .First()
                        ;
            lock (_context.ErSenderezepteErezepts)
            {
                if (res != null)
                    _context.ErSenderezepteErezepts.Remove(res);
            }
            #endregion
            await _context.SaveChangesAsync();
            return res;
        }

        public async Task<ErSenderezepteErezept> DeleteERezeptUIdAsync(string ruid)
        {
            #region disable_format
            var res = _context.ErSenderezepteErezepts
                    .Where(e => e.ErSenderezepteErezeptDatens.First().RezeptUuid == ruid)
                    .First()
                    ;
            lock (_context.ErSenderezepteErezepts)
            {
                if (res != null)
                    _context.ErSenderezepteErezepts.Remove(res);
            }
            #endregion
            await _context.SaveChangesAsync();
            return res;
        }

        public async Task<ErSenderezepteErezept> GetERezeptIdAsync(string apoik, string rezid)
        {
            #region disable_format
            return await _context.ErSenderezepteErezepts
                    .Where(e => e.ApoIkNr.ToString() == apoik)
                    .Where(e => e.ErezeptId.ToString() == rezid)
                    .FirstAsync()
                    ;
            #endregion

        }

        public async Task<List<ErSenderezepteErezept>> GetERezeptIdListAsync(string apoik, int? maxnum, string zeitraum)
        {
            #region disable_format
            return await _context.ErSenderezepteErezepts
                .Where(a => a.ApoIkNr.ToString() == apoik)
                .ToListAsync();
            #endregion
        }

        public async Task<List<ErSenderezepteErezept>> GetERezeptIdListByStatusAsync(string apoik, string zeitraum)
        {
            #region disable_format
            return await _context.ErSenderezepteErezepts
                 .Where(a => a.ApoIkNr.ToString() == apoik)
                 .ToListAsync();
            #endregion
        }

        public async Task<List<ErSenderezepteErezept>> GetERezeptIdListByTransferAsync(string apoik, string zeitraum)
        {
            #region disable_format
            return await _context.ErSenderezepteErezepts
                 .Where(a => a.ApoIkNr.ToString() == apoik)
                 .ToListAsync();
            #endregion
        }

        public async Task<ErSenderezepteErezept> GetERezeptIdStatusAsync(string apoik, string rezid)
        {
            #region disable_format
            var res = _context.ErSenderezepteErezepts
                        .Where(a => a.ApoIkNr.ToString() == apoik)
                        .Where(a => a.ErezeptId.ToString() == rezid)
                        .First()
                        ;
            lock (_context.ErSenderezepteErezepts)
            {
                if (res != null)
                    _context.ErSenderezepteErezepts.Remove(res);
            }
            #endregion
            await _context.SaveChangesAsync();
            return res;
        }

        public async Task<List<ErSenderezepteErezept>> GetERezeptList()
        {
            return await _context.ErSenderezepteErezepts
                                 .ToListAsync();

        }

        public async Task<List<ErSenderezepteEmuster16>> GetMRezeptList()
        {
            return await _context.ErSenderezepteEmuster16s
                                 .ToListAsync();

        }

        public async Task<List<ErSenderezepteErezept>> GetERezeptListOffen(String apoik, int MaxNum)
        {
            #region disable_format
            return await _context.ErSenderezepteErezepts
                 .Where(a => a.ApoIkNr.ToString() == apoik)
                 .Take(MaxNum)
                 .ToListAsync();
            #endregion
        }

        public async Task<List<ErSenderezepteEmuster16>> GetMRezeptListOffen(String apoik, int MaxNum)
        {
            #region disable_format

            return await _context.ErSenderezepteEmuster16s
                 .Where(a => a.ApoIkNr.ToString() == apoik)
                 .Take(MaxNum)
                 .ToListAsync();
            #endregion
        }



        public async Task<List<ErSenderezeptePrezept>> GetPRezeptListOffen(String apoik, int MaxNum)
        {
            #region disable_format

            return await _context.ErSenderezeptePrezepts
                 .Where(a => a.ApoIkNr.ToString() == apoik)
                 .Take(MaxNum)
                 .ToListAsync();
            #endregion
        }

        public async Task<List<ErSenderezeptePrezept>> GetPRezeptList()
        {
            return await _context.ErSenderezeptePrezepts
                                 .ToListAsync();

        }
    }
}