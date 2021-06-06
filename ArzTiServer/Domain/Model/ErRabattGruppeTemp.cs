using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Domain.Model
{
    public partial class ErRabattGruppeTemp
    {
        public int IdRabattGruppe { get; set; }
        public int? KeyGruppe { get; set; }
        public short? Mkv { get; set; }
        public short? ZuzahlungFaktor { get; set; }
        public DateTime? GueltigAb { get; set; }
        public DateTime? GueltigBis { get; set; }
    }
}
