using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErSenderezeptePrezeptLieferid
    {
        public int IdSenderezeptePrezept { get; set; }
        public int IdSenderezepteHeader { get; set; }

        public virtual ErSenderezepteHeader IdSenderezepteHeaderNavigation { get; set; }
        public virtual ErSenderezeptePrezept IdSenderezeptePrezeptNavigation { get; set; }
    }
}
