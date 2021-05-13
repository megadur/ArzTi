
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
        IDatenERepository _datenRepository;
        public ArzTiDatenService(IDatenERepository datenRepository)
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
                Id= new RezeptId(){ Id = item.ErezeptId, Typ = RezeptTyp.ERezept } ,
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
        private RezeptStatus getERezeptStatus(StatusResult item)
        {
            if (checkERezStatus(item.status ))
            {
                return new RezeptStatus() { Id = new RezeptId() { Id = item.id , Typ = RezeptTyp.ERezept }, Status = item.status };
            }
            return null;
        }
        private bool checkERezStatus(string rezeptStatus)
        {
            if (rezeptStatus == "ABGERECHNET")
                return true;
            if (rezeptStatus == "ABRECHENBAR")
                return true;
            if (rezeptStatus == "FEHLER")
                return true;
            if (rezeptStatus == "HINWEIS")
                return true;
            if (rezeptStatus == "RUECKWEISUNG")
                return true;
            if (rezeptStatus == "STORNIERT")
                return true;
            if (rezeptStatus == "VERBESSERBAR")
                return true;
            if (rezeptStatus == "VOR_ABRECHNUNG")
                return true;
            if (rezeptStatus == "VOR_PRUEFUNG")
                return true;
            return false;

        }
        private IEnumerable<RezeptStatus> getERezStatusList(ICollection<StatusResult> list)
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
                Id = new RezeptId() { Id = item.Muster16Id.ToString() , Typ = RezeptTyp.MRezept },
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
            if (checkMRezStatus(item.ErSenderezepteEmuster16Statuses.Last().RezeptStatus))
            {
                return new RezeptStatus() { Id = new RezeptId() { Id = item.Muster16Id.ToString() , Typ = RezeptTyp.ERezept }, Status = item.ErSenderezepteEmuster16Statuses.Last().RezeptStatus };
            }
            return null;
        }
        private bool checkMRezStatus(string abrechenStatus)
        {
            if (abrechenStatus == "ABRECHENBAR")
                return true;
            if (abrechenStatus == "FEHLER")
                return true;
            if (abrechenStatus == "HINWEIS")
                return true;
            if (abrechenStatus == "VERBESSERBAR")
                return true;
            if (abrechenStatus == "VOR_PRUEFUNG")
                return true;
            return false;
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
        public async Task<ICollection<Rezept>> GetRezeptIdListByTransferAsync(string apoik, RezeptTyp? reztyp, string zeitraum)
        {
            var rezList = new List<Rezept>();
            if (reztyp == RezeptTyp.ERezept)
            {
                var list = await _datenRepository.GetERezeptIdListByTransferAsync(apoik, zeitraum);
                rezList.AddRange(getERezList(list));
            }
            return rezList;
        }
        public async Task<ICollection<Rezept>> GetRezeptIdListByStatusAsync(string apoik, RezeptTyp? reztyp, string zeitraum, IEnumerable<string> status)
        {
            List<Rezept> resList = new ();
            if (reztyp == RezeptTyp.ERezept)
            {
                var list = await _datenRepository.GetERezeptIdListByStatusAsync(apoik, zeitraum, status);
                resList.AddRange(getERezList(list));
            }
            return resList;
        }
        public async Task<ICollection<RezeptStatus>> GetRezeptIdStatusListAsync(string apoik, RezeptTyp? reztyp, string zeitraum)
        {
            List<RezeptStatus> resList = new ();
            if (reztyp == RezeptTyp.ERezept)
            {
                ICollection<StatusResult> list = await _datenRepository.GetERezeptIdStatusListAsync(apoik, zeitraum);
                resList.AddRange(getERezStatusList(list));
            }
            return resList;
        }
        public async Task<ICollection<RezeptPruefResult>> GetRezeptIdListPruefResAsync(string apoik, RezeptTyp? reztyp, string zeitraum, IEnumerable<string> status)
        {
            List<RezeptPruefResult> resList = new ();
            if (reztyp == RezeptTyp.ERezept)
            {
                ICollection<ErezeptPruefResult> list = await _datenRepository.GetERezeptIdListPruefResAsync(apoik, zeitraum, status);
                foreach(ErezeptPruefResult r in list)
                {
                    List<String> siList = new();

                    foreach (var si in r.infos)
                    {
                        siList.Add(si.Fcode + si.Fkommentar + si.Fstatus);
                    }
                    resList.Add(new RezeptPruefResult() { Id =new RezeptId() { Id = r.id , Typ = RezeptTyp.ERezept }, Uid = new RezeptUId() { Ruid= r.uid }, Statusinfo = siList });
                }
            }
            return resList;
        }
        public Task<RezeptStatus> GetRezeptUIdStatusAsync(string ruid)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Put     
        public async Task<ICollection<Abholstatus>> PatchRezeptIdListAbholstatusAsync(string apoik, IEnumerable<RezeptId> body)
        {
            List<Abholstatus> list = new ();
            List<string> rezeptlist = new ();
            foreach (var a in body)
            {
                if (a.Typ == RezeptTyp.ERezept)
                {
                    rezeptlist.Add(a.Id);
                }
            }
            var res = await _datenRepository.PatchERezeptIdListAbholstatusAsync(apoik, rezeptlist);
            foreach (var r in res)
            {
                list.Add(new Abholstatus() { Id = new RezeptId() { Id = r.Key,Typ = RezeptTyp.ERezept }, Uid = new RezeptUId() { }, Abgeholt = r.Value });
            }
            return list;
        }
        public async Task<ICollection<Abholstatus>> PatchRezeptUIdListAbholstatusAsync(IEnumerable<RezeptUId> body)
        {
            List<Abholstatus> list = new();
            List<string> rezeptlist = new();
            foreach (var a in body)
            {
                rezeptlist.Add(a.Ruid);
            }
            var res = await _datenRepository.PatchERezeptUIdListAbholstatusAsync(rezeptlist);
            foreach (var r in res)
            {
                list.Add(new Abholstatus() { Id = new RezeptId() { Id = r.Key, Typ = RezeptTyp.ERezept }, Uid = new RezeptUId() { }, Abgeholt = r.Value });
            }
            return list;
        }
        public async Task PutRezeptIdListPruefungAsync(string apoik, IEnumerable<RezeptId> body)
        {
            List<RezeptPruefResult> list = new List<RezeptPruefResult>();
            List<string> rezeptlist = new ();
            foreach (var a in body)
            {
                if (a.Typ == RezeptTyp.ERezept)
                {
                    rezeptlist.Add(a.Id);
                }
            }
            await _datenRepository.PutERezeptIdListPruefungAsync(apoik, rezeptlist);
            return ;
        }
        public async Task PutRezeptUidListPruefungAsync(IEnumerable<RezeptUId> body)
        {
            List<string> rezeptlist = new ();
            foreach (var a in body)
            {
                rezeptlist.Add(a.Ruid);
            }
            await _datenRepository.PatchERezeptUIdListAbholstatusAsync(rezeptlist);
            return;
        }

        #endregion
        #region Patch
        public async Task<RezeptStatus> PatchRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string rezid, string status)
        {
            if (reztyp == RezeptTyp.ERezept)
            {
                return await _datenRepository.PatchERezeptIdStatusAsync(apoik, rezid, status);
            }
            return null;
        }
        public async Task<RezeptStatus> PatchRezeptUIdStatusAsync(string ruid, string status)
        {
            RezeptStatus res = await _datenRepository.PatchERezeptUIdStatusAsync(ruid, status);
            if (res != null)
                return res;
            else
                return null;
        }
        public async Task<ICollection<RezeptStatus>> PatchRezeptIdListStatusAsync(string apoik, IEnumerable<RezeptStatus> body)
        {
            Dictionary<string, string> rezeptlist = new();
            foreach (var a in body)
            {
                if (a.Id.Typ == RezeptTyp.ERezept)
                  rezeptlist.Add(a.Id.Id, a.Status   );
            }
            Dictionary<string, string> rs = await _datenRepository.PatchERezeptIdListStatusAsync(apoik, rezeptlist);
            List<RezeptStatus> rslist = new();
            foreach (var r in rs)
            {
                rslist.Add(new RezeptStatus() { Id =new RezeptId() { Id =r.Key , Typ = RezeptTyp.ERezept }, Status =r.Value  });
            }
            return rslist;
        }
        public async Task<ICollection<RezeptStatus>> PatchRezeptUIdListStatusAsync(IEnumerable<RezeptStatus> body)
        {
            Dictionary<string, string> rezeptlist = new();
            foreach (var a in body)
            {
                if (a.Id.Typ == RezeptTyp.ERezept)
                    rezeptlist.Add(a.Id.Id, a.Status );
            }
            Dictionary<string, string> rs = await _datenRepository.PatchERezeptUIdListStatusAsync(rezeptlist);
            List<RezeptStatus> rslist = new();
            foreach (var r in rs)
            {
                rslist.Add(new RezeptStatus() { Uid =new RezeptUId(){ Ruid =r.Key  }, Status = r.Value });
            }
            return rslist;
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
