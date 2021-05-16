
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
        Task<ICollection<Rezept>>               GetRezeptIdListAsync(string apoik, RezeptTyp? reztyp, int? maxnum, string zeitraum);
        Task<ICollection<Rezept>>               GetRezeptIdListByTransferAsync(string apoik, RezeptTyp? reztyp, string zeitraum);
        Task<ICollection<RezeptStatus>>         GetRezeptIdStatusListAsync(string apoik, RezeptTyp? reztyp, string zeitraum);
        Task<ICollection<RezeptPruefResult>>    GetRezeptIdListPruefResAsync(string apoik, RezeptTyp? reztyp, string zeitraum, IEnumerable<string> status);

        Task<RezeptStatus>              GetRezeptUIdStatusAsync(string ruid);
        Task<RezeptStatus>              PatchRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string rezid, string body);
        Task<RezeptStatus>              PatchRezeptUIdStatusAsync(string ruid, string body);
        Task<ICollection<RezeptStatus>> PatchRezeptIdListStatusAsync(string apoik, IEnumerable<RezeptStatus> body);
        Task<ICollection<RezeptStatus>> PatchRezeptUIdListStatusAsync(IEnumerable<RezeptStatus> body);

        Task<Rezept>                    DeleteRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid);
        Task<Rezept>                    DeleteRezeptUIdAsync(string ruid);

        Task<ICollection<Abholstatus>>  PatchRezeptIdListAbholstatusAsync(string apoik, IEnumerable<RezeptId> body);
        Task<ICollection<Abholstatus>>  PatchRezeptUIdListAbholstatusAsync(IEnumerable<RezeptUId> body);
        Task                            PutRezeptIdListPruefungAsync(string apoik, IEnumerable<RezeptId> body);
        Task                            PutRezeptUidListPruefungAsync(IEnumerable<RezeptUId> body);
    }
}