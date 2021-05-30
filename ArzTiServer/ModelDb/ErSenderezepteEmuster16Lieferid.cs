using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.ModelDb
{
    public partial class ErSenderezepteEmuster16Lieferid
    {
        public int IdSenderezepteEmuster16 { get; set; }
        public int IdSenderezepteHeader { get; set; }

        public virtual ErSenderezepteEmuster16 IdSenderezepteEmuster16Navigation { get; set; }
        public virtual ErSenderezepteHeader IdSenderezepteHeaderNavigation { get; set; }
    }
}
