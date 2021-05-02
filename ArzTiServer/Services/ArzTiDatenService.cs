using ArzTiServer.ArzTiService;
using ArzTiServer.Models;
using ArzTiServer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArzTiServer.Services
{
    public class ArzTiDatenService : IArzTiDatenService
    {
        IDatenRepository _datenRepository;
        public ArzTiDatenService(IDatenRepository datenRepository)
        {
            _datenRepository = datenRepository;
        }

        public async Task<Rezept> DeleteRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            if (reztyp == RezeptTyp.ERezept)
            {
                var res = await _datenRepository.DeleteERezeptIdAsync(apoik, rezid);
                return getERez(res);
            }
            return null;
        }

        public async Task<Rezept> DeleteRezeptUIdAsync(string ruid)
        {
            var res = await _datenRepository.DeleteERezeptUIdAsync(ruid);
            return getERez(res);
        }


        public async Task<Rezept> GetRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            if (reztyp == RezeptTyp.ERezept)
            {
                var res = await _datenRepository.GetERezeptIdAsync(apoik, rezid);
                return getERez(res);
            }
            return null;
        }

        public async Task<ICollection<Rezept>> GetRezeptIdListAsync(string apoik, RezeptTyp? reztyp, int? maxnum, string zeitraum)
        {
            List<Rezept> rezList = new List<Rezept>();
            if (reztyp == RezeptTyp.ERezept)
            {
                var list = await _datenRepository.GetERezeptIdListAsync(apoik, maxnum, zeitraum);
                rezList.AddRange(getERezList(list));
            }
            return rezList;
        }

        public async Task<ICollection<RezeptStatus>> GetRezeptIdListByStatusAsync(string apoik, RezeptTyp? reztyp, string zeitraum)
        {
            List<RezeptStatus> resList = new List<RezeptStatus>();
            if (reztyp == RezeptTyp.ERezept)
            {
                var list = await _datenRepository.GetERezeptIdListByStatusAsync(apoik, zeitraum);
                resList.AddRange(getERezStatusList(list));
            }
            return resList;
        }

        public async Task<ICollection<RezeptStatus>> GetRezeptIdListByTransferAsync(string apoik, RezeptTyp? reztyp, string zeitraum)
        {
            List<RezeptStatus> rezList = new List<RezeptStatus>();
            if (reztyp == RezeptTyp.ERezept)
            {
                var list = await _datenRepository.GetERezeptIdListByTransferAsync(apoik, zeitraum);
                rezList.AddRange(getERezStatusList(list));
            }
            return rezList;
        }


        public async Task<Rezept> GetRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            if (reztyp == RezeptTyp.ERezept)
            {
                var res = await _datenRepository.GetERezeptIdStatusAsync( apoik, rezid);
                return getERez(res);
            }
            return null;
        }

        public async Task<ICollection<Rezept>> GetRezeptUIdAsync(string ruid)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Rezept> PatchRezeptIdStatusAsync(string apoik, Reztyp reztyp, string rezid, RezeptStatus body)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Rezept> PatchRezeptUIdStatusAsync(string ruid, RezeptStatus body)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Abholstatus> PutRezeptIdListAbholstatusAsync(string apoik, IEnumerable<Abholstatus> body)
        {
            throw new System.NotImplementedException();
        }

        public async Task<RezeptPruefRes> PutRezeptIdListPruefungAsync(string apoik, Rezept body)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Abholstatus> PutRezeptUIdListAbholstatusAsync(IEnumerable<Abholstatus> body)
        {
            throw new System.NotImplementedException();
        }

        public async Task<RezeptPruefRes> PutRezeptUidListPruefungAsync(Rezept body)
        {
            throw new System.NotImplementedException();
        }
        #region internal
        internal Rezept getERez(ErSenderezepteErezept item)
        {
            String xml = "";
            if (item.ErSenderezepteErezeptDatens.Count > 0)
                xml = item.ErSenderezepteErezeptDatens.First().XmlRequest;
            return new Rezept
            {
                Typ = RezeptTyp.ERezept,
                Data = xml
            };

        }

        internal List<Rezept> getERezList(List<ErSenderezepteErezept> list)
        {
            var resList = new List<Rezept>();
            foreach (var item in list)
            {
                resList.Add(getERez(item));
            }
            return resList;

        }
        internal Rezept getMRez(ErSenderezepteEmuster16 item)
        {
            String xml = "";
            if (item.ErSenderezepteEmuster16Datens.Count > 0)
                xml = item.ErSenderezepteEmuster16Datens.First().XmlRequest;

            return new Rezept
            {
                Typ = RezeptTyp.ERezept,
                Data = item.ErSenderezepteEmuster16Datens.First().XmlRequest
            };

        }

        internal List<Rezept> getMRezList(List<ErSenderezepteEmuster16> list)
        {
            var resList = new List<Rezept>();
            foreach (var item in list)
            {
                resList.Add(getMRez(item));
            }
            return resList;

        }
        private RezeptStatus getERezeptStatus(ErSenderezepteErezept item)
        {
            ERezeptStatus status = getERezStatus(item.ErSenderezepteErezeptStatuses.Last().RezeptStatus);
            return new RezeptStatus() { Id = Int32.Parse(item.ErezeptId), Typ = RezeptTyp.ERezept };
        }

        private ERezeptStatus getERezStatus(string rezeptStatus)
        {
            if (rezeptStatus == "ABGERECHNET")
                return ERezeptStatus.ABGERECHNET;
            if (rezeptStatus == "ABRECHENBAR")
                return ERezeptStatus.ABRECHENBAR;
            if (rezeptStatus == "FEHLER")
                return ERezeptStatus.FEHLER;
            if (rezeptStatus == "HINWEIS")
                return ERezeptStatus.HINWEIS;
            if (rezeptStatus == "RUECKWEISUNG")
                return ERezeptStatus.RUECKWEISUNG;
            if (rezeptStatus == "STORNIERT")
                return ERezeptStatus.STORNIERT;
            if (rezeptStatus == "VERBESSERBAR")
                return ERezeptStatus.VERBESSERBAR__;
            if (rezeptStatus == "VOR_ABRECHNUNG")
                return ERezeptStatus.VOR_ABRECHNUNG;
            if (rezeptStatus == "VOR_PRUEFUNG")
                return ERezeptStatus.VOR_PRUEFUNG;
            return ERezeptStatus.FEHLER;

        }

        private IEnumerable<RezeptStatus> getERezStatusList(List<ErSenderezepteErezept> list)
        {
            var resList = new List<RezeptStatus>();
            if (list != null)
            {
                foreach (var item in list)
                {
                    resList.Add(getERezeptStatus(item));
                }
            }
            return resList;
        }
        private RezeptStatus getMRezeptStatus(ErSenderezepteEmuster16 item)
        {
            MRezeptStatus mRezeptStatus = getMRezStatus(item.ErSenderezepteEmuster16Statuses.Last().RezeptStatus);
            return new RezeptStatus() { Id = (int)item.Muster16Id, Typ = RezeptTyp.MRezept, Status = mRezeptStatus };
        }
        private MRezeptStatus getMRezStatus(string abrechenStatus)
        {
            if (abrechenStatus == "ABRECHENBAR")
                return MRezeptStatus.ABRECHENBAR;
            if (abrechenStatus == "FEHLER")
                return MRezeptStatus.FEHLER;
            if (abrechenStatus == "HINWEIS")
                return MRezeptStatus.HINWEIS;
            if (abrechenStatus == "VERBESSERBAR")
                return MRezeptStatus.VERBESSERBAR;
            if (abrechenStatus == "VOR_PRUEFUNG")
                return MRezeptStatus.VOR_PRUEFUNG;
            return MRezeptStatus.FEHLER;
        }
        #endregion
    }
}
