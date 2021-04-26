using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErSenderezeptePrezeptStatus
    {
        public int IdSenderezeptePrezeptStatus { get; set; }
        public int? IdSenderezeptePrezept { get; set; }
        public long? TransaktionsNummer { get; set; }
        public string RezeptStatus { get; set; }
        public bool? RezeptCheck { get; set; }
        public DateTime? StatusAbfrageDatum { get; set; }
        public TimeSpan? StatusAbfrageZeit { get; set; }
        public string AbrechenStatus { get; set; }
        public string RzAbfrageId { get; set; }

        public virtual ErSenderezeptePrezept IdSenderezeptePrezeptNavigation { get; set; }
    }
}
