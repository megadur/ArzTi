using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErSenderezepteErezeptDaten
    {
        public int IdSenderezepteErezeptDaten { get; set; }
        public int? IdSenderezepteErezept { get; set; }
        public string RezeptGuid { get; set; }
        public bool? TransferArz { get; set; }
        public string XmlRequest { get; set; }

        public virtual ErSenderezepteErezept IdSenderezepteErezeptNavigation { get; set; }
    }
}
