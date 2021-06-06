using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Domain.Model
{
    public partial class ErSenderezeptePrezeptStatusinfo
    {
        public int IdSenderezeptePrezeptStatusinfo { get; set; }
        public int? IdSenderezeptePrezept { get; set; }
        public string Fcode { get; set; }
        public string Fstatus { get; set; }
        public string Fkommentar { get; set; }
        public string Ftcode { get; set; }
        public short? Posnr { get; set; }
        public string Fkurztext { get; set; }
        public string RegelNr { get; set; }
        public string RegelTrefferCode { get; set; }

        public virtual ErSenderezeptePrezept IdSenderezeptePrezeptNavigation { get; set; }
    }
}
