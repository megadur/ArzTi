using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErPrueferezeptEmuster16Artikel
    {
        public int IdPrueferezeptEmuster16Artikel { get; set; }
        public int? IdPrueferezeptEmuster16 { get; set; }
        public long? ArzneiPzn { get; set; }
        public long? HilfsmittelNr { get; set; }
        public short? AtrikelNr { get; set; }
        public int? ArtikelFaktor { get; set; }
        public decimal? ArtikelTaxe { get; set; }
        public short? ArtikelAutidem { get; set; }
        public string ArtikelMediName { get; set; }

        public virtual ErPrueferezeptEmuster16 IdPrueferezeptEmuster16Navigation { get; set; }
    }
}
