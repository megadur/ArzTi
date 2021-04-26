using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErSenderezepteEmuster16Status
    {
        public int IdSenderezepteEmuster16Status { get; set; }
        public int? IdSenderezepteEmuster16 { get; set; }
        public long? Muster16Id { get; set; }
        public string RezeptStatus { get; set; }
        public bool? RezeptCheck { get; set; }
        public DateTime? StatusAbfrageDatum { get; set; }
        public TimeSpan? StatusAbfrageZeit { get; set; }
        public string AbrechenStatus { get; set; }
        public string RzAbfrageId { get; set; }

        public virtual ErSenderezepteEmuster16 IdSenderezepteEmuster16Navigation { get; set; }
    }
}
