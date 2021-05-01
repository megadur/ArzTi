using ArzTiServer.OpenAPIService;
using ArzTiServer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.Controllers
{
    public class ArzTiControllerImpl : IArzTiController
    {
        IArzTiDatenService _arzTiDatenService;
        IArzTiVerwaltungService _arzTiVerwaltungService;

        public ArzTiControllerImpl(IArzTiDatenService arzTiDatenService, IArzTiVerwaltungService arzTiVerwaltungService)
        {
            _arzTiDatenService = arzTiDatenService;
            _arzTiVerwaltungService = arzTiVerwaltungService;
        }
        public Task<Rezept> DeleteRezeptAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Apotheke>> GetApothekeAsync(string apoik)
        {
            //throw new NotImplementedException();
            return await _arzTiVerwaltungService.GetApothekeAsync( apoik);
        }

        public async Task<ICollection<Apotheke>> GetApothekenListAsync()
        {
            //throw new NotImplementedException();
            return await _arzTiVerwaltungService.GetApothekenListAsync();
        }

        public async Task<ICollection<Rezept>> GetRezeptAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            //throw new NotImplementedException();
            return await _arzTiDatenService.GetRezepte (reztyp, apoik, 10, "");

        }

        public async Task<ICollection<Rezept>> GetRezepteOffen(string apoik, RezeptTyp? reztyp, int? maxnum, string zeitraum)
        {
            //throw new NotImplementedException();
            return await _arzTiDatenService.GetRezepteOffen(reztyp, apoik, maxnum, zeitraum);
        }

        public Task<ICollection<RezeptStatus>> GetRezeptListByStatusAsync(string apoik, RezeptTyp? reztyp, string zeitraum)
        {
            throw new NotImplementedException();
        }
        public Task<Rezept> GetRezeptStatusAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            throw new NotImplementedException();
        }

        public Task<Rezept> PatchRezeptStatusAsync(string apoik, Reztyp reztyp, string rezid, RezeptStatus body)
        {
            throw new NotImplementedException();
        }

        public Task<Abholstatus> PutAbholstatusRezeptListAsync(string apoik, IEnumerable<Abholstatus> body)
        {
            throw new NotImplementedException();
        }

        public Task<RezeptPruefRes> PutRezeptPruefungAsync(string apoik, Rezept body)
        {
            throw new NotImplementedException();
        }

        async Task<Rezept> IArzTiController.GetRezeptAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            //throw new NotImplementedException();
            return await _arzTiDatenService.GetRezept(reztyp, apoik, rezid);

        }
    }
}
