using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Domain.Model
{
    public partial class ErAbdum
    {
        public int IdAbda { get; set; }
        public long? Pzn { get; set; }
        public long? PznOriginal { get; set; }
        public int? ApoVkOriginal { get; set; }
        public int? ApoVkPreis { get; set; }
        public int? ApoVkPEmpf { get; set; }
        public int? ApoEkPreis { get; set; }
        public int? HsVkPreis { get; set; }
        public int? HsRabattBetrag { get; set; }
        public int? RabWAnbieter { get; set; }
        public int? RabWGenerika { get; set; }
        public int? RabWPreisMor { get; set; }
        public int? GhRabattBetr { get; set; }
        public int? Anbieter { get; set; }
        public string Bezeichnung { get; set; }
        public long? HmPositionsNr { get; set; }
        public bool? Fertigarzneimittel { get; set; }
        public bool? Hilfsmittel { get; set; }
        public bool? KannHilfsmittel { get; set; }
        public bool? Apothekenpflicht { get; set; }
        public bool? Betaeubungsmittel { get; set; }
        public bool? ApoRabatt { get; set; }
        public bool? RabApo { get; set; }
        public bool? HsRabatt { get; set; }
        public bool? GhRabatt { get; set; }
        public bool? Impfstoff { get; set; }
        public bool? Import { get; set; }
        public bool? ImportMoeglich { get; set; }
        public bool? Klinikpackung { get; set; }
        public bool? ErstFaehigFam { get; set; }
        public bool? TierAm { get; set; }
        public bool? Preiswert { get; set; }
        public bool? EigenePzn { get; set; }
        public bool? PlusVArt { get; set; }
        public bool? GrNr01 { get; set; }
        public short? LifeStyle { get; set; }
        public short? Verkehrsstatus { get; set; }
        public short? MwstSatz { get; set; }
        public short? Abgabeschluessel { get; set; }
        public short? Negativliste { get; set; }
        public short? Normpackung { get; set; }
        public long? PznOld { get; set; }
        public short? Verschreibungspflicht { get; set; }
        public short? Zuzahlungskennzeichen { get; set; }
        public short? Packungsgroesse { get; set; }
        public string Darreichungsform { get; set; }
        public int? Festbetrag { get; set; }
        public string Menge { get; set; }
        public string Mengeneinheit { get; set; }
        public string IndikationsNr { get; set; }
        public string Warengruppenschluessel { get; set; }
        public DateTime? Invalid { get; set; }
        public short? ZuzFreiTstr { get; set; }
        public short? ZuzFreiFeb { get; set; }
        public short? Ampvamg { get; set; }
        public short? Ampvsgb { get; set; }
        public short? CalcRabatt { get; set; }
        public DateTime? GueltigAb { get; set; }
        public DateTime? GueltigBis { get; set; }
        public short? CheckPzn { get; set; }
        public int? SteuerPzn { get; set; }
        public bool? RabVertrag { get; set; }
        public bool? HimiZuVerb { get; set; }
        public int? VeMenge { get; set; }
        public string Importkenner { get; set; }
        public int? RabWImpfstof { get; set; }
        public bool? Medizinprodukt { get; set; }
        public bool? AusErsetzung { get; set; }
        public bool? Biotech { get; set; }
    }
}
