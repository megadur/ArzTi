using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErRabattPznTemp
    {
        public long IdRabattPzn { get; set; }
        public int? KeyGruppe { get; set; }
        public long? ArzneiPzn { get; set; }
        public DateTime? GueltigAb { get; set; }
        public DateTime? GueltigBis { get; set; }
    }
}
