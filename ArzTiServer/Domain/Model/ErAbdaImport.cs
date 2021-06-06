using System;
using System.Collections.Generic;

#nullable disable

namespace ArzTiServer.Domain.Model
{
    public partial class ErAbdaImport
    {
        public int IdAbdaImport { get; set; }
        public string Datei { get; set; }
        public string AbsenderKennung { get; set; }
        public string MandantKennung { get; set; }
        public string MandantType { get; set; }
        public string DateiType { get; set; }
        public string Schnittstelle { get; set; }
        public string Uebertragungszaehler { get; set; }
        public string Zeitstempel { get; set; }
        public string DateiErweiterung { get; set; }
        public bool? Importiert { get; set; }
        public DateTime? ImportiertDatum { get; set; }
        public TimeSpan? ImportiertZeit { get; set; }
        public short? ImportiertTeildatei { get; set; }
        public bool? Konvertiert { get; set; }
        public DateTime? KonvertiertDatum { get; set; }
        public TimeSpan? KonvertiertZeit { get; set; }
        public int? KonvertiertDsGesamt { get; set; }
        public short? AnzahlTeildateien { get; set; }
        public string Impkenner { get; set; }
        public int? ImportiertDsGesamt { get; set; }
        public int? ImportiertDsImportiert { get; set; }
        public int? ImportiertDsFehler { get; set; }
        public int? KonvertiertDsKonvertiert { get; set; }
        public int? KonvertiertDsFehler { get; set; }
        public int? DateiGroesse { get; set; }
        public short? Zusatzdatei { get; set; }
        public int? Nummer { get; set; }
    }
}
