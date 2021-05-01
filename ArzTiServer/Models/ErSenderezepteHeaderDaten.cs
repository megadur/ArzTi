using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErSenderezepteHeaderDaten
    {
        public int IdSenderezepteHeaderDaten { get; set; }
        public int? IdSenderezepteHeader { get; set; }
        public string HeaderUuid { get; set; }
        public bool? TransferArz { get; set; }
        public string XmlRequest { get; set; }

        public virtual ErSenderezepteHeader IdSenderezepteHeaderNavigation { get; set; }
    }
}
