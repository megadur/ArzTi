using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Domain.Model
{
    public partial class ErUsecase
    {
        public int IdUsecase { get; set; }
        public short MainUcNr { get; set; }
        public bool? MainUc { get; set; }
        public bool? SubUc { get; set; }
        public int? MainUcId { get; set; }
        public string Option { get; set; }
        public bool? Freigegeben { get; set; }
        public string Beschreibung { get; set; }
        public short? SubUcNr { get; set; }
        public string Bezeichnung { get; set; }
    }
}
