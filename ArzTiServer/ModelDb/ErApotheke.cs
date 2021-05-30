using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.ModelDb
{
    public partial class ErApotheke
    {
        public ErApotheke()
        {
            ErSecAccessFiverxes = new HashSet<ErSecAccessFiverx>();
        }

        public int IdApotheke { get; set; }
        public string ApothekeName { get; set; }
        public string ApothekeNameZusatz { get; set; }
        public long ApoIkNr { get; set; }
        public string InhaberVorname { get; set; }
        public string InhaberNachname { get; set; }
        public int? ApoIntNr { get; set; }
        public int? Plz { get; set; }
        public string Ort { get; set; }
        public string Strasse { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Mobil { get; set; }
        public string Fax { get; set; }
        public string Bemerkung { get; set; }
        public string Bundesland { get; set; }
        public string MandantType { get; set; }
        public short? IdLeType { get; set; }
        public long? IdHauptapotheke { get; set; }
        public short? IdHtAnrede { get; set; }
        public short? Filialapotheke { get; set; }
        public bool? Gesperrt { get; set; }
        public int? SecLogin { get; set; }
        public string SecLoginWerte { get; set; }
        public bool? SecLoginNurApoUser { get; set; }
        public int? AenIdSecUser { get; set; }
        public DateTime? AenDatum { get; set; }
        public TimeSpan? AenZeit { get; set; }

        public virtual ICollection<ErSecAccessFiverx> ErSecAccessFiverxes { get; set; }
    }
}
