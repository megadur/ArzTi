using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.ModelDb
{
    public partial class ErSenderezeptePrezeptPchargePwirkstoff
    {
        public int IdSenderezeptePrezeptPwirkstoff { get; set; }
        public int? IdSenderezeptePrezeptPcharge { get; set; }
        public long? Pzn { get; set; }
        public short? PPosNr { get; set; }
        public int? Faktor { get; set; }
        public string FaktorKennzeichen { get; set; }
        public decimal? Taxe { get; set; }
        public string PreisKennzeichen { get; set; }
        public string WirkstoffName { get; set; }
        public string Notiz { get; set; }

        public virtual ErSenderezeptePrezeptPcharge IdSenderezeptePrezeptPchargeNavigation { get; set; }
    }
}
