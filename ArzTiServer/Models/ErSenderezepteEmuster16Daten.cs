using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErSenderezepteEmuster16Daten
    {
        public int IdSenderezepteEmuster16Daten { get; set; }
        public int? IdSenderezepteEmuster16 { get; set; }
        public string RezeptGuid { get; set; }
        public bool? TransferArz { get; set; }
        public string XmlRequest { get; set; }

        public virtual ErSenderezepteEmuster16 IdSenderezepteEmuster16Navigation { get; set; }
    }
}
