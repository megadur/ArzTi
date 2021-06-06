﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Domain.Model
{
    public partial class ErRabattKasse
    {
        public int IdRabattKasse { get; set; }
        public int? KeyGruppe { get; set; }
        public int? KasseIk { get; set; }
        public DateTime? GueltigAb { get; set; }
        public DateTime? GueltigBis { get; set; }
    }
}
