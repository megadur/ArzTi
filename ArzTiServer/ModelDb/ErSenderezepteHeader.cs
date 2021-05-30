using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.ModelDb
{
    public partial class ErSenderezepteHeader
    {
        public ErSenderezepteHeader()
        {
            ErSenderezepteEmuster16Lieferids = new HashSet<ErSenderezepteEmuster16Lieferid>();
            ErSenderezepteErezeptLieferids = new HashSet<ErSenderezepteErezeptLieferid>();
            ErSenderezeptePrezeptLieferids = new HashSet<ErSenderezeptePrezeptLieferid>();
        }

        public int IdSenderezepteHeader { get; set; }
        public int ApoIntNr { get; set; }
        public long? ApoIkNr { get; set; }
        public string SoftwareHersteller { get; set; }
        public string SoftwareName { get; set; }
        public string SoftwareVersion { get; set; }
        public string ApoPassword { get; set; }
        public bool? Testdaten { get; set; }
        public string RzLieferId { get; set; }
        public DateTime? RzLieferDatum { get; set; }
        public TimeSpan? RzLieferZeit { get; set; }
        public long? AvsSendeId { get; set; }
        public string RezeptStatus { get; set; }
        public bool? RezeptCheck { get; set; }
        public string RezTyp { get; set; }
        public bool? ReztypErez { get; set; }
        public bool? ReztypEm16 { get; set; }
        public bool? ReztypPrez { get; set; }
        public DateTime? AbfrageDatum { get; set; }
        public TimeSpan? AbfrageZeit { get; set; }
        public bool? CheckErez { get; set; }
        public bool? CheckEm16 { get; set; }
        public bool? CheckPrez { get; set; }
        public short? ImportTyp { get; set; }
        public DateTime? CheckDatum { get; set; }
        public TimeSpan? CheckZeit { get; set; }

        public virtual ICollection<ErSenderezepteEmuster16Lieferid> ErSenderezepteEmuster16Lieferids { get; set; }
        public virtual ICollection<ErSenderezepteErezeptLieferid> ErSenderezepteErezeptLieferids { get; set; }
        public virtual ICollection<ErSenderezeptePrezeptLieferid> ErSenderezeptePrezeptLieferids { get; set; }
    }
}
