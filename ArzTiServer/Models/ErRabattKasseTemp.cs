using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErRabattKasseTemp
    {
        public int IdRabattKasse { get; set; }
        public int? KeyGruppe { get; set; }
        public int? KasseIk { get; set; }
        public DateTime? GueltigAb { get; set; }
        public DateTime? GueltigBis { get; set; }
    }
}
