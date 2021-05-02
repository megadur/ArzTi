using ArzTiServer.ArzTiService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArzTiServer.Services
{
    public interface IArzTiDatenService
    {
        Task<Rezept> DeleteRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid);
        Task<RezeptPruefRes> PutRezeptUidListPruefungAsync(Rezept body);
        Task<Abholstatus> PutRezeptUIdListAbholstatusAsync(IEnumerable<Abholstatus> body);
        Task<RezeptPruefRes> PutRezeptIdListPruefungAsync(string apoik, Rezept body);
        Task<Abholstatus> PutRezeptIdListAbholstatusAsync(string apoik, IEnumerable<Abholstatus> body);
        Task<Rezept> PatchRezeptUIdStatusAsync(string ruid, RezeptStatus body);
        Task<Rezept> PatchRezeptIdStatusAsync(string apoik, Reztyp reztyp, string rezid, RezeptStatus body);
        Task<ICollection<Rezept>> GetRezeptUIdAsync(string ruid);
        Task<Rezept> GetRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string rezid);
        Task<Rezept> DeleteRezeptUIdAsync(string ruid);
        Task<ICollection<RezeptStatus>> GetRezeptIdListByTransferAsync(string apoik, RezeptTyp? reztyp, string zeitraum);
        Task<ICollection<RezeptStatus>> GetRezeptIdListByStatusAsync(string apoik, RezeptTyp? reztyp, string zeitraum);
        Task<ICollection<Rezept>> GetRezeptIdListAsync(string apoik, RezeptTyp? reztyp, int? maxnum, string zeitraum);
        Task<Rezept> GetRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid);
    }
}