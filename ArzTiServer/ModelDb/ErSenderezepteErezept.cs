using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.ModelDb
{
    public partial class ErSenderezepteErezept
    {
        public ErSenderezepteErezept()
        {
            ErSenderezepteErezeptDatens = new HashSet<ErSenderezepteErezeptDaten>();
            ErSenderezepteErezeptLieferids = new HashSet<ErSenderezepteErezeptLieferid>();
            ErSenderezepteErezeptStatuses = new HashSet<ErSenderezepteErezeptStatus>();
            ErSenderezepteErezeptStatusinfos = new HashSet<ErSenderezepteErezeptStatusinfo>();
        }

        public int IdSenderezepteErezept { get; set; }
        public string RzLieferId { get; set; }
        public string RzDatum { get; set; }
        public DateTime? RzLieferDatum { get; set; }
        public TimeSpan? RzLieferZeit { get; set; }
        public string AvsId { get; set; }
        public string AbrechnungsPeriode { get; set; }
        public string ErezeptId { get; set; }
        public string ErezeptData { get; set; }

        public virtual ICollection<ErSenderezepteErezeptDaten> ErSenderezepteErezeptDatens { get; set; }
        public virtual ICollection<ErSenderezepteErezeptLieferid> ErSenderezepteErezeptLieferids { get; set; }
        public virtual ICollection<ErSenderezepteErezeptStatus> ErSenderezepteErezeptStatuses { get; set; }
        public virtual ICollection<ErSenderezepteErezeptStatusinfo> ErSenderezepteErezeptStatusinfos { get; set; }
    }
}
