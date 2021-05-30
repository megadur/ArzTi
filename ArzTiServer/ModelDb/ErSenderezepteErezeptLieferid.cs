using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.ModelDb
{
    public partial class ErSenderezepteErezeptLieferid
    {
        public int IdSenderezepteErezept { get; set; }
        public int IdSenderezepteHeader { get; set; }

        public virtual ErSenderezepteErezept IdSenderezepteErezeptNavigation { get; set; }
        public virtual ErSenderezepteHeader IdSenderezepteHeaderNavigation { get; set; }
    }
}
