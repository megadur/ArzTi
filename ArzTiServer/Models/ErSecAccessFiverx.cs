using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErSecAccessFiverx
    {
        public int IdSecAccessFiverx { get; set; }
        public int IdApotheke { get; set; }
        public string LoginId { get; set; }
        public string LoginPasswort { get; set; }
        public string LoginPasswortCrypt { get; set; }
        public bool? Freigegeben { get; set; }
        public bool? ErezUc4 { get; set; }
        public bool? ErezUc51 { get; set; }
        public bool? ErezUc52 { get; set; }
        public bool? Em16Uc61Asyn { get; set; }
        public bool? Em16Uc61Syn { get; set; }
        public bool? Em16Uc61U1 { get; set; }
        public bool? ErezUc62Asyn { get; set; }
        public bool? ErezUc62Syn { get; set; }
        public bool? ErezUc7 { get; set; }
        public int? AenIdSecUser { get; set; }
        public DateTime? AenDatum { get; set; }
        public TimeSpan? AenZeit { get; set; }

        public virtual ErApotheke IdApothekeNavigation { get; set; }
    }
}
