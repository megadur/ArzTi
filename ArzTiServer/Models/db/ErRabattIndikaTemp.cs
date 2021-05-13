using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErRabattIndikaTemp
    {
        public int IdRabattIndika { get; set; }
        public long? Pzn { get; set; }
        public int? Indikation { get; set; }
        public DateTime? GueltigAb { get; set; }
        public DateTime? GueltigBis { get; set; }
    }
}
