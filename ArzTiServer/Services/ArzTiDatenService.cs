
using ArzTiServer.Models;
using ArzTiServer.OpenAPIService;
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

        #region internal
        private Rezept getERez(ErSenderezepteErezept item)
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
        private List<Rezept> getERezList(List<ErSenderezepteErezept> list)
        {
            var resList = new List<Rezept>();
            foreach (var item in list)
            {
                resList.Add(getERez(item));
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

        private Rezept getMRez(ErSenderezepteEmuster16 item)
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
        private List<Rezept> getMRezList(List<ErSenderezepteEmuster16> list)
        {
            var resList = new List<Rezept>();
            foreach (var item in list)
            {
                resList.Add(getMRez(item));
            }
            return resList;

        }
        private RezeptStatus getMRezeptStatus(ErSenderezepteEmuster16 item)
        {
            MRezeptStatus mRezeptStatus = getMRezStatus(item.ErSenderezepteEmuster16Statuses.Last().RezeptStatus);
            return new RezeptStatus() { Id = (int)item.Muster16Id, Typ = RezeptTyp.MRezept, StatusM = mRezeptStatus };
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

        #region Get
        public async Task<Rezept> GetRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            if (reztyp == RezeptTyp.ERezept)
            {
                var res = await _datenRepository.GetERezeptIdAsync(apoik, rezid);
                return getERez(res);
            }
            return null;
        }
        public async Task<Rezept> GetRezeptUIdAsync(string ruid)
        {
            var list = await _datenRepository.GetERezeptUIdAsync(ruid);
            return getERez(list);
        }
        public async Task<Rezept> GetRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            if (reztyp == RezeptTyp.ERezept)
            {
                var res = await _datenRepository.GetERezeptIdStatusAsync(apoik, rezid);
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
            var rezList = new List<RezeptStatus>();
            if (reztyp == RezeptTyp.ERezept)
            {
                var list = await _datenRepository.GetERezeptIdListByTransferAsync(apoik, zeitraum);
                rezList.AddRange(getERezStatusList(list));
            }
            return rezList;
        }
        #endregion

        #region Put     
        public async Task<ICollection<Abholstatus>> PutRezeptIdListAbholstatusAsync(string apoik, IEnumerable<Abholstatus> body)
        {
            List<Abholstatus> list = new List<Abholstatus>();
            Dictionary<string, bool> rezeptlist = new Dictionary<string, bool>();
            foreach (var a in body)
            {
                if (a.Typ == RezeptTyp.ERezept)
                {
                    rezeptlist.Add(a.Id, a.Abgeholt);
                }
            }
            var res = await _datenRepository.PutERezeptIdListAbholstatusAsync(apoik, rezeptlist);
            foreach (var r in res)
            {
                list.Add(new Abholstatus() { Id = r.Key, Abgeholt = r.Value });
            }
            return list;
        }
        public async Task<ICollection<AbholstatusUID>> PutRezeptUIdListAbholstatusAsync(IEnumerable<AbholstatusUID> body)
        {
            List<AbholstatusUID> list = new ();
            Dictionary<string, bool> rezeptlist = new Dictionary<string, bool>();
            foreach (var a in body)
            {
                rezeptlist.Add(a.Ruid, a.Abgeholt);
            }
            var res = await _datenRepository.PutERezeptUIdListAbholstatusAsync(rezeptlist);
            foreach (var r in res)
            {
                list.Add(new AbholstatusUID() { Ruid = r.Key , Abgeholt = r.Value});
            }
            return list;
        }
        public async Task<ICollection<RezeptPruefRes>> PutRezeptIdListPruefungAsync(string apoik, IEnumerable<RezeptId> body)
        {
            List<RezeptPruefRes> list = new List<RezeptPruefRes>();
            /*Dictionary<string, bool> rezeptlist = new Dictionary<string, bool>();
            foreach (var a in body)
            {
                if (a.Typ == RezeptTyp.ERezept)
                {
                    rezeptlist.Add(a.Typ = RezeptTyp.ERezept, a.Data);
                }
            }
            var res = await _datenRepository.PutERezeptUIdListAbholstatusAsync(rezeptlist);
            foreach (var r in res)
            {
                RezeptStatus s = new RezeptStatus();
                s.Id = r.Key;
                s.Typ = RezeptTyp.ERezept;
                s.StatusE = r.Value;
                list.Add(new RezeptPruefRes() {  Status.  Id = r.Key, Abgeholt = r.Value });
            }*/
            return list;
        }
        public async Task<ICollection<RezeptPruefResUId>> PutRezeptUidListPruefungAsync(IEnumerable<RezeptUId> body)
        {
            throw new NotImplementedException();
        }

        #endregion
        #region Patch
        public async Task<Rezept> PatchRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string rezid, RezeptStatus body)
        {
            throw new System.NotImplementedException();
        }
        public async Task<Rezept> PatchRezeptUIdStatusAsync(string ruid, RezeptStatusUId body)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Delete
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
        #endregion


        #region new

        #endregion


    }
}
