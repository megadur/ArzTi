using ArzTiServer.OpenAPIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArzTiServer.Repositories;
using ArzTiServer.Models;

namespace ArzTiServer.Services
{
    public class ArzTiDatenService : IArzTiDatenService
    {
        IDatenRepository _datenRepository;
        public ArzTiDatenService(IDatenRepository datenRepository)
        {
            _datenRepository = datenRepository;
        }


        public async Task<ICollection<Rezept>> GetRezepteOffen(RezeptTyp? reztyp, string apoik, int? maxnum, string zeitraum)
        {

            List<Rezept> rezList = new List<Rezept>();
            if (reztyp == RezeptTyp.ERezept)
            {
                #region disable_format
                var list = await _datenRepository.GetMRezeptQueryable()
                    .Where(a => a.ApoIkNr.ToString() == apoik)
                    .ToListAsync();
                #endregion
                rezList.AddRange(getERezList(list));
            }
            return null;
        }

        public async Task<ICollection<Rezept>> GetRezepte(RezeptTyp reztyp, string apoik, int maxnum, string zeitraum)
        {
            List<Rezept> rezList = new List<Rezept>();
            //throw new NotImplementedException();
            if (reztyp == RezeptTyp.ERezept)
            {
                #region disable_format
                var list = await _datenRepository.GetMRezeptQueryable()
                    .Where(a => a.ApoIkNr.ToString() == apoik)
                    .ToListAsync()
                    ;
                #endregion 
                rezList.AddRange(getERezList(list));
            }

            return null;
        }
        public async Task<Rezept> GetRezept(RezeptTyp reztyp, string apoik, string rezid)
        {
            throw new NotImplementedException();
            if (reztyp == RezeptTyp.ERezept)
            {
                #region disable_format
                var res = await _datenRepository.GetMRezeptQueryable()
                    .Where(a => a.ApoIkNr.ToString() == apoik)
                    .Where(a => !a.Muster16Id.HasValue || a.Muster16Id.ToString() == rezid)
                    .FirstAsync() 
                    ;
                ;
                #endregion 
                return getERez(res);
            }
            return null;
        }

        internal List<Rezept> getERezList(List<ErSenderezepteEmuster16> list)
        {
            if (list == null)
            {
                return null;
            }
            var resList = new List<Rezept>();
            foreach (var item in list)
            {
                resList.Add(getERez(item));
            }
            return resList;

        }

        internal Rezept getERez(ErSenderezepteEmuster16 item)
        {
            return new Rezept
            {
                Typ = RezeptTyp.ERezept,
                Data = item.ErSenderezepteEmuster16Datens.First().XmlRequest
            };

        }
        internal Task<Rezept> GetRezeptAsync(string apoik, String reztyp, string rezid)
        {
            throw new NotImplementedException();
            //   _apoDatenDBContext.ErSenderezepteErezepts(r=>(r.)
        }
    }
}
