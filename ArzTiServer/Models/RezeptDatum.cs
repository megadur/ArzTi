using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class RezeptDatum
    {
        public long Id { get; set; }
        public int Typ { get; set; }
        public string Value { get; set; }
    }
}
