
using ArzTiServer.Models;
using ArzTiServer.Repositories;
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
        private async Task<Rezept> getERez(ErSenderezepteErezept item)
        {
            if (item == null)
                return null;
            var erd = await _datenRepository.GetERezeptDatenAsync(item.IdSenderezepteErezept);
            var ers = await _datenRepository.GetERezeptStatusAsync(item.IdSenderezepteErezept);

            return new Rezept
            {
                Id = new RezeptId() { Id = item.ErezeptId, Typ = RezeptTyp.ERezeptEnum },
                Uid = new RezeptUId() { Ruid = erd.RezeptUuid },
                Data = erd.XmlRequest,
                Status = ers.RezeptStatus
            };

        }
        private async Task<List<Rezept>> getERezList(List<ErSenderezepteErezept> list)
        {
            if (list == null)
                return null;
            var resList = new List<Rezept>();
            foreach (var item in list)
            {
                resList.Add(await getERez(item));
            }
            return resList;

        }
        private async Task<RezeptStatus> getERezeptStatus(ErSenderezepteErezept item)
        {
            if (item == null)
                return null;
            var ers = await _datenRepository.GetERezeptStatusAsync(item.IdSenderezepteErezept);
            return new RezeptStatus() { Id = new RezeptId() { Id = item.ErezeptId, Typ = RezeptTyp.ERezeptEnum }, Status = ers.RezeptStatus };
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
        private async Task<IEnumerable<RezeptStatus>> getERezStatusList(ICollection<ErSenderezepteErezept> list)
        {
            if (list == null)
                return null;
            var resList = new List<RezeptStatus>();
            if (list != null)
            {
                foreach (var item in list)
                {
                    resList.Add(await getERezeptStatus(item));
                }
            }
            return resList;
        }

        private Rezept getMRez(ErSenderezepteEmuster16 item)
        {
            if (item == null)
                return null;

            String xml = "";
            if (item.ErSenderezepteEmuster16Datens.Count > 0)
                xml = item.ErSenderezepteEmuster16Datens.First().XmlRequest;

            return new Rezept
            {
                Id = new RezeptId() { Id = item.Muster16Id.ToString(), Typ = RezeptTyp.MRezeptEnum },
                Data = item.ErSenderezepteEmuster16Datens.First().XmlRequest
            };

        }
        private List<Rezept> getMRezList(List<ErSenderezepteEmuster16> list)
        {
            if (list == null)
                return null;
            var resList = new List<Rezept>();
            foreach (var item in list)
            {
                resList.Add(getMRez(item));
            }
            return resList;

        }
        private RezeptStatus getMRezeptStatus(ErSenderezepteEmuster16 item)
        {
            if (item == null)
                return null;
            if (checkMRezStatus(item.ErSenderezepteEmuster16Statuses.Last().RezeptStatus))
            {
                return new RezeptStatus() { Id = new RezeptId() { Id = item.Muster16Id.ToString(), Typ = RezeptTyp.ERezeptEnum }, Status = item.ErSenderezepteEmuster16Statuses.Last().RezeptStatus };
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
            try
            {
                if (reztyp == RezeptTyp.ERezeptEnum)
                {
                    var res = await _datenRepository.GetERezeptIdAsync(apoik, rezid);
                    return await getERez(res);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

            return null;
        }
        public async Task<Rezept> GetRezeptUIdAsync(string ruid)
        {
            try
            {
                var list = await _datenRepository.GetERezeptUIdAsync(ruid);
                return await getERez(list);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return null;
        }
        public async Task<Rezept> GetRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            if (reztyp == RezeptTyp.ERezeptEnum)
            {
                var res = await _datenRepository.GetERezeptIdStatusAsync(apoik, rezid);
                return await getERez(res);
            }
            return null;
        }

        public async Task<ICollection<Rezept>> GetRezeptIdListAsync(string apoik, RezeptTyp? reztyp, int? maxnum, string zeitraum)
        {
            List<Rezept> rezList = new List<Rezept>();
            if (reztyp == null || reztyp == RezeptTyp.ERezeptEnum)
            {
                var erl = await _datenRepository.GetERezeptIdListAsync(apoik, maxnum, zeitraum);
                foreach (var r in erl)
                {
                    var rr = await getERez(r);
                    rezList.Add(rr);
                }

            }
            return rezList;
        }
        public async Task<ICollection<Rezept>> GetRezeptIdListByTransferAsync(string apoik, RezeptTyp? reztyp, string zeitraum)
        {
            var rezList = new List<Rezept>();
            if (reztyp == null || reztyp == RezeptTyp.ERezeptEnum)
            {
                var list = await _datenRepository.GetERezeptIdListByTransferAsync(apoik, zeitraum);
                rezList.AddRange(await getERezList(list));
            }
            return rezList;
        }
        public async Task<ICollection<Rezept>> GetRezeptIdListByStatusAsync(string apoik, RezeptTyp? reztyp, string zeitraum, IEnumerable<string> status)
        {
            List<Rezept> resList = new();
            if (reztyp == null || reztyp == RezeptTyp.ERezeptEnum)
            {
                var res = await _datenRepository.GetERezeptIdListByStatusAsync(apoik, zeitraum, status);
                List<StatusResult> list = new();
                foreach (var r in res)
                {
                    // list.Add(new StatusResult() { id = r.ErezeptId, uid = r.ErSenderezepteErezeptDatens.First().RezeptUuid, status = r.ErSenderezepteErezeptStatuses.First().RezeptStatus });
                }
                resList.AddRange(await getERezList(res));
            }
            return resList;
        }
        public async Task<ICollection<RezeptStatus>> GetRezeptIdStatusListAsync(string apoik, RezeptTyp? reztyp, string zeitraum)
        {
            List<RezeptStatus> resList = new();
            if (reztyp == null || reztyp == RezeptTyp.ERezeptEnum)
            {
                var list = await _datenRepository.GetERezeptIdStatusListAsync(apoik, zeitraum);
                resList.AddRange(await getERezStatusList(list));
            }
            return resList;
        }
        public async Task<ICollection<RezeptPruefResult>> GetRezeptIdListPruefResAsync(string apoik, RezeptTyp? reztyp, string zeitraum, IEnumerable<string> status)
        {
            List<RezeptPruefResult> resList = new();
            if (reztyp == null || reztyp == RezeptTyp.ERezeptEnum)
            {
                List<ErSenderezepteErezept> list = await _datenRepository.GetERezeptIdListByStatusAsync(apoik, zeitraum, status);
                foreach (ErSenderezepteErezept r in list)
                {
                    List<ErSenderezepteErezeptStatusinfo> listsi = await _datenRepository.GetErSenderezepteErezeptStatusinfosAsync(r.IdSenderezepteErezept);
                    List<Statusinfo> siList = new();

                    foreach (var si in listsi)
                    {
                        siList.Add(new Statusinfo { Fcode = si.Fcode, Fkommentar = si.Fkommentar, Fstatus = si.Fstatus });
                    }
                    var rId = new RezeptId() { Id = r.ErezeptId, Typ = RezeptTyp.ERezeptEnum };
                    var rUid = new RezeptUId() { Ruid = r.ErSenderezepteErezeptDatens.First().RezeptUuid };
                    resList.Add(new RezeptPruefResult() { Id = rId, Uid = rUid, Statusinfo = siList });
                }
            }
            return resList;
        }
        public async Task<RezeptStatus> GetRezeptUIdStatusAsync(string ruid)
        {
            var res = await _datenRepository.GetERezeptUIdAsync(ruid);
            return await getERezeptStatus(res);
        }
        #endregion

        #region Put     
        public async Task<ICollection<Abholstatus>> PatchRezeptIdListAbholstatusAsync(string apoik, IEnumerable<RezeptId> body)
        {
            List<Abholstatus> list = new();
            List<string> rezeptlist = new();
            foreach (var a in body)
            {
                if (a.Typ == RezeptTyp.ERezeptEnum)
                {
                    rezeptlist.Add(a.Id);
                }
            }
            var res = await _datenRepository.PatchERezeptIdListAbholstatusAsync(apoik, rezeptlist);
            foreach (var r in res)
            {
                list.Add(new Abholstatus() { Id = new RezeptId() { Id = r.Key, Typ = RezeptTyp.ERezeptEnum }, Uid = new RezeptUId() { }, Abgeholt = r.Value });
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
                list.Add(new Abholstatus() { Id = new RezeptId() { Id = r.Key, Typ = RezeptTyp.ERezeptEnum }, Uid = new RezeptUId() { }, Abgeholt = r.Value });
            }
            return list;
        }
        public async Task PutRezeptIdListPruefungAsync(string apoik, IEnumerable<RezeptId> body)
        {
            List<RezeptPruefResult> list = new List<RezeptPruefResult>();
            List<string> rezeptlist = new();
            foreach (var a in body)
            {
                if (a.Typ == RezeptTyp.ERezeptEnum)
                {
                    rezeptlist.Add(a.Id);
                }
            }
            await _datenRepository.PutERezeptIdListPruefungAsync(apoik, rezeptlist);
            return;
        }
        public async Task PutRezeptUidListPruefungAsync(IEnumerable<RezeptUId> body)
        {
            List<string> rezeptlist = new();
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
            if (reztyp == RezeptTyp.ERezeptEnum)
            {
                var r = await _datenRepository.GetERezeptIdAsync(apoik, rezid);
                if (r == null)
                    return null;
                return await patchStatus(r.IdSenderezepteErezept, r.ErezeptId, status);
            }
            return null;
        }
        async Task<RezeptStatus> patchStatus(int id, string rezid, string status)
        {
            var s = await _datenRepository.PatchERezeptStatusAsync(id, status);
            if (s == null)
                return null;
            return new RezeptStatus() { Id = new RezeptId() { Id = rezid, Typ = RezeptTyp.ERezeptEnum }, Status = s.RezeptStatus };

        }
        public async Task<RezeptStatus> PatchRezeptUIdStatusAsync(string ruid, string status)
        {
            var r = await _datenRepository.GetERezeptUIdAsync(ruid);
            if (r == null)
                return null;
            var s = await _datenRepository.PatchERezeptStatusAsync(r.IdSenderezepteErezept, status);
            if (s == null)
                return null;
            return new RezeptStatus() { Uid = new RezeptUId() { Ruid = ruid }, Status = s.RezeptStatus };
        }
        public async Task<ICollection<RezeptStatus>> PatchRezeptIdListStatusAsync(string apoik, IEnumerable<RezeptStatus> body)
        {
            Dictionary<string, string> rezeptlist = new();
            foreach (var a in body)
            {
                if (a.Id.Typ == RezeptTyp.ERezeptEnum)
                    rezeptlist.Add(a.Id.Id, a.Status);
            }
            Dictionary<string, string> rs = await _datenRepository.PatchERezeptIdListStatusAsync(apoik, rezeptlist);
            List<RezeptStatus> rslist = new();
            foreach (var r in rs)
            {
                rslist.Add(new RezeptStatus() { Id = new RezeptId() { Id = r.Key, Typ = RezeptTyp.ERezeptEnum }, Status = r.Value });
            }
            return rslist;
        }
        public async Task<ICollection<RezeptStatus>> PatchRezeptUIdListStatusAsync(IEnumerable<RezeptStatus> body)
        {
            Dictionary<string, string> rezeptlist = new();
            foreach (var a in body)
            {
                if (a.Id.Typ == RezeptTyp.ERezeptEnum)
                    rezeptlist.Add(a.Id.Id, a.Status);
            }
            Dictionary<string, string> rs = await _datenRepository.PatchERezeptUIdListStatusAsync(rezeptlist);
            List<RezeptStatus> rslist = new();
            foreach (var r in rs)
            {
                rslist.Add(new RezeptStatus() { Uid = new RezeptUId() { Ruid = r.Key }, Status = r.Value });
            }
            return rslist;
        }
        #endregion

        #region Delete
        public async Task<Rezept> DeleteRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid)
        {
            if (reztyp == RezeptTyp.ERezeptEnum)
            {
                var res = await _datenRepository.DeleteERezeptIdAsync(apoik, rezid);
                return await getERez(res);
            }
            return null;
        }
        public async Task<Rezept> DeleteRezeptUIdAsync(string ruid)
        {
            var res = await _datenRepository.DeleteERezeptUIdAsync(ruid);
            return await getERez(res);
        }
        #endregion


        #region new

        #endregion


    }
}
