using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Domain.Model
{
    public partial class ErFiverxVersion
    {
        public int IdFiverxVersion { get; set; }
        public string FiverxVersion { get; set; }
        public DateTime Ablaufdatum { get; set; }
        public string Schemadatei { get; set; }
    }
}
