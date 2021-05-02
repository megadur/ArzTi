using ArzTiServer.ArzTiService;
using ArzTiServer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.Controllers
{
    public class ArzTiController : IArzTiController
    {
        IArzTiDatenService _arzTiDatenService;
        IArzTiVerwaltungService _arzTiVerwaltungService;
        public ArzTiController(IArzTiDatenService arzTiDatenService, IArzTiVerwaltungService arzTiVerwaltungService)
        {
            _arzTiDatenService = arzTiDatenService;
            _arzTiVerwaltungService = arzTiVerwaltungService;
        }

        public async Task<Rezept> DeleteRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            return await _arzTiDatenService.DeleteRezeptIdAsync(apoik, reztyp, rezid);
        }

        public async Task<Rezept> DeleteRezeptUIdAsync(string ruid)
        {
            return await _arzTiDatenService.DeleteRezeptUIdAsync(ruid);
        }

        public async Task<ICollection<Apotheke>> GetApothekeByIKAsync(string apoik)
        {
            return await _arzTiVerwaltungService.GetApothekeByIKAsync(apoik);
        }

        public async Task<ICollection<Apotheke>> GetApothekenListAsync()
        {
            return await _arzTiVerwaltungService.GetApothekenListAsync();
        }

        public async Task<Rezept> GetRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            return await _arzTiDatenService.GetRezeptIdAsync(apoik, reztyp, rezid);
        }

        public async Task<ICollection<Rezept>> GetRezeptIdListAsync(string apoik, RezeptTyp? reztyp, int? maxnum, string zeitraum)
        {
            return await _arzTiDatenService.GetRezeptIdListAsync(apoik, reztyp, maxnum, zeitraum);
        }

        public async Task<ICollection<RezeptStatus>> GetRezeptIdListByStatusAsync(string apoik, RezeptTyp? reztyp, string zeitraum)
        {
            return await _arzTiDatenService.GetRezeptIdListByStatusAsync(apoik, reztyp, zeitraum);
        }

        public async Task<ICollection<RezeptStatus>> GetRezeptIdListByTransferAsync(string apoik, RezeptTyp? reztyp, string zeitraum)
        {
            return await _arzTiDatenService.GetRezeptIdListByTransferAsync(apoik, reztyp, zeitraum);
        }

        public async Task<Rezept> GetRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            return await _arzTiDatenService.GetRezeptIdStatusAsync(apoik, reztyp, rezid);
        }

        public async Task<ICollection<Rezept>> GetRezeptUIdAsync(string ruid)
        {
            return await _arzTiDatenService.GetRezeptUIdAsync(ruid);
        }

        public async Task<Rezept> PatchRezeptIdStatusAsync(string apoik, Reztyp reztyp, string rezid, RezeptStatus body)
        {
            return await _arzTiDatenService.PatchRezeptIdStatusAsync(apoik, reztyp, rezid, body);
        }

        public async Task<Rezept> PatchRezeptUIdStatusAsync(string ruid, RezeptStatus body)
        {
            return await _arzTiDatenService.PatchRezeptUIdStatusAsync(ruid, body);
        }

        public async Task<Abholstatus> PutRezeptIdListAbholstatusAsync(string apoik, IEnumerable<Abholstatus> body)
        {
            return await _arzTiDatenService.PutRezeptIdListAbholstatusAsync(apoik, body);
        }

        public async Task<RezeptPruefRes> PutRezeptIdListPruefungAsync(string apoik, Rezept body)
        {
            return await _arzTiDatenService.PutRezeptIdListPruefungAsync(apoik, body);
        }

        public async Task<Abholstatus> PutRezeptUIdListAbholstatusAsync(IEnumerable<Abholstatus> body)
        {
            return await _arzTiDatenService.PutRezeptUIdListAbholstatusAsync(body);
        }

        public async Task<RezeptPruefRes> PutRezeptUidListPruefungAsync(Rezept body)
        {
            return await _arzTiDatenService.PutRezeptUidListPruefungAsync(body);
        }
    }
}
