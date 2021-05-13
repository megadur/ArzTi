using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErPrueferezeptErezept
    {
        public ErPrueferezeptErezept()
        {
            ErPrueferezeptErezeptLieferids = new HashSet<ErPrueferezeptErezeptLieferid>();
            ErPrueferezeptErezeptStatusinfos = new HashSet<ErPrueferezeptErezeptStatusinfo>();
        }

        public int IdPrueferezeptErezept { get; set; }
        public string RzLieferId { get; set; }
        public string RzDatum { get; set; }
        public DateTime? RzLieferDatum { get; set; }
        public TimeSpan? RzLieferZeit { get; set; }
        public string AvsId { get; set; }
        public string PruefModus { get; set; }
        public string ErezeptId { get; set; }
        public string ErezeptData { get; set; }

        public virtual ICollection<ErPrueferezeptErezeptLieferid> ErPrueferezeptErezeptLieferids { get; set; }
        public virtual ICollection<ErPrueferezeptErezeptStatusinfo> ErPrueferezeptErezeptStatusinfos { get; set; }
    }
}
