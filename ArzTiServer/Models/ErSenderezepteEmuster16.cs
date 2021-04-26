using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ErSenderezepteEmuster16
    {
        public ErSenderezepteEmuster16()
        {
            ErSenderezepteEmuster16Artikels = new HashSet<ErSenderezepteEmuster16Artikel>();
            ErSenderezepteEmuster16Datens = new HashSet<ErSenderezepteEmuster16Daten>();
            ErSenderezepteEmuster16Lieferids = new HashSet<ErSenderezepteEmuster16Lieferid>();
            ErSenderezepteEmuster16Statuses = new HashSet<ErSenderezepteEmuster16Status>();
            ErSenderezepteEmuster16Statusinfos = new HashSet<ErSenderezepteEmuster16Statusinfo>();
        }

        public int IdSenderezepteEmuster16 { get; set; }
        public string RzLieferId { get; set; }
        public string RzDatum { get; set; }
        public DateTime? RzLieferDatum { get; set; }
        public TimeSpan? RzLieferZeit { get; set; }
        public string AvsId { get; set; }
        public string AbrechnungsPeriode { get; set; }
        public string RezeptTyp { get; set; }
        public long? Muster16Id { get; set; }
        public string AbdaKassentyp { get; set; }
        public long? ApoIkNr { get; set; }
        public string KkTyp { get; set; }
        public decimal? GesamtesBrutto { get; set; }
        public decimal? Zuzahlung { get; set; }
        public DateTime? Abgabedatum { get; set; }
        public long? BetriebsstaettenNr { get; set; }
        public long? ArztNr { get; set; }
        public DateTime? Verordnungsdatum { get; set; }
        public long? KkIkNr { get; set; }
        public string VersichertenNummer { get; set; }
        public string VersichertenStatus { get; set; }
        public string VersichertenTitel { get; set; }
        public string KkName { get; set; }
        public string VersichertenName { get; set; }
        public string VersichertenVorname { get; set; }
        public string VersichertenStrasse { get; set; }
        public string VersichertenPlz { get; set; }
        public string VersichertenOrt { get; set; }
        public DateTime? VersichertenGeburtsdatum { get; set; }
        public short? KzBvg { get; set; }
        public short? KzHilfsmittel { get; set; }
        public short? KzImpfstoff { get; set; }
        public short? KzSprechstundenbedarf { get; set; }
        public short? BegrPflicht { get; set; }
        public short? KzGebuehrenFrei { get; set; }
        public short? KzNoctu { get; set; }
        public short? KzUnfall { get; set; }
        public DateTime? UnfallDatum { get; set; }
        public decimal? Eigenanteil { get; set; }
        public string Bediener { get; set; }
        public string Arbeitsplatz { get; set; }
        public short? KzSonstige { get; set; }
        public string VersichertenkarteGueltigBis { get; set; }
        public short? KzArbeitsunfall { get; set; }
        public short? TSicherheitsbestimmung { get; set; }
        public short? TFachinformation { get; set; }
        public short? TInLabel { get; set; }
        public short? TOffLabel { get; set; }

        public virtual ICollection<ErSenderezepteEmuster16Artikel> ErSenderezepteEmuster16Artikels { get; set; }
        public virtual ICollection<ErSenderezepteEmuster16Daten> ErSenderezepteEmuster16Datens { get; set; }
        public virtual ICollection<ErSenderezepteEmuster16Lieferid> ErSenderezepteEmuster16Lieferids { get; set; }
        public virtual ICollection<ErSenderezepteEmuster16Status> ErSenderezepteEmuster16Statuses { get; set; }
        public virtual ICollection<ErSenderezepteEmuster16Statusinfo> ErSenderezepteEmuster16Statusinfos { get; set; }
    }
}
