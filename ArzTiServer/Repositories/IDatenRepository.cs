using ArzTiServer.Models;
using ArzTiServer.OpenAPIService;
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

        Task<ICollection<ErezeptPruefResult>>   GetERezeptIdListPruefResAsync(string apoik, string zeitraum, IEnumerable<string> status);
        Task<ICollection<StatusResult>>         GetERezeptIdStatusListAsync(string apoik, string zeitraum);

        Task<List<ErSenderezepteErezept>> GetERezeptIdListAsync(string apoik, int? maxnum, string zeitraum);
        Task<List<ErSenderezepteErezept>> GetERezeptIdListByStatusAsync(string apoik, string zeitraum, IEnumerable<string> status);
        Task<List<ErSenderezepteErezept>> GetERezeptIdListByTransferAsync(string apoik, string zeitraum);
        Task<List<ErSenderezepteErezept>> GetERezeptListOffen(String apoik, int MaxNum);

        Task<Dictionary<string, bool>> PutERezeptIdListPruefungAsync(string apoik, List<string> rezeptlist);
        Task<Dictionary<string, bool>> PutERezeptUidListPruefungAsync(List<string> rezeptlist);

        Task<Dictionary<string, bool>> PatchERezeptIdListAbholstatusAsync(string apoik, List<string> rezeptlist);
        Task<Dictionary<string, bool>> PatchERezeptUIdListAbholstatusAsync(List<string> rezeptlist);

        Task<RezeptStatus> PatchERezeptIdStatusAsync(string apoik, string rezid, string  status);
        Task<RezeptStatus> PatchERezeptUIdStatusAsync(string ruid, string status);


        #endregion

        #region MRezept
        Task<List<ErSenderezepteEmuster16>> GetMRezeptList();
        Task<List<ErSenderezepteEmuster16>> GetMRezeptListOffen(String apoik, int MaxNum);
        #endregion
        
        #region PRezept
        Task<List<ErSenderezeptePrezept>> GetPRezeptList();
        Task<List<ErSenderezeptePrezept>> GetPRezeptListOffen(String apoik, int MaxNum);
        Task<Dictionary<string, string>> PatchERezeptIdListStatusAsync(string apoik, Dictionary<string, string> rezeptlist);
        Task<Dictionary<string, string>> PatchERezeptUIdListStatusAsync(Dictionary<string, string> rezeptlist);
        #endregion

        #region RUID
        #endregion

    }
}
