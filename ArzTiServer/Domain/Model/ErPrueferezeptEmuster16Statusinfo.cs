using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Domain.Model
{
    public partial class ErPrueferezeptEmuster16Statusinfo
    {
        public int IdPrueferezeptEmuster16Statusinfo { get; set; }
        public int? IdPrueferezeptEmuster16 { get; set; }
        public string Fcode { get; set; }
        public string Fstatus { get; set; }
        public string Fkommentar { get; set; }
        public string Ftcode { get; set; }
        public short? Posnr { get; set; }
        public string Fkurztext { get; set; }

        public virtual ErPrueferezeptEmuster16 IdPrueferezeptEmuster16Navigation { get; set; }
    }
}
