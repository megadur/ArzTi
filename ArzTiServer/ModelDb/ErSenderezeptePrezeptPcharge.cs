using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.ModelDb
{
    public partial class ErSenderezeptePrezeptPcharge
    {
        public ErSenderezeptePrezeptPcharge()
        {
            ErSenderezeptePrezeptPchargePwirkstoffs = new HashSet<ErSenderezeptePrezeptPchargePwirkstoff>();
        }

        public int IdSenderezeptePrezeptPcharge { get; set; }
        public int? IdSenderezeptePrezept { get; set; }
        public short? HerstellerSchluessel { get; set; }
        public long? HerstellerNr { get; set; }
        public string HerstellungsDatum { get; set; }
        public short? ChargenNr { get; set; }
        public short? AnzahlApplikationen { get; set; }

        public virtual ErSenderezeptePrezept IdSenderezeptePrezeptNavigation { get; set; }
        public virtual ICollection<ErSenderezeptePrezeptPchargePwirkstoff> ErSenderezeptePrezeptPchargePwirkstoffs { get; set; }
    }
}
