using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Domain.Model
{
    public partial class ErRabattWirkstoff
    {
        public long Pzn { get; set; }
        public int Komponentennr { get; set; }
        public int FaiDbRang { get; set; }
        public DateTime GueltigAb { get; set; }
        public DateTime GueltigBis { get; set; }
        public float FaiDbZahl { get; set; }
        public int FaiDbKeySto { get; set; }
        public string FamDbKeyIndHaupt { get; set; }
        public string FamDbKeyIndNeben { get; set; }
        public string PacApoKeyWar { get; set; }
        public int PgrApoEinstufung { get; set; }
        public string FamDbKeyDar { get; set; }
        public string FamDbKeyAtc { get; set; }
        public string FakDbAbsolutbezugEinheit { get; set; }
        public int PacApoKeyAus { get; set; }
        public int PacApoImportgruppennr { get; set; }
    }
}
