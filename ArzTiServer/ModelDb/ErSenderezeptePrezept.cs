using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.ModelDb
{
    public partial class ErSenderezeptePrezept
    {
        public ErSenderezeptePrezept()
        {
            ErSenderezeptePrezeptDatens = new HashSet<ErSenderezeptePrezeptDaten>();
            ErSenderezeptePrezeptLieferids = new HashSet<ErSenderezeptePrezeptLieferid>();
            ErSenderezeptePrezeptPcharges = new HashSet<ErSenderezeptePrezeptPcharge>();
            ErSenderezeptePrezeptStatuses = new HashSet<ErSenderezeptePrezeptStatus>();
            ErSenderezeptePrezeptStatusinfos = new HashSet<ErSenderezeptePrezeptStatusinfo>();
        }

        public int IdSenderezeptePrezept { get; set; }
        public string RzLieferId { get; set; }
        public string RzDatum { get; set; }
        public DateTime? RzLieferDatum { get; set; }
        public TimeSpan? RzLieferZeit { get; set; }
        public string AvsId { get; set; }
        public string AbrechnungsPeriode { get; set; }
        public string RezeptTyp { get; set; }
        public long? TransaktionsNummer { get; set; }
        public string AbdaKassentyp { get; set; }
        public long? ApoIkNr { get; set; }
        public string KkTyp { get; set; }
        public decimal? GesamtesBrutto { get; set; }
        public decimal? Zuzahlung { get; set; }
        public long? Ppos1Pzn { get; set; }
        public int? Ppos1Faktor { get; set; }
        public decimal? Ppos1Taxe { get; set; }
        public DateTime? Abgabedatum { get; set; }
        public string ErstellungsZeitpunkt { get; set; }
        public string HashCode { get; set; }
        public long? BetriebsstaettenNr { get; set; }
        public long? ArztNr { get; set; }
        public DateTime? Verordnungsdatum { get; set; }
        public long? KkIkNr { get; set; }
        public string VersichertenNummer { get; set; }
        public string KkName { get; set; }
        public string VersichertenStatus { get; set; }
        public DateTime? VersichertenGeburtsdatum { get; set; }
        public short? KzBvg { get; set; }
        public short? KzSprechstundenbedarf { get; set; }
        public short? KzGebuehrenFrei { get; set; }
        public short? KzNoctu { get; set; }
        public string Bediener { get; set; }
        public string Arbeitsplatz { get; set; }
        public short? KzSonstige { get; set; }
        public string VersichertenkarteGueltigBis { get; set; }

        public virtual ICollection<ErSenderezeptePrezeptDaten> ErSenderezeptePrezeptDatens { get; set; }
        public virtual ICollection<ErSenderezeptePrezeptLieferid> ErSenderezeptePrezeptLieferids { get; set; }
        public virtual ICollection<ErSenderezeptePrezeptPcharge> ErSenderezeptePrezeptPcharges { get; set; }
        public virtual ICollection<ErSenderezeptePrezeptStatus> ErSenderezeptePrezeptStatuses { get; set; }
        public virtual ICollection<ErSenderezeptePrezeptStatusinfo> ErSenderezeptePrezeptStatusinfos { get; set; }
    }
}
