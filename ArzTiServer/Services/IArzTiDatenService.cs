
using ArzTiServer.OpenAPIService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArzTiServer.Services
{
    public interface IArzTiDatenService
    {
        Task<Rezept> GetRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid);
        Task<Rezept> GetRezeptUIdAsync(string ruid);
        Task<Rezept> GetRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string status);

        Task<Rezept> PatchRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string rezid, RezeptStatus body);
        Task<Rezept> PatchRezeptUIdStatusAsync(string ruid, RezeptStatusUId body);

        Task<Rezept> DeleteRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid);
        Task<Rezept> DeleteRezeptUIdAsync(string ruid);

        Task<ICollection<Rezept>>            GetRezeptIdListAsync(string apoik, RezeptTyp? reztyp, int? maxnum, string zeitraum);
        Task<ICollection<RezeptStatus>>      GetRezeptIdListByTransferAsync(string apoik, RezeptTyp? reztyp, string zeitraum);
        Task<ICollection<RezeptStatus>>      GetRezeptIdListByStatusAsync(string apoik, RezeptTyp? reztyp, string zeitraum);

        Task<ICollection<Abholstatus>>       PutRezeptIdListAbholstatusAsync(string apoik, IEnumerable<Abholstatus> body);
        Task<ICollection<AbholstatusUID>> PutRezeptUIdListAbholstatusAsync(IEnumerable<AbholstatusUID> body);
        Task<ICollection<RezeptPruefRes>>   PutRezeptIdListPruefungAsync(string apoik, IEnumerable<RezeptId> body);
        Task<ICollection<RezeptPruefResUId>> PutRezeptUidListPruefungAsync(IEnumerable<RezeptUId> body);
    }
}