using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErPrueferezeptHeader
    {
        public ErPrueferezeptHeader()
        {
            ErPrueferezeptErezeptLieferids = new HashSet<ErPrueferezeptErezeptLieferid>();
        }

        public int IdPrueferezeptHeader { get; set; }
        public int ApoIntNr { get; set; }
        public long? ApoIkNr { get; set; }
        public string SoftwareHersteller { get; set; }
        public string SoftwareName { get; set; }
        public string SoftwareVersion { get; set; }
        public string ApoPassword { get; set; }
        public bool? Testdaten { get; set; }
        public string RzLieferId { get; set; }
        public DateTime? RzLieferDatum { get; set; }
        public TimeSpan? RzLieferZeit { get; set; }
        public long? AvsSendeId { get; set; }
        public string RezeptStatus { get; set; }
        public bool? RezeptCheck { get; set; }
        public string RezTyp { get; set; }
        public bool? ReztypErez { get; set; }
        public bool? ReztypEm16 { get; set; }
        public bool? ReztypPrez { get; set; }
        public DateTime? StatusAbfrageDatum { get; set; }
        public TimeSpan? StatusAbfrageZeit { get; set; }
        public bool? CheckErez { get; set; }
        public bool? CheckEm16 { get; set; }
        public bool? CheckPrez { get; set; }
        public short? ImportTyp { get; set; }

        public virtual ICollection<ErPrueferezeptErezeptLieferid> ErPrueferezeptErezeptLieferids { get; set; }
    }
}
