using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErPrueferezeptErezeptLieferid
    {
        public int IdPrueferezeptErezept { get; set; }
        public int IdPrueferezeptHeader { get; set; }

        public virtual ErPrueferezeptErezept IdPrueferezeptErezeptNavigation { get; set; }
        public virtual ErPrueferezeptHeader IdPrueferezeptHeaderNavigation { get; set; }
    }
}
