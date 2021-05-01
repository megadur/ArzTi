using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErSonderPzn
    {
        public long IdSonderPzn { get; set; }
        public long? SonderPzn { get; set; }
        public string BeschreibungKurz { get; set; }
        public string Beschreibung { get; set; }
        public short? Ust { get; set; }
        public string Kommentar { get; set; }
        public DateTime? GueltigAb { get; set; }
        public DateTime? GueltigBis { get; set; }
    }
}
