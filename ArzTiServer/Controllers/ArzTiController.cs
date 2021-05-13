
using ArzTiServer.OpenAPIService;
using ArzTiServer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.Controllers
{
    public class ArzTiController : IController
    {
        IArzTiDatenService _arzTiDatenService;
        IArzTiVerwaltungService _arzTiVerwaltungService;
        public ArzTiController(IArzTiDatenService arzTiDatenService, IArzTiVerwaltungService arzTiVerwaltungService)
        {
            _arzTiDatenService = arzTiDatenService;
            _arzTiVerwaltungService = arzTiVerwaltungService;
        }

        #region GET Apo
        public async Task<Apotheke> GetApothekeByIKAsync(string apoik)
        {
            return await _arzTiVerwaltungService.GetApothekeByIKAsync(apoik);
        }
        public async Task<ICollection<Apotheke>> GetApothekenListAsync()
        {
            return await _arzTiVerwaltungService.GetApothekenListAsync();
        }
        #endregion
        #region GET Rezept

        public async Task<Rezept> GetRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            return await _arzTiDatenService.GetRezeptIdAsync(apoik, reztyp, rezid);
        }
        public async Task<Rezept> GetRezeptUIdAsync(string ruid)
        {
            return await _arzTiDatenService.GetRezeptUIdAsync(ruid);
        }
        public async Task<Rezept> GetRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            return await _arzTiDatenService.GetRezeptIdStatusAsync(apoik, reztyp, rezid);
        }
        public async Task<RezeptStatus> GetRezeptUIdStatusAsync(string ruid)
        {
            return await _arzTiDatenService.GetRezeptUIdStatusAsync(ruid);
        }


        public async Task<ICollection<Rezept>> GetRezeptIdListAsync(string apoik, RezeptTyp? reztyp, int? maxnum, string zeitraum, IEnumerable<string> status)
        {
            return await _arzTiDatenService.GetRezeptIdListAsync(apoik, reztyp, maxnum, zeitraum);
        }
        public async Task<ICollection<Rezept>> GetRezeptIdListAbholstatusAsync(string apoik, RezeptTyp? reztyp, string zeitraum)
        {
            return await _arzTiDatenService.GetRezeptIdListByTransferAsync(apoik, reztyp, zeitraum);
        }
        public async Task<ICollection<RezeptStatus>> GetRezeptIdStatusListAsync(string apoik, RezeptTyp? reztyp, string zeitraum)
        {
            return await _arzTiDatenService.GetRezeptIdStatusListAsync(apoik, reztyp, zeitraum);
        }
        public async Task<ICollection<RezeptPruefResult>> GetRezeptIdListPruefResAsync(string apoik, RezeptTyp? reztyp, string zeitraum, IEnumerable<string> status)
        {
            return await _arzTiDatenService.GetRezeptIdListPruefResAsync(apoik, reztyp, zeitraum, status);
        }
        
        #endregion
        #region PUT

          public async Task PutRezeptIdListPruefungAsync(string apoik, IEnumerable<RezeptId> body)
        {
            await _arzTiDatenService.PutRezeptIdListPruefungAsync(apoik, body);
        }
        public async Task PutRezeptUidListPruefungAsync(IEnumerable<RezeptUId> body)
        {
            await _arzTiDatenService.PutRezeptUidListPruefungAsync(body);
        }

        #endregion
        #region PATCH
        public async Task<RezeptStatus> PatchRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string rezid, String status)
        {
            return await _arzTiDatenService.PatchRezeptIdStatusAsync(apoik, reztyp, rezid, status);
        }
        public async Task<RezeptStatus> PatchRezeptUIdStatusAsync(string ruid, string status)
        {
            return await _arzTiDatenService.PatchRezeptUIdStatusAsync(ruid, status);
        }
        public async Task<ICollection<RezeptStatus>> PatchRezeptIdListStatusAsync(string apoik, IEnumerable<RezeptStatus> body)
        {
            return await _arzTiDatenService.PatchRezeptIdListStatusAsync(apoik, body);
        }
        public async Task<ICollection<RezeptStatus>> PatchRezeptUIdListStatusAsync(IEnumerable<RezeptStatus> body)
        {
            return await _arzTiDatenService.PatchRezeptUIdListStatusAsync(body);
        }
        public async Task<ICollection<Abholstatus>> PatchRezeptIdListAbholstatusAsync(string apoik, IEnumerable<RezeptId> body)
        {
            return await _arzTiDatenService.PatchRezeptIdListAbholstatusAsync(apoik, body);
        }
        public async Task<ICollection<Abholstatus>> PatchRezeptUIdListAbholstatusAsync(IEnumerable<RezeptUId> body)
        {
            return await _arzTiDatenService.PatchRezeptUIdListAbholstatusAsync(body);
        }
        #endregion
        #region DELETE
        public async Task<Rezept> DeleteRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            return await _arzTiDatenService.DeleteRezeptIdAsync(apoik, reztyp, rezid);
        }
        public async Task<Rezept> DeleteRezeptUIdAsync(string ruid)
        {
            return await _arzTiDatenService.DeleteRezeptUIdAsync(ruid);
        }


        #endregion

        #region Neu

        #endregion

    }
}
