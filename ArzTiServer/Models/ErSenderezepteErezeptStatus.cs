﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErSenderezepteErezeptStatus
    {
        public int IdSenderezepteErezeptStatus { get; set; }
        public int? IdSenderezepteErezept { get; set; }
        public long? TransaktionsNummer { get; set; }
        public string RezeptStatus { get; set; }
        public bool? RezeptCheck { get; set; }
        public DateTime? StatusAbfrageDatum { get; set; }
        public TimeSpan? StatusAbfrageZeit { get; set; }
        public string AbrechenStatus { get; set; }
        public string RzAbfrageId { get; set; }

        public virtual ErSenderezepteErezept IdSenderezepteErezeptNavigation { get; set; }
    }
}
