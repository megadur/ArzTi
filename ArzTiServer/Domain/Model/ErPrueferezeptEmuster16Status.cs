using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Domain.Model
{
    public partial class ErPrueferezeptEmuster16Status
    {
        public int IdPrueferezeptEmuster16Status { get; set; }
        public int? IdPrueferezeptEmuster16 { get; set; }
        public long? Muster16Id { get; set; }
        public string RezeptStatus { get; set; }
        public bool? RezeptCheck { get; set; }
        public DateTime? StatusAbfrageDatum { get; set; }
        public TimeSpan? StatusAbfrageZeit { get; set; }

        public virtual ErPrueferezeptEmuster16 IdPrueferezeptEmuster16Navigation { get; set; }
    }
}
