using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArzTiServer.Models;
using ArzTiServer.OpenAPIService;
using Microsoft.EntityFrameworkCore;

namespace ArzTiServer.Repositories
{
    public class DatenERepository : IDatenERepository
    {
         private readonly ArzDBContext _context;
     
        public DatenERepository(ArzDBContext context)
        {
            _context = context;
        }

        #region ERezept Get
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
        public async Task<ErSenderezepteErezept> GetERezeptUIdAsync(string ruid)
        {
            #region disable_format
            return await _context.ErSenderezepteErezepts
                    .Where(e => e.ErSenderezepteErezeptDatens.First().RezeptUuid == ruid)
                    .FirstAsync()
                    ;
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

        public async Task<List<ErSenderezepteErezept>>  GetERezeptIdListAsync(string apoik, int? maxnum, string zeitraum)
        {
            #region disable_format
            var r=await _context.ErSenderezepteErezepts
                //.Join(_context.ErSenderezepteErezeptDatens, r => r.IdSenderezepteErezept, d => d.IdSenderezepteErezept, (r, d) => new { ErSenderezepteErezept = r})
                .Where(a => a.ApoIkNr.ToString() == apoik)
                //.Select(post => new { post, post.ErSenderezepteErezeptDatens  })
                //.SelectMany(suit => _context.ErSenderezepteErezeptDatens.Select(rank => new { Suit = suit, suit.ErSenderezepteErezeptDatens = rank }))
                .ToListAsync();

            return r;
            #endregion
        }
        public async Task<List<ErSenderezepteErezept>>  GetERezeptIdListByTransferAsync(string apoik, string zeitraum)
        {
            #region disable_format
            return await _context.ErSenderezepteErezepts
                 .Where(a => a.ApoIkNr.ToString() == apoik)
                 .ToListAsync();
            #endregion
        }
        public async Task<List<ErSenderezepteErezept>>    GetERezeptIdStatusListAsync(string apoik, string zeitraum)
        {
            #region disable_format
            var res = await _context.ErSenderezepteErezepts
                 .Where(a => a.ApoIkNr.ToString() == apoik)
                 .ToListAsync();

            #endregion
            List<StatusResult> list = new();
            foreach (var r in res)
            {
                //list.Add(new StatusResult() { id = r.ErezeptId, uid = r.ErSenderezepteErezeptDatens.First().RezeptUuid, status = r.ErSenderezepteErezeptStatuses.First().RezeptStatus });
            }
            return res;
        }


        public async Task<List<ErSenderezepteErezept>> GetERezeptList()
        {
            return await _context.ErSenderezepteErezepts
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
        public async Task<List<ErSenderezepteErezept>> GetERezeptIdListByStatusAsync(string apoik, string zeitraum, IEnumerable<string> status)
        {
            #region disable_format
            return await _context.ErSenderezepteErezepts
                 .Where(a => a.ApoIkNr.ToString() == apoik)
                 .Where(s => s.ErSenderezepteErezeptStatuses.Any(p => status.Contains(p.RezeptStatus))
                 )
                 .ToListAsync();
            #endregion
        }

        public async Task<ICollection<ErezeptPruefResult>> GetERezeptIdListPruefResAsync(string apoik, string zeitraum, IEnumerable<string> status)
        {
            #region disable_format
            var res = await _context.ErSenderezepteErezepts
                .Where(a => a.ApoIkNr.ToString() == apoik)
                .ToListAsync();
            #endregion
            List<ErezeptPruefResult> list = new();
            foreach (var r in res)
            {
                foreach (var i in r.ErSenderezepteErezeptStatusinfos)
                {

                }
                list.Add(new ErezeptPruefResult() { id = r.ErezeptId, uid = r.ErSenderezepteErezeptDatens.First().RezeptUuid, infos = r.ErSenderezepteErezeptStatusinfos });
            }
            return list;
        }

        #endregion
        #region ERezept Put
        public async Task<Dictionary<string, bool>> PutERezeptIdListPruefungAsync(string apoik, List<string> rezeptlist)
           {
            Dictionary<string, bool> resList = new ();
            #region disable_format
            foreach (var r in rezeptlist)
            {
                var res = _context.ErSenderezepteErezepts
                        .Where(a => a.ApoIkNr == long.Parse(apoik))
                        .Where(a => a.ErezeptId == r )
                        .First()
                        ;
                if (res != null)
                {
                    lock (_context.ErSenderezepteErezepts)
                            res.ErSenderezepteErezeptStatuses.First().RezeptCheck = true;
                    resList.Add(r, true);
                }
                else
                {
                    resList.Add(r, false);
                }
                #endregion
                await _context.SaveChangesAsync();
            }
            return resList;
        }
        public async Task<Dictionary<string, bool>> PutERezeptUidListPruefungAsync(List<String> rezeptlist)
        {
            Dictionary<String, bool> resList = new();
            #region disable_format
            foreach (var r in rezeptlist)
            {
                var res = _context.ErSenderezepteErezepts
                        .Where(a => a.ErSenderezepteErezeptDatens.First().RezeptUuid == r)
                        .First()
                        ;
                if (res != null)
                {
                    lock (_context.ErSenderezepteErezepts)
                        res.ErSenderezepteErezeptStatuses.First().RezeptCheck = true;
                    resList.Add(r, true);
                }
                else
                {
                    resList.Add(r, false);
                }
                #endregion
                await _context.SaveChangesAsync();
            }
            return resList;
        }

        #endregion
        #region ERezept Patch
        public async Task<ErSenderezepteErezeptStatus> PatchERezeptStatusAsync(int id, string status)
        {
            #region disable_format
            var res = _context.ErSenderezepteErezeptStatuses
                    .Where(s => s.IdSenderezepteErezept.GetValueOrDefault().Equals(id))
                    .First()
                    ;
            #endregion
            if (res != null)
            {
                lock (_context.ErSenderezepteErezepts)
                    res.RezeptStatus = status;
            }
            await _context.SaveChangesAsync();
            return res;
        }
        public async Task<Dictionary<string, string>> PatchERezeptIdListStatusAsync(string apoik, Dictionary<string, string> rezeptlist)
        {
            Dictionary<string, string> resList = new();
            #region disable_format
            foreach (var r in rezeptlist)
            {
                var res = _context.ErSenderezepteErezepts
                        .Where(a => a.ApoIkNr == long.Parse(apoik))
                        .Where(a => a.ErezeptId == r.Key )
                        .First()
                        ;
                if (res != null)
                {
                    lock (_context.ErSenderezepteErezepts)
                        res.ErSenderezepteErezeptDatens.First().TransferArz = true;
                    resList.Add(res.ErezeptId, res.ErSenderezepteErezeptStatuses.First().RezeptStatus  );
                }
                else
                {
                    resList.Add(res.ErezeptId, "");
                }
                #endregion
                await _context.SaveChangesAsync();
            }
            return resList;
        }

        public async Task<Dictionary<string, string>> PatchERezeptUIdListStatusAsync(Dictionary<string, string> rezeptlist)
        {
            Dictionary<string, string> resList = new();
            #region disable_format
            foreach (var r in rezeptlist)
            {
                var res = _context.ErSenderezepteErezepts
                         .Where(a => a.ErSenderezepteErezeptDatens.First().RezeptUuid == r.Key )
                        .First()
                        ;
                if (res != null)
                {
                    lock (_context.ErSenderezepteErezepts)
                        res.ErSenderezepteErezeptDatens.First().TransferArz = true;
                    resList.Add(r.Key, res.ErSenderezepteErezeptStatuses.First().RezeptStatus);
                }
                else
                {
                    resList.Add(res.ErezeptId, "");
                }
                #endregion
                await _context.SaveChangesAsync();
            }
            return resList;
        }
        public async Task<Dictionary<string, bool>> PatchERezeptIdListAbholstatusAsync(string apoik, List<string> rezeptlist)
        {
            Dictionary<string, bool> resList = new();
            #region disable_format
            foreach (var r in rezeptlist)
            {
                var res = _context.ErSenderezepteErezepts
                        .Where(a => a.ApoIkNr == long.Parse(apoik))
                        .Where(a => a.ErezeptId == r)
                        .First()
                        ;
                if (res != null)
                {
                    lock (_context.ErSenderezepteErezepts)
                        res.ErSenderezepteErezeptDatens.First().TransferArz = true;
                    resList.Add(r, true);
                }
                else
                {
                    resList.Add(r, false);
                }
                #endregion
                await _context.SaveChangesAsync();
            }
            return resList;
        }
        public async Task<Dictionary<string, bool>> PatchERezeptUIdListAbholstatusAsync(List<string> rezeptlist)
        {
            Dictionary<String, bool> resList = new();
            #region disable_format
            foreach (var r in rezeptlist)
            {
                var res = _context.ErSenderezepteErezepts
                        .Where(a => a.ErSenderezepteErezeptDatens.First().RezeptUuid == r)
                        .First()
                        ;
                if (res != null)
                {
                    lock (_context.ErSenderezepteErezepts)
                        res.ErSenderezepteErezeptDatens.First().TransferArz = true;
                    resList.Add(r, true);
                }
                else
                {
                    resList.Add(r, false);
                }
                #endregion
                await _context.SaveChangesAsync();
            }
            return resList;
        }

        #endregion
        #region ERezept Delete
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
        #endregion

        public async Task<List<ErSenderezepteEmuster16>> GetMRezeptList()
        {
            return await _context.ErSenderezepteEmuster16s
                                 .ToListAsync();

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

        public async Task<ErSenderezepteErezeptDaten> GetERezeptDatenAsync(int id)
        {
            #region disable_format
            return await _context.ErSenderezepteErezeptDatens
                .Where(a => a.IdSenderezepteErezept == id)
                .FirstAsync()
                ;
            #endregion       
        }

        public async Task<ErSenderezepteErezeptStatus> GetERezeptStatusAsync(int id)
        {
            #region disable_format
            return await _context
                .ErSenderezepteErezeptStatuses 
                .Where(a => a.IdSenderezepteErezept == id)
                .FirstAsync()
                ;
            #endregion       
        }

        public async Task<List<ErSenderezepteErezeptStatusinfo>> GetERezeptStatusinfoListAsync(int id)
        {
            #region disable_format
            return await _context
                .ErSenderezepteErezeptStatusinfos
                .Where(a => a.IdSenderezepteErezept == id)
                .ToListAsync ()
                ;
            #endregion       
        }
    }
}