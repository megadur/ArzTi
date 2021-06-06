using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Domain.Model
{
    public partial class ErSenderezeptePrezeptDaten
    {
        public int IdSenderezeptePrezeptDaten { get; set; }
        public int? IdSenderezeptePrezept { get; set; }
        public string RezeptUuid { get; set; }
        public bool? TransferArz { get; set; }
        public string XmlRequest { get; set; }

        public virtual ErSenderezeptePrezept IdSenderezeptePrezeptNavigation { get; set; }
    }
}
