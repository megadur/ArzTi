using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErAbdaU
    {
        public int IdAbdaUs { get; set; }
        public long? Pzn { get; set; }
        public int? KeyAus { get; set; }
        public string Bezeichnung { get; set; }
        public string Darreichungsform { get; set; }
        public string Menge { get; set; }
        public string Mengeneinheit { get; set; }
        public DateTime? GueltigAb { get; set; }
        public DateTime? GueltigBis { get; set; }
        public int? ImportGruppeNr { get; set; }
        public short? AusnahmeErsetzung { get; set; }
        public string Warengruppe { get; set; }
    }
}
