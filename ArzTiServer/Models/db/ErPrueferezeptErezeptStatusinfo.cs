using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErPrueferezeptErezeptStatusinfo
    {
        public int IdPrueferezeptErezeptStatusinfo { get; set; }
        public int? IdPrueferezeptErezept { get; set; }
        public short? Fcode { get; set; }
        public string Fstatus { get; set; }
        public string Fkommentar { get; set; }
        public short? Ftcode { get; set; }
        public short? Posnr { get; set; }
        public string Fkurztext { get; set; }

        public virtual ErPrueferezeptErezept IdPrueferezeptErezeptNavigation { get; set; }
    }
}
