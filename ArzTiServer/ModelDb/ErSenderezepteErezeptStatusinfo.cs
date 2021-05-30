using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.ModelDb
{
    public partial class ErSenderezepteErezeptStatusinfo
    {
        public int IdSenderezepteErezeptStatusinfo { get; set; }
        public int? IdSenderezepteErezept { get; set; }
        public string Fcode { get; set; }
        public string Fstatus { get; set; }
        public string Fkommentar { get; set; }
        public string Ftcode { get; set; }
        public short? Posnr { get; set; }
        public string Fkurztext { get; set; }
        public string RegelNr { get; set; }
        public string RegelTrefferCode { get; set; }

        public virtual ErSenderezepteErezept IdSenderezepteErezeptNavigation { get; set; }
    }
}
