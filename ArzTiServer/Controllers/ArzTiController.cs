
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

  
        #endregion
        #region PUT

        public async Task<ICollection<Abholstatus>> PutRezeptIdListAbholstatusAsync(string apoik, IEnumerable<Abholstatus> body)
        {
            return await _arzTiDatenService.PutRezeptIdListAbholstatusAsync(apoik, body);
        }
        public async Task<ICollection<AbholstatusUID>> PutRezeptUIdListAbholstatusAsync(IEnumerable<AbholstatusUID> body)
        {
            return await _arzTiDatenService.PutRezeptUIdListAbholstatusAsync(body);
        }
        public async Task<ICollection<RezeptPruefRes>> PutRezeptIdListPruefungAsync(string apoik, IEnumerable<RezeptId> body)
        {
            return await _arzTiDatenService.PutRezeptIdListPruefungAsync(apoik, body);
        }
        public async Task<ICollection<RezeptPruefResUId>> PutRezeptUidListPruefungAsync(IEnumerable<RezeptUId> body)
        {
            return await _arzTiDatenService.PutRezeptUidListPruefungAsync(body);
        }

        #endregion
        #region PATCH
        public async Task<Rezept> PatchRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string rezid, RezeptStatus body)
        {
            return await _arzTiDatenService.PatchRezeptIdStatusAsync(apoik, reztyp, rezid, body);
        }
        public async Task<Rezept> PatchRezeptUIdStatusAsync(string ruid, RezeptStatusUId body)
        {
            return await _arzTiDatenService.PatchRezeptUIdStatusAsync(ruid, body);
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

    }
}
