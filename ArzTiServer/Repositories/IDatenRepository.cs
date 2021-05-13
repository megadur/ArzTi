using ArzTiServer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArzTiServer.Repositories
{
    public interface IDatenRepository
    {
        #region ERezept

        Task<ErSenderezepteErezept> DeleteERezeptIdAsync(string apoik, string rezid);
        Task<ErSenderezepteErezept> DeleteERezeptUIdAsync(string ruid);

        Task<ErSenderezepteErezept> GetERezeptIdAsync(string apoik, string rezid);
        Task<ErSenderezepteErezept> GetERezeptUIdAsync(string ruid);
        Task<ErSenderezepteErezept> GetERezeptIdStatusAsync(string apoik, string status);

        Task<List<ErSenderezepteErezept>> GetERezeptIdListAsync(string apoik, int? maxnum, string zeitraum);
        Task<List<ErSenderezepteErezept>> GetERezeptIdListByStatusAsync(string apoik, string zeitraum);
        Task<List<ErSenderezepteErezept>> GetERezeptIdListByTransferAsync(string apoik, string zeitraum);
        Task<List<ErSenderezepteErezept>> GetERezeptListOffen(String apoik, int MaxNum);

        Task<List<ErSenderezepteErezept>> PutERezeptIdListPruefungAsync(List<ErSenderezepteErezept> rezeptlist);
        Task<List<ErSenderezepteErezept>> PutERezeptUidListPruefungAsync(List<ErSenderezepteErezept> rezeptlist);

        Task<Dictionary<string, bool>> PutERezeptIdListAbholstatusAsync(string apoik, Dictionary<string, bool> rezeptlist);
        Task<Dictionary<string, bool>> PutERezeptUIdListAbholstatusAsync(Dictionary<string, bool> rezeptlist);

        Task<ErSenderezepteErezept> PatchERezeptIdStatusAsync(string apoik, string rezid, string  status);
        Task<ErSenderezepteErezept> PatchERezeptUIdStatusAsync(string ruid, string status);


        #endregion

        #region MRezept
        Task<List<ErSenderezepteEmuster16>> GetMRezeptList();
        Task<List<ErSenderezepteEmuster16>> GetMRezeptListOffen(String apoik, int MaxNum);
        #endregion
        
        #region PRezept
        Task<List<ErSenderezeptePrezept>> GetPRezeptList();
        Task<List<ErSenderezeptePrezept>> GetPRezeptListOffen(String apoik, int MaxNum);
        #endregion

        #region RUID
        #endregion

    }
}
