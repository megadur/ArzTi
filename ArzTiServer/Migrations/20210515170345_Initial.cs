using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArzTiServer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "daten");

            migrationBuilder.CreateSequence(
                name: "er_fiverx_schema_id_fiverx_schema_seq",
                schema: "daten");

            migrationBuilder.CreateSequence(
                name: "er_senderezepte_prezept_pwirk_id_senderezepte_prezept_pwirk_seq",
                schema: "daten");

            migrationBuilder.CreateTable(
                name: "er_abda",
                schema: "daten",
                columns: table => new
                {
                    id_abda = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_abda_temp_id_abda_seq1'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    pzn = table.Column<long>(type: "INTEGER", nullable: true),
                    pzn_original = table.Column<long>(type: "INTEGER", nullable: true),
                    apo_vk_original = table.Column<int>(type: "INTEGER", nullable: true),
                    apo_vk_preis = table.Column<int>(type: "INTEGER", nullable: true),
                    apo_vk_p_empf = table.Column<int>(type: "INTEGER", nullable: true),
                    apo_ek_preis = table.Column<int>(type: "INTEGER", nullable: true),
                    hs_vk_preis = table.Column<int>(type: "INTEGER", nullable: true),
                    hs_rabatt_betrag = table.Column<int>(type: "INTEGER", nullable: true),
                    rab_w_anbieter = table.Column<int>(type: "INTEGER", nullable: true),
                    rab_w_generika = table.Column<int>(type: "INTEGER", nullable: true),
                    rab_w_preis_mor = table.Column<int>(type: "INTEGER", nullable: true),
                    gh_rabatt_betr = table.Column<int>(type: "INTEGER", nullable: true),
                    anbieter = table.Column<int>(type: "INTEGER", nullable: true),
                    bezeichnung = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    hm_positions_nr = table.Column<long>(type: "INTEGER", nullable: true),
                    fertigarzneimittel = table.Column<bool>(type: "INTEGER", nullable: true),
                    hilfsmittel = table.Column<bool>(type: "INTEGER", nullable: true),
                    kann_hilfsmittel = table.Column<bool>(type: "INTEGER", nullable: true),
                    apothekenpflicht = table.Column<bool>(type: "INTEGER", nullable: true),
                    betaeubungsmittel = table.Column<bool>(type: "INTEGER", nullable: true),
                    apo_rabatt = table.Column<bool>(type: "INTEGER", nullable: true),
                    rab_apo = table.Column<bool>(type: "INTEGER", nullable: true),
                    hs_rabatt = table.Column<bool>(type: "INTEGER", nullable: true),
                    gh_rabatt = table.Column<bool>(type: "INTEGER", nullable: true),
                    impfstoff = table.Column<bool>(type: "INTEGER", nullable: true),
                    import = table.Column<bool>(type: "INTEGER", nullable: true),
                    import_moeglich = table.Column<bool>(type: "INTEGER", nullable: true),
                    klinikpackung = table.Column<bool>(type: "INTEGER", nullable: true),
                    erst_faehig_fam = table.Column<bool>(type: "INTEGER", nullable: true),
                    tier_am = table.Column<bool>(type: "INTEGER", nullable: true),
                    preiswert = table.Column<bool>(type: "INTEGER", nullable: true),
                    eigene_pzn = table.Column<bool>(type: "INTEGER", nullable: true),
                    plus_v_art = table.Column<bool>(type: "INTEGER", nullable: true),
                    gr_nr_01 = table.Column<bool>(type: "INTEGER", nullable: true),
                    life_style = table.Column<short>(type: "INTEGER", nullable: true),
                    verkehrsstatus = table.Column<short>(type: "INTEGER", nullable: true),
                    mwst_satz = table.Column<short>(type: "INTEGER", nullable: true),
                    abgabeschluessel = table.Column<short>(type: "INTEGER", nullable: true),
                    negativliste = table.Column<short>(type: "INTEGER", nullable: true),
                    normpackung = table.Column<short>(type: "INTEGER", nullable: true),
                    pzn_old = table.Column<long>(type: "INTEGER", nullable: true),
                    verschreibungspflicht = table.Column<short>(type: "INTEGER", nullable: true),
                    zuzahlungskennzeichen = table.Column<short>(type: "INTEGER", nullable: true),
                    packungsgroesse = table.Column<short>(type: "INTEGER", nullable: true),
                    darreichungsform = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    festbetrag = table.Column<int>(type: "INTEGER", nullable: true),
                    menge = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    mengeneinheit = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    indikations_nr = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    warengruppenschluessel = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    invalid = table.Column<DateTime>(type: "date", nullable: true),
                    zuz_frei_tstr = table.Column<short>(type: "INTEGER", nullable: true),
                    zuz_frei_feb = table.Column<short>(type: "INTEGER", nullable: true),
                    ampvamg = table.Column<short>(type: "INTEGER", nullable: true),
                    ampvsgb = table.Column<short>(type: "INTEGER", nullable: true),
                    calc_rabatt = table.Column<short>(type: "INTEGER", nullable: true),
                    gueltig_ab = table.Column<DateTime>(type: "date", nullable: true),
                    gueltig_bis = table.Column<DateTime>(type: "date", nullable: true),
                    check_pzn = table.Column<short>(type: "INTEGER", nullable: true),
                    steuer_pzn = table.Column<int>(type: "INTEGER", nullable: true),
                    rab_vertrag = table.Column<bool>(type: "INTEGER", nullable: true),
                    himi_zu_verb = table.Column<bool>(type: "INTEGER", nullable: true),
                    ve_menge = table.Column<int>(type: "INTEGER", nullable: true),
                    importkenner = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    rab_w_impfstof = table.Column<int>(type: "INTEGER", nullable: true),
                    medizinprodukt = table.Column<bool>(type: "INTEGER", nullable: true),
                    aus_ersetzung = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    biotech = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_abda_temp_pkey", x => x.id_abda);
                });

            migrationBuilder.CreateTable(
                name: "er_abda_import",
                schema: "daten",
                columns: table => new
                {
                    id_abda_import = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    datei = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    absender_kennung = table.Column<string>(type: "TEXT", maxLength: 3, nullable: true),
                    mandant_kennung = table.Column<string>(type: "TEXT", maxLength: 4, nullable: true),
                    mandant_type = table.Column<string>(type: "TEXT", maxLength: 4, nullable: true),
                    datei_type = table.Column<string>(type: "TEXT", maxLength: 1, nullable: true, comment: "L-löschen - N-neu"),
                    schnittstelle = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    uebertragungszaehler = table.Column<string>(type: "TEXT", maxLength: 3, nullable: true),
                    zeitstempel = table.Column<string>(type: "TEXT", maxLength: 8, nullable: true),
                    datei_erweiterung = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    importiert = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    importiert_datum = table.Column<DateTime>(type: "date", nullable: true),
                    importiert_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    importiert_teildatei = table.Column<short>(type: "INTEGER", nullable: true),
                    konvertiert = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    konvertiert_datum = table.Column<DateTime>(type: "date", nullable: true),
                    konvertiert_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    konvertiert_ds_gesamt = table.Column<int>(type: "INTEGER", nullable: true),
                    anzahl_teildateien = table.Column<short>(type: "INTEGER", nullable: true),
                    impkenner = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true, comment: "Identifiziert DS die durch diese Datei eingefügt wurden"),
                    importiert_ds_gesamt = table.Column<int>(type: "INTEGER", nullable: true),
                    importiert_ds_importiert = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "0"),
                    importiert_ds_fehler = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "0"),
                    konvertiert_ds_konvertiert = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "0"),
                    konvertiert_ds_fehler = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "0"),
                    datei_groesse = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "0"),
                    zusatzdatei = table.Column<short>(type: "INTEGER", nullable: true),
                    nummer = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_abda_import_pkey", x => x.id_abda_import);
                });

            migrationBuilder.CreateTable(
                name: "er_abda_temp",
                schema: "daten",
                columns: table => new
                {
                    id_abda = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    pzn = table.Column<long>(type: "INTEGER", nullable: true),
                    pzn_original = table.Column<long>(type: "INTEGER", nullable: true),
                    apo_vk_original = table.Column<int>(type: "INTEGER", nullable: true),
                    apo_vk_preis = table.Column<int>(type: "INTEGER", nullable: true),
                    apo_vk_p_empf = table.Column<int>(type: "INTEGER", nullable: true),
                    apo_ek_preis = table.Column<int>(type: "INTEGER", nullable: true),
                    hs_vk_preis = table.Column<int>(type: "INTEGER", nullable: true),
                    hs_rabatt_betrag = table.Column<int>(type: "INTEGER", nullable: true),
                    rab_w_anbieter = table.Column<int>(type: "INTEGER", nullable: true),
                    rab_w_generika = table.Column<int>(type: "INTEGER", nullable: true),
                    rab_w_preis_mor = table.Column<int>(type: "INTEGER", nullable: true),
                    gh_rabatt_betr = table.Column<int>(type: "INTEGER", nullable: true),
                    anbieter = table.Column<int>(type: "INTEGER", nullable: true),
                    bezeichnung = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    hm_positions_nr = table.Column<long>(type: "INTEGER", nullable: true),
                    fertigarzneimittel = table.Column<bool>(type: "INTEGER", nullable: true),
                    hilfsmittel = table.Column<bool>(type: "INTEGER", nullable: true),
                    kann_hilfsmittel = table.Column<bool>(type: "INTEGER", nullable: true),
                    apothekenpflicht = table.Column<bool>(type: "INTEGER", nullable: true),
                    betaeubungsmittel = table.Column<bool>(type: "INTEGER", nullable: true),
                    apo_rabatt = table.Column<bool>(type: "INTEGER", nullable: true),
                    rab_apo = table.Column<bool>(type: "INTEGER", nullable: true),
                    hs_rabatt = table.Column<bool>(type: "INTEGER", nullable: true),
                    gh_rabatt = table.Column<bool>(type: "INTEGER", nullable: true),
                    impfstoff = table.Column<bool>(type: "INTEGER", nullable: true),
                    import = table.Column<bool>(type: "INTEGER", nullable: true),
                    import_moeglich = table.Column<bool>(type: "INTEGER", nullable: true),
                    klinikpackung = table.Column<bool>(type: "INTEGER", nullable: true),
                    erst_faehig_fam = table.Column<bool>(type: "INTEGER", nullable: true),
                    tier_am = table.Column<bool>(type: "INTEGER", nullable: true),
                    preiswert = table.Column<bool>(type: "INTEGER", nullable: true),
                    eigene_pzn = table.Column<bool>(type: "INTEGER", nullable: true),
                    plus_v_art = table.Column<bool>(type: "INTEGER", nullable: true),
                    gr_nr_01 = table.Column<bool>(type: "INTEGER", nullable: true),
                    life_style = table.Column<short>(type: "INTEGER", nullable: true),
                    verkehrsstatus = table.Column<short>(type: "INTEGER", nullable: true),
                    mwst_satz = table.Column<short>(type: "INTEGER", nullable: true),
                    abgabeschluessel = table.Column<short>(type: "INTEGER", nullable: true),
                    negativliste = table.Column<short>(type: "INTEGER", nullable: true),
                    normpackung = table.Column<short>(type: "INTEGER", nullable: true),
                    pzn_old = table.Column<long>(type: "INTEGER", nullable: true),
                    verschreibungspflicht = table.Column<short>(type: "INTEGER", nullable: true),
                    zuzahlungskennzeichen = table.Column<short>(type: "INTEGER", nullable: true),
                    packungsgroesse = table.Column<short>(type: "INTEGER", nullable: true),
                    darreichungsform = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    festbetrag = table.Column<int>(type: "INTEGER", nullable: true),
                    menge = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    mengeneinheit = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    indikations_nr = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    warengruppenschluessel = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    invalid = table.Column<DateTime>(type: "date", nullable: true),
                    zuz_frei_tstr = table.Column<short>(type: "INTEGER", nullable: true),
                    zuz_frei_feb = table.Column<short>(type: "INTEGER", nullable: true),
                    ampvamg = table.Column<short>(type: "INTEGER", nullable: true),
                    ampvsgb = table.Column<short>(type: "INTEGER", nullable: true),
                    calc_rabatt = table.Column<short>(type: "INTEGER", nullable: true),
                    gueltig_ab = table.Column<DateTime>(type: "date", nullable: true),
                    gueltig_bis = table.Column<DateTime>(type: "date", nullable: true),
                    check_pzn = table.Column<short>(type: "INTEGER", nullable: true),
                    steuer_pzn = table.Column<int>(type: "INTEGER", nullable: true),
                    rab_vertrag = table.Column<bool>(type: "INTEGER", nullable: true),
                    himi_zu_verb = table.Column<bool>(type: "INTEGER", nullable: true),
                    ve_menge = table.Column<int>(type: "INTEGER", nullable: true),
                    importkenner = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    rab_w_impfstof = table.Column<int>(type: "INTEGER", nullable: true),
                    medizinprodukt = table.Column<bool>(type: "INTEGER", nullable: true),
                    aus_ersetzung = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    biotech = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_abda_pkey", x => x.id_abda);
                });

            migrationBuilder.CreateTable(
                name: "er_abda_us",
                schema: "daten",
                columns: table => new
                {
                    id_abda_us = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_abda_us_temp_id_abda_us_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    pzn = table.Column<long>(type: "INTEGER", nullable: true),
                    key_aus = table.Column<int>(type: "INTEGER", nullable: true),
                    bezeichnung = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    darreichungsform = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    menge = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    mengeneinheit = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    gueltig_ab = table.Column<DateTime>(type: "date", nullable: true),
                    gueltig_bis = table.Column<DateTime>(type: "date", nullable: true),
                    import_gruppe_nr = table.Column<int>(type: "INTEGER", nullable: true),
                    ausnahme_ersetzung = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0"),
                    warengruppe = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_abda_us_pkey", x => x.id_abda_us);
                });

            migrationBuilder.CreateTable(
                name: "er_abda_us_temp",
                schema: "daten",
                columns: table => new
                {
                    id_abda_us = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_abda_us_temp_id_abda_us_seq1'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    pzn = table.Column<long>(type: "INTEGER", nullable: true),
                    key_aus = table.Column<int>(type: "INTEGER", nullable: true),
                    bezeichnung = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    darreichungsform = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    menge = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    mengeneinheit = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    gueltig_ab = table.Column<DateTime>(type: "date", nullable: true),
                    gueltig_bis = table.Column<DateTime>(type: "date", nullable: true),
                    import_gruppe_nr = table.Column<int>(type: "INTEGER", nullable: true),
                    ausnahme_ersetzung = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0"),
                    warengruppe = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_abda_us_temp_pkey", x => x.id_abda_us);
                });

            migrationBuilder.CreateTable(
                name: "er_apotheke",
                schema: "daten",
                columns: table => new
                {
                    id_apotheke = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    apotheke_name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    apotheke_name_zusatz = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    apo_ik_nr = table.Column<long>(type: "INTEGER", nullable: false),
                    inhaber_vorname = table.Column<string>(type: "TEXT", maxLength: 65, nullable: true),
                    inhaber_nachname = table.Column<string>(type: "TEXT", maxLength: 65, nullable: true),
                    apo_int_nr = table.Column<int>(type: "INTEGER", nullable: true),
                    plz = table.Column<int>(type: "INTEGER", nullable: true),
                    ort = table.Column<string>(type: "TEXT", maxLength: 45, nullable: true),
                    strasse = table.Column<string>(type: "TEXT", maxLength: 45, nullable: true),
                    email = table.Column<string>(type: "TEXT", maxLength: 45, nullable: true),
                    telefon = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    mobil = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    fax = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    bemerkung = table.Column<string>(type: "TEXT", nullable: true),
                    bundesland = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    mandant_type = table.Column<string>(type: "TEXT", maxLength: 4, nullable: true, defaultValueSql: "'APO'::character varying", comment: "APO - Apotheke\nHRST - Hersteller (Dienstleister)"),
                    id_le_type = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0"),
                    id_hauptapotheke = table.Column<long>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "ID der Hauptapotheke wenn dies eine Filialapotheke ist"),
                    id_ht_anrede = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0"),
                    filialapotheke = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0"),
                    gesperrt = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    sec_login = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "Security-Login - 0-Keiner, 1-Feste-IP, 2-DynDNS URLs, ..."),
                    sec_login_werte = table.Column<string>(type: "TEXT", maxLength: 580, nullable: true, comment: "Werte zum Security-Login"),
                    sec_login_nur_apo_user = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "Seurity-Login nur für Apotheken-Benutzer - F-nein, T-ja"),
                    aen_id_sec_user = table.Column<int>(type: "INTEGER", nullable: true),
                    aen_datum = table.Column<DateTime>(type: "date", nullable: true),
                    aen_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("apotheke_pkey", x => x.id_apotheke);
                });

            migrationBuilder.CreateTable(
                name: "er_fiverx_version",
                schema: "daten",
                columns: table => new
                {
                    id_fiverx_version = table.Column<int>(type: "INTEGER", nullable: false),
                    fiverx_version = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    ablaufdatum = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "'1000-01-01'::date", comment: "grance Periode - Version wird unterstützt bis zu diesem Datum"),
                    schemadatei = table.Column<string>(type: "TEXT", maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_fiverx_version_pkey", x => x.id_fiverx_version);
                });

            migrationBuilder.CreateTable(
                name: "er_prueferezept_emuster16",
                schema: "daten",
                columns: table => new
                {
                    id_prueferezept_emuster16 = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    rz_liefer_id = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    rz_datum = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    rz_liefer_datum = table.Column<DateTime>(type: "date", nullable: true),
                    rz_liefer_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    avs_id = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    pruef_modus = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true, comment: "SYNCHRON oder ASYNCHRON"),
                    rezept_typ = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true, comment: "Nur STANDARDREZEPT, BTM, SPRECHSTUNDENBEDARF"),
                    muster16_id = table.Column<long>(type: "INTEGER", nullable: true),
                    abda_kassentyp = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true, comment: "kArt"),
                    apo_ik_nr = table.Column<long>(type: "INTEGER", nullable: true),
                    kk_typ = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true, comment: "rTyp"),
                    gesamtes_brutto = table.Column<decimal>(type: "TEXT", precision: 11, scale: 2, nullable: true, defaultValueSql: "0"),
                    zuzahlung = table.Column<decimal>(type: "TEXT", precision: 11, scale: 2, nullable: true, defaultValueSql: "0"),
                    abgabedatum = table.Column<DateTime>(type: "date", nullable: true, comment: "abDatum"),
                    betriebsstaetten_nr = table.Column<long>(type: "INTEGER", nullable: true, comment: "vrtrgsArztNr - Betriebsstättennummer oder Praxis-Nummer"),
                    arzt_nr = table.Column<long>(type: "INTEGER", nullable: true, comment: "laNr - Lebenslange Arzt-Nummer"),
                    verordnungsdatum = table.Column<DateTime>(type: "date", nullable: true, comment: "verDat - Ausstellungsdatum - Verordnungsdatum"),
                    kk_ik_nr = table.Column<long>(type: "INTEGER", nullable: true, comment: "Krankenkassen-Ik der Versicherung"),
                    versicherten_nummer = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true, comment: "vrsNr"),
                    versicherten_status = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true, comment: "vStat"),
                    versicherten_titel = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true, comment: "vTitel"),
                    kk_name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true, comment: "kName"),
                    versicherten_name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true, comment: "vName"),
                    versicherten_vorname = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true, comment: "vVorname"),
                    versicherten_strasse = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true, comment: "vStr"),
                    versicherten_plz = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true, comment: "vPlz"),
                    versicherten_ort = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true, comment: "vOrt"),
                    versicherten_geburtsdatum = table.Column<DateTime>(type: "date", nullable: true, comment: "vGeb"),
                    kz_bvg = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "bvg"),
                    kz_hilfsmittel = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "hilf"),
                    kz_impfstoff = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "impf"),
                    kz_sprechstundenbedarf = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "sprStBedarf"),
                    begr_pflicht = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "bgrPfl"),
                    kz_gebuehren_frei = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "gebFrei"),
                    kz_noctu = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "noctu"),
                    kz_unfall = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "unfall"),
                    unfall_datum = table.Column<DateTime>(type: "date", nullable: true, comment: "unfallTag"),
                    eigenanteil = table.Column<decimal>(type: "TEXT", precision: 11, scale: 2, nullable: true, defaultValueSql: "0", comment: "eigBet"),
                    bediener = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    arbeitsplatz = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true, comment: "arbPlatz"),
                    kz_sonstige = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "sonstige"),
                    versichertenkarte_gueltig_bis = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true, comment: "vkGueltigBis"),
                    kz_arbeitsunfall = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "aUnfall"),
                    t_sicherheitsbestimmung = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "tSicherheitsbestimmung"),
                    t_fachinformation = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "tFachinformation"),
                    t_in_label = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "tInLabel"),
                    t_off_label = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "tOffLabel"),
                    id_prueferezepte_header = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_prueferezept_emuster16_pkey", x => x.id_prueferezept_emuster16);
                });

            migrationBuilder.CreateTable(
                name: "er_prueferezept_erezept",
                schema: "daten",
                columns: table => new
                {
                    id_prueferezept_erezept = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    rz_liefer_id = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    rz_datum = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    rz_liefer_datum = table.Column<DateTime>(type: "date", nullable: true),
                    rz_liefer_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    avs_id = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    pruef_modus = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    erezept_id = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    erezept_data = table.Column<string>(type: "TEXT", nullable: true, comment: "Base64 Codierung der eRezept Daten")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_prueferezept_erezept_pkey", x => x.id_prueferezept_erezept);
                });

            migrationBuilder.CreateTable(
                name: "er_prueferezept_header",
                schema: "daten",
                columns: table => new
                {
                    id_prueferezept_header = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    apo_int_nr = table.Column<int>(type: "INTEGER", nullable: false),
                    apo_ik_nr = table.Column<long>(type: "INTEGER", nullable: true, defaultValueSql: "0"),
                    software_hersteller = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    software_name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    software_version = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    apo_password = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    testdaten = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    rz_liefer_id = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    rz_liefer_datum = table.Column<DateTime>(type: "date", nullable: true),
                    rz_liefer_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    avs_sende_id = table.Column<long>(type: "INTEGER", nullable: true),
                    rezept_status = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true, defaultValueSql: "'VOR_PRUEFUNG'::character varying"),
                    rezept_check = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "Rezeptprüfung durchgeführt TRUE|FALSE"),
                    rez_typ = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false, defaultValueSql: "'X'::character varying", comment: "eRez->ERezept, pRez->pRezept, eM16->eMuster16 Rezept, X->Unbekannt"),
                    reztyp_erez = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "Rezept-Typ eRezept"),
                    reztyp_em16 = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "Rezept-Typ eMuster16"),
                    reztyp_prez = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "Rezept-Typ pRezept"),
                    status_abfrage_datum = table.Column<DateTime>(type: "date", nullable: true, comment: "Abfragedatum des Status zur Liefer-ID"),
                    status_abfrage_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true, comment: "Abfragezeit des Status zur Liefer-ID"),
                    check_erez = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "eRezepte wurden überprüft"),
                    check_em16 = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "eMuster16 Rezepte wurden überprüft"),
                    check_prez = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "pRezepte wurden überprüft"),
                    import_typ = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "Art wie das Rezept importiert wurde - 0-WebService, 1-Formular, 2-Datei")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_prueferezept_header_pkey", x => x.id_prueferezept_header);
                });

            migrationBuilder.CreateTable(
                name: "er_rabatt_gruppe",
                schema: "daten",
                columns: table => new
                {
                    id_rabatt_gruppe = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_rabatt_gruppe_temp_id_rabatt_gruppe_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    key_gruppe = table.Column<int>(type: "INTEGER", nullable: true),
                    mkv = table.Column<short>(type: "INTEGER", nullable: true),
                    zuzahlung_faktor = table.Column<short>(type: "INTEGER", nullable: true),
                    gueltig_ab = table.Column<DateTime>(type: "date", nullable: true),
                    gueltig_bis = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_rabatt_gruppe_temp_pkey", x => x.id_rabatt_gruppe);
                });

            migrationBuilder.CreateTable(
                name: "er_rabatt_gruppe_temp",
                schema: "daten",
                columns: table => new
                {
                    id_rabatt_gruppe = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_rabatt_gruppe_id_rabatt_gruppe_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    key_gruppe = table.Column<int>(type: "INTEGER", nullable: true),
                    mkv = table.Column<short>(type: "INTEGER", nullable: true),
                    zuzahlung_faktor = table.Column<short>(type: "INTEGER", nullable: true),
                    gueltig_ab = table.Column<DateTime>(type: "date", nullable: true),
                    gueltig_bis = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_rabatt_gruppe_pkey", x => x.id_rabatt_gruppe);
                });

            migrationBuilder.CreateTable(
                name: "er_rabatt_indika",
                schema: "daten",
                columns: table => new
                {
                    id_rabatt_indika = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_rabatt_indika_temp_id_rabatt_indika_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    pzn = table.Column<long>(type: "INTEGER", nullable: true),
                    indikation = table.Column<int>(type: "INTEGER", nullable: true),
                    gueltig_ab = table.Column<DateTime>(type: "date", nullable: true),
                    gueltig_bis = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_rabatt_indika_pkey", x => x.id_rabatt_indika);
                });

            migrationBuilder.CreateTable(
                name: "er_rabatt_indika_temp",
                schema: "daten",
                columns: table => new
                {
                    id_rabatt_indika = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_rabatt_indika_id_rabatt_indika_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    pzn = table.Column<long>(type: "INTEGER", nullable: true),
                    indikation = table.Column<int>(type: "INTEGER", nullable: true),
                    gueltig_ab = table.Column<DateTime>(type: "date", nullable: true),
                    gueltig_bis = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_rabatt_indika_temp_pkey", x => x.id_rabatt_indika);
                });

            migrationBuilder.CreateTable(
                name: "er_rabatt_kasse",
                schema: "daten",
                columns: table => new
                {
                    id_rabatt_kasse = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_rabatt_kasse_temp_id_rabatt_kasse_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    key_gruppe = table.Column<int>(type: "INTEGER", nullable: true),
                    kasse_ik = table.Column<int>(type: "INTEGER", nullable: true),
                    gueltig_ab = table.Column<DateTime>(type: "date", nullable: true),
                    gueltig_bis = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_rabatt_kasse_temp_pkey", x => x.id_rabatt_kasse);
                });

            migrationBuilder.CreateTable(
                name: "er_rabatt_kasse_temp",
                schema: "daten",
                columns: table => new
                {
                    id_rabatt_kasse = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_rabatt_kasse_id_rabatt_kasse_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    key_gruppe = table.Column<int>(type: "INTEGER", nullable: true),
                    kasse_ik = table.Column<int>(type: "INTEGER", nullable: true),
                    gueltig_ab = table.Column<DateTime>(type: "date", nullable: true),
                    gueltig_bis = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_rabatt_kasse_pkey", x => x.id_rabatt_kasse);
                });

            migrationBuilder.CreateTable(
                name: "er_rabatt_pzn",
                schema: "daten",
                columns: table => new
                {
                    id_rabatt_pzn = table.Column<long>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_rabatt_pzn_temp_id_rabatt_pzn_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    key_gruppe = table.Column<int>(type: "INTEGER", nullable: true),
                    arznei_pzn = table.Column<long>(type: "INTEGER", nullable: true),
                    gueltig_ab = table.Column<DateTime>(type: "date", nullable: true),
                    gueltig_bis = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_rabatt_pzn_pkey", x => x.id_rabatt_pzn);
                });

            migrationBuilder.CreateTable(
                name: "er_rabatt_pzn_temp",
                schema: "daten",
                columns: table => new
                {
                    id_rabatt_pzn = table.Column<long>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_rabatt_pzn_temp_id_rabatt_pzn_seq1'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    key_gruppe = table.Column<int>(type: "INTEGER", nullable: true),
                    arznei_pzn = table.Column<long>(type: "INTEGER", nullable: true),
                    gueltig_ab = table.Column<DateTime>(type: "date", nullable: true),
                    gueltig_bis = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_rabatt_pzn_temp_pkey", x => x.id_rabatt_pzn);
                });

            migrationBuilder.CreateTable(
                name: "er_rabatt_wirkstoff",
                schema: "daten",
                columns: table => new
                {
                    pzn = table.Column<long>(type: "INTEGER", nullable: false),
                    komponentennr = table.Column<int>(type: "INTEGER", nullable: false),
                    fai_db_rang = table.Column<int>(type: "INTEGER", nullable: false),
                    gueltig_bis = table.Column<DateTime>(type: "date", nullable: false),
                    gueltig_ab = table.Column<DateTime>(type: "date", nullable: false),
                    fai_db_zahl = table.Column<float>(type: "REAL", nullable: false),
                    fai_db_key_sto = table.Column<int>(type: "INTEGER", nullable: false),
                    fam_db_key_ind_haupt = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    fam_db_key_ind_neben = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    pac_apo_key_war = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    pgr_apo_einstufung = table.Column<int>(type: "INTEGER", nullable: false),
                    fam_db_key_dar = table.Column<string>(type: "TEXT", maxLength: 3, nullable: false),
                    fam_db_key_atc = table.Column<string>(type: "TEXT", maxLength: 12, nullable: false),
                    fak_db_absolutbezug_einheit = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    pac_apo_key_aus = table.Column<int>(type: "INTEGER", nullable: false),
                    pac_apo_importgruppennr = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_rabatt_wirkstoff_pkey", x => new { x.pzn, x.komponentennr, x.fai_db_rang, x.gueltig_bis });
                });

            migrationBuilder.CreateTable(
                name: "er_rabatt_wirkstoff_temp",
                schema: "daten",
                columns: table => new
                {
                    pzn = table.Column<long>(type: "INTEGER", nullable: false),
                    komponentennr = table.Column<int>(type: "INTEGER", nullable: false),
                    fai_db_rang = table.Column<int>(type: "INTEGER", nullable: false),
                    gueltig_bis = table.Column<DateTime>(type: "date", nullable: false),
                    gueltig_ab = table.Column<DateTime>(type: "date", nullable: false),
                    fai_db_zahl = table.Column<float>(type: "REAL", nullable: false),
                    fai_db_key_sto = table.Column<int>(type: "INTEGER", nullable: false),
                    fam_db_key_ind_haupt = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    fam_db_key_ind_neben = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    pac_apo_key_war = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    pgr_apo_einstufung = table.Column<int>(type: "INTEGER", nullable: false),
                    fam_db_key_dar = table.Column<string>(type: "TEXT", maxLength: 3, nullable: false),
                    fam_db_key_atc = table.Column<string>(type: "TEXT", maxLength: 12, nullable: false),
                    fak_db_absolutbezug_einheit = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    pac_apo_key_aus = table.Column<int>(type: "INTEGER", nullable: false),
                    pac_apo_importgruppennr = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_rabatt_wirkstoff_temp_pkey", x => new { x.pzn, x.komponentennr, x.fai_db_rang, x.gueltig_bis });
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_header",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_header = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    apo_int_nr = table.Column<int>(type: "INTEGER", nullable: false),
                    apo_ik_nr = table.Column<long>(type: "INTEGER", nullable: true, defaultValueSql: "0"),
                    software_hersteller = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    software_name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    software_version = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    apo_password = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    testdaten = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    rz_liefer_id = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    rz_liefer_datum = table.Column<DateTime>(type: "date", nullable: true),
                    rz_liefer_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    avs_sende_id = table.Column<long>(type: "INTEGER", nullable: true),
                    rezept_status = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true, defaultValueSql: "'VOR_PRUEFUNG'::character varying"),
                    rezept_check = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "Rezeptprüfung durchgeführt TRUE|FALSE"),
                    rez_typ = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false, defaultValueSql: "'X'::character varying", comment: "eRez->ERezept, pRez->pRezept, eM16->eMuster16 Rezept, X->Unbekannt"),
                    reztyp_erez = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "Rezept-Typ eRezept"),
                    reztyp_em16 = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "Rezept-Typ eMuster16"),
                    reztyp_prez = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "Rezept-Typ pRezept"),
                    abfrage_datum = table.Column<DateTime>(type: "date", nullable: true, comment: "Abfragedatum des Status zur Liefer-ID"),
                    abfrage_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true, comment: "Abfragezeit des Status zur Liefer-ID"),
                    check_erez = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "eRezepte wurden überprüft"),
                    check_em16 = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "eMuster16 Rezepte wurden überprüft"),
                    check_prez = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "pRezepte wurden überprüft"),
                    import_typ = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "Art wie das Rezept importiert wurde - 0-WebService, 1-Formular, 2-Datei"),
                    check_datum = table.Column<DateTime>(type: "date", nullable: true, comment: "Datum des letzten Checks der Rezepte dieser LieferID"),
                    check_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true, comment: "Zeit des letzten Checks der Rezepte dieser LieferID")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_senderezepte_header_pkey", x => x.id_senderezepte_header);
                });

            migrationBuilder.CreateTable(
                name: "er_sonder_pzn",
                schema: "daten",
                columns: table => new
                {
                    id_sonder_pzn = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    sonder_pzn = table.Column<long>(type: "INTEGER", nullable: true),
                    beschreibung_kurz = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    beschreibung = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    ust = table.Column<short>(type: "INTEGER", nullable: true),
                    kommentar = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    gueltig_ab = table.Column<DateTime>(type: "date", nullable: true),
                    gueltig_bis = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_sonder_pzn_temp_pkey", x => x.id_sonder_pzn);
                });

            migrationBuilder.CreateTable(
                name: "er_usecase",
                schema: "daten",
                columns: table => new
                {
                    id_usecase = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    main_uc_nr = table.Column<short>(type: "INTEGER", nullable: false),
                    main_uc = table.Column<bool>(type: "INTEGER", nullable: true),
                    sub_uc = table.Column<bool>(type: "INTEGER", nullable: true),
                    main_uc_id = table.Column<int>(type: "INTEGER", nullable: true, comment: "wenn sub_uc - die id_usecase des Main UC"),
                    option = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true, comment: "z.B. synchron oder asynchron"),
                    freigegeben = table.Column<bool>(type: "INTEGER", nullable: true, comment: "Freigabe von AVC (Rechenzentrum)"),
                    beschreibung = table.Column<string>(type: "TEXT", nullable: true),
                    sub_uc_nr = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0"),
                    bezeichnung = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_usecase_pkey", x => x.id_usecase);
                });

            migrationBuilder.CreateTable(
                name: "er_sec_access_fiverx",
                schema: "daten",
                columns: table => new
                {
                    id_sec_access_fiverx = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_apotheke = table.Column<int>(type: "INTEGER", nullable: false),
                    login_id = table.Column<string>(type: "TEXT", maxLength: 47, nullable: false),
                    login_passwort = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    login_passwort_crypt = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    freigegeben = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    erez_uc4 = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    erez_uc51 = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    erez_uc52 = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    em16_uc61_asyn = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    em16_uc61_syn = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    em16_uc61_u1 = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    erez_uc62_asyn = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    erez_uc62_syn = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    erez_uc7 = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    aen_id_sec_user = table.Column<int>(type: "INTEGER", nullable: true),
                    aen_datum = table.Column<DateTime>(type: "date", nullable: true),
                    aen_zeit = table.Column<TimeSpan>(type: "time(0) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_sec_access_fiverx_pkey", x => x.id_sec_access_fiverx);
                    table.ForeignKey(
                        name: "er_sec_access_fiverx_id_apotheke_fkey",
                        column: x => x.id_apotheke,
                        principalSchema: "daten",
                        principalTable: "er_apotheke",
                        principalColumn: "id_apotheke",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "er_prueferezept_emuster16_artikel",
                schema: "daten",
                columns: table => new
                {
                    id_prueferezept_emuster16_artikel = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_prueferezept_emuster16_art_id_prueferezept_emuster16_art_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    id_prueferezept_emuster16 = table.Column<int>(type: "INTEGER", nullable: true),
                    arznei_pzn = table.Column<long>(type: "INTEGER", nullable: true),
                    hilfsmittel_nr = table.Column<long>(type: "INTEGER", nullable: true),
                    atrikel_nr = table.Column<short>(type: "INTEGER", nullable: true),
                    artikel_faktor = table.Column<int>(type: "INTEGER", nullable: true),
                    artikel_taxe = table.Column<decimal>(type: "TEXT", precision: 11, scale: 2, nullable: true, defaultValueSql: "0"),
                    artikel_autidem = table.Column<short>(type: "INTEGER", nullable: true),
                    artikel_medi_name = table.Column<string>(type: "TEXT", maxLength: 130, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_prueferezept_emuster16_artikel_pkey", x => x.id_prueferezept_emuster16_artikel);
                    table.ForeignKey(
                        name: "er_prueferezept_emuster16_artike_id_prueferezept_emuster16_fkey",
                        column: x => x.id_prueferezept_emuster16,
                        principalSchema: "daten",
                        principalTable: "er_prueferezept_emuster16",
                        principalColumn: "id_prueferezept_emuster16",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "er_prueferezept_emuster16_status",
                schema: "daten",
                columns: table => new
                {
                    id_prueferezept_emuster16_status = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_prueferezept_emuster16_sta_id_prueferezept_emuster16_sta_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    id_prueferezept_emuster16 = table.Column<int>(type: "INTEGER", nullable: true),
                    muster16_id = table.Column<long>(type: "INTEGER", nullable: true),
                    rezept_status = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true, defaultValueSql: "'VOR_PRUEFUNG'::character varying"),
                    rezept_check = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    status_abfrage_datum = table.Column<DateTime>(type: "date", nullable: true, comment: "Abfragedatum des Status zum Rezept"),
                    status_abfrage_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true, comment: "Abfragezeit des Status zum Rezept")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_prueferezept_emuster16_status_pkey", x => x.id_prueferezept_emuster16_status);
                    table.ForeignKey(
                        name: "er_prueferezept_emuster16_status_id_prueferezept_emuster16",
                        column: x => x.id_prueferezept_emuster16,
                        principalSchema: "daten",
                        principalTable: "er_prueferezept_emuster16",
                        principalColumn: "id_prueferezept_emuster16",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "er_prueferezept_emuster16_statusinfo",
                schema: "daten",
                columns: table => new
                {
                    id_prueferezept_emuster16_statusinfo = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_prueferezept_emuster16_sta_id_prueferezept_emuster16_st_seq1'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    id_prueferezept_emuster16 = table.Column<int>(type: "INTEGER", nullable: true),
                    fcode = table.Column<string>(type: "TEXT", maxLength: 4, nullable: true),
                    fstatus = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    fkommentar = table.Column<string>(type: "TEXT", nullable: true),
                    ftcode = table.Column<string>(type: "TEXT", maxLength: 3, nullable: true),
                    posnr = table.Column<short>(type: "INTEGER", nullable: true),
                    fkurztext = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_prueferezept_emuster16_statusinfo_pkey", x => x.id_prueferezept_emuster16_statusinfo);
                    table.ForeignKey(
                        name: "er_prueferezept_emuster16_statusinfo_id_prueferezept_emuster16",
                        column: x => x.id_prueferezept_emuster16,
                        principalSchema: "daten",
                        principalTable: "er_prueferezept_emuster16",
                        principalColumn: "id_prueferezept_emuster16",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "er_prueferezept_erezept_statusinfo",
                schema: "daten",
                columns: table => new
                {
                    id_prueferezept_erezept_statusinfo = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_prueferezept_erezept_statu_id_prueferezept_erezept_statu_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    id_prueferezept_erezept = table.Column<int>(type: "INTEGER", nullable: true),
                    fcode = table.Column<short>(type: "INTEGER", nullable: true),
                    fstatus = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    fkommentar = table.Column<string>(type: "TEXT", nullable: true),
                    ftcode = table.Column<short>(type: "INTEGER", nullable: true),
                    posnr = table.Column<short>(type: "INTEGER", nullable: true),
                    fkurztext = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_prueferezept_erezept_statusinfo_pkey", x => x.id_prueferezept_erezept_statusinfo);
                    table.ForeignKey(
                        name: "er_prueferezept_erezept_statusinfo_id_prueferezept_erezept",
                        column: x => x.id_prueferezept_erezept,
                        principalSchema: "daten",
                        principalTable: "er_prueferezept_erezept",
                        principalColumn: "id_prueferezept_erezept",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "er_prueferezept_erezept_lieferid",
                schema: "daten",
                columns: table => new
                {
                    id_prueferezept_erezept = table.Column<int>(type: "INTEGER", nullable: false),
                    id_prueferezept_header = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_prueferezept_erezept_lieferid_pkey", x => new { x.id_prueferezept_erezept, x.id_prueferezept_header });
                    table.ForeignKey(
                        name: "er_prueferezept_erezept_lieferid_id_prueferezept_header",
                        column: x => x.id_prueferezept_header,
                        principalSchema: "daten",
                        principalTable: "er_prueferezept_header",
                        principalColumn: "id_prueferezept_header",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "er_prueferezept_erezept_lieferid_id_prueferezept_prezept",
                        column: x => x.id_prueferezept_erezept,
                        principalSchema: "daten",
                        principalTable: "er_prueferezept_erezept",
                        principalColumn: "id_prueferezept_erezept",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_emuster16",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_emuster16 = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_senderezepte_header = table.Column<int>(type: "INTEGER", nullable: false),
                    rz_liefer_id = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    rz_datum = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    rz_liefer_datum = table.Column<DateTime>(type: "date", nullable: true),
                    rz_liefer_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    avs_id = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    abrechnungs_periode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true, comment: "aPeriode"),
                    rezept_typ = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true, comment: "Nur STANDARDREZEPT, BTM, SPRECHSTUNDENBEDARF"),
                    muster16_id = table.Column<long>(type: "INTEGER", nullable: true),
                    abda_kassentyp = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true, comment: "kArt"),
                    apo_ik_nr = table.Column<long>(type: "INTEGER", nullable: true),
                    kk_typ = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true, comment: "rTyp"),
                    gesamtes_brutto = table.Column<decimal>(type: "TEXT", precision: 11, scale: 2, nullable: true, defaultValueSql: "0"),
                    zuzahlung = table.Column<decimal>(type: "TEXT", precision: 11, scale: 2, nullable: true, defaultValueSql: "0"),
                    abgabedatum = table.Column<DateTime>(type: "date", nullable: true, comment: "abDatum"),
                    betriebsstaetten_nr = table.Column<long>(type: "INTEGER", nullable: true, comment: "vrtrgsArztNr - Betriebsstättennummer oder Praxis-Nummer"),
                    arzt_nr = table.Column<long>(type: "INTEGER", nullable: true, comment: "laNr - Lebenslange Arzt-Nummer"),
                    verordnungsdatum = table.Column<DateTime>(type: "date", nullable: true, comment: "verDat - Ausstellungsdatum - Verordnungsdatum"),
                    kk_ik_nr = table.Column<long>(type: "INTEGER", nullable: true, comment: "Krankenkassen-Ik der Versicherung"),
                    versicherten_nummer = table.Column<string>(type: "TEXT", maxLength: 12, nullable: true, comment: "vrsNr"),
                    versicherten_status = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true, comment: "vStat"),
                    versicherten_titel = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true, comment: "vTitel"),
                    kk_name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true, comment: "kName"),
                    versicherten_name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true, comment: "vName"),
                    versicherten_vorname = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true, comment: "vVorname"),
                    versicherten_strasse = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true, comment: "vStr"),
                    versicherten_plz = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true, comment: "vPlz"),
                    versicherten_ort = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true, comment: "vOrt"),
                    versicherten_geburtsdatum = table.Column<DateTime>(type: "date", nullable: true, comment: "vGeb"),
                    kz_bvg = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "bvg"),
                    kz_hilfsmittel = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "hilf"),
                    kz_impfstoff = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "impf"),
                    kz_sprechstundenbedarf = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "sprStBedarf"),
                    begr_pflicht = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "bgrPfl"),
                    kz_gebuehren_frei = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "gebFrei"),
                    kz_noctu = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "noctu"),
                    kz_unfall = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "unfall"),
                    unfall_datum = table.Column<DateTime>(type: "date", nullable: true, comment: "unfallTag"),
                    eigenanteil = table.Column<decimal>(type: "TEXT", precision: 11, scale: 2, nullable: true, defaultValueSql: "0", comment: "eigBet"),
                    bediener = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    arbeitsplatz = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true, comment: "arbPlatz"),
                    kz_sonstige = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "sonstige"),
                    versichertenkarte_gueltig_bis = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true, comment: "vkGueltigBis"),
                    kz_arbeitsunfall = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "aUnfall"),
                    t_sicherheitsbestimmung = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "tSicherheitsbestimmung"),
                    t_fachinformation = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "tFachinformation"),
                    t_in_label = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "tInLabel"),
                    t_off_label = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "tOffLabel")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_senderezepte_emuster16_pkey", x => x.id_senderezepte_emuster16);
                    table.ForeignKey(
                        name: "er_senderezepte_emuster16_id_senderezepte_header",
                        column: x => x.id_senderezepte_header,
                        principalSchema: "daten",
                        principalTable: "er_senderezepte_header",
                        principalColumn: "id_senderezepte_header",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_erezept",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_erezept = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_senderezepte_header = table.Column<int>(type: "INTEGER", nullable: false),
                    rz_liefer_id = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    rz_datum = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    rz_liefer_datum = table.Column<DateTime>(type: "date", nullable: true),
                    rz_liefer_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    avs_id = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    abrechnungs_periode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    apo_ik_nr = table.Column<long>(type: "INTEGER", nullable: true),
                    erezept_id = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    erezept_data = table.Column<string>(type: "TEXT", nullable: true, comment: "Base64 Codierung der eRezept Daten")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_senderezepte_erezept_pkey", x => x.id_senderezepte_erezept);
                    table.ForeignKey(
                        name: "er_senderezepte_erezept_id_senderezepte_header",
                        column: x => x.id_senderezepte_header,
                        principalSchema: "daten",
                        principalTable: "er_senderezepte_header",
                        principalColumn: "id_senderezepte_header",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_header_daten",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_header_daten = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_senderezepte_header = table.Column<int>(type: "INTEGER", nullable: true),
                    header_uuid = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false, comment: "Eindeutige Header - Universal Unique Identifier (UUID)"),
                    transfer_arz = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "Bestätigung vom ARZ - Transfer der Rezeptdaten erfolgt"),
                    xml_request = table.Column<string>(type: "TEXT", nullable: false, comment: "Kompletter Original XML-Request der Apotheke - zur Weiterleitung ins ARZ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_senderezepte_header_daten_pkey", x => x.id_senderezepte_header_daten);
                    table.ForeignKey(
                        name: "er_senderezepte_header_daten_id_senderezepte_header",
                        column: x => x.id_senderezepte_header,
                        principalSchema: "daten",
                        principalTable: "er_senderezepte_header",
                        principalColumn: "id_senderezepte_header",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_prezept",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_prezept = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_senderezepte_header = table.Column<int>(type: "INTEGER", nullable: false),
                    rz_liefer_id = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    rz_datum = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    rz_liefer_datum = table.Column<DateTime>(type: "date", nullable: true),
                    rz_liefer_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true),
                    avs_id = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    abrechnungs_periode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true, comment: "aPeriode"),
                    rezept_typ = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true, comment: "Nur STANDARDREZEPT, BTM, SPRECHSTUNDENBEDARF"),
                    transaktions_nummer = table.Column<long>(type: "INTEGER", nullable: true, comment: "transaktionsNummer"),
                    abda_kassentyp = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true, comment: "kArt"),
                    apo_ik_nr = table.Column<long>(type: "INTEGER", nullable: true, comment: "apoIk"),
                    kk_typ = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true, comment: "rTyp"),
                    gesamtes_brutto = table.Column<decimal>(type: "TEXT", precision: 11, scale: 2, nullable: true, defaultValueSql: "0"),
                    zuzahlung = table.Column<decimal>(type: "TEXT", precision: 11, scale: 2, nullable: true, defaultValueSql: "0"),
                    ppos1_pzn = table.Column<long>(type: "INTEGER", nullable: true, comment: "pPosition1->pzn"),
                    ppos1_faktor = table.Column<int>(type: "INTEGER", nullable: true, comment: "pPosition1->faktor"),
                    ppos1_taxe = table.Column<decimal>(type: "TEXT", precision: 11, scale: 2, nullable: true, defaultValueSql: "0", comment: "pPosition1->taxe"),
                    abgabedatum = table.Column<DateTime>(type: "date", nullable: true, comment: "abDatum"),
                    erstellungs_zeitpunkt = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true, comment: "erstellungsZeitpunkt"),
                    hash_code = table.Column<string>(type: "TEXT", maxLength: 40, nullable: true, comment: "hashCode"),
                    betriebsstaetten_nr = table.Column<long>(type: "INTEGER", nullable: true, comment: "vrtrgsArztNr - Betriebsstättennummer oder Praxis-Nummer"),
                    arzt_nr = table.Column<long>(type: "INTEGER", nullable: true, comment: "laNr - Lebenslange Arzt-Nummer"),
                    verordnungsdatum = table.Column<DateTime>(type: "date", nullable: true, comment: "verDat - Ausstellungsdatum - Verordnungsdatum"),
                    kk_ik_nr = table.Column<long>(type: "INTEGER", nullable: true, comment: "kkIk Krankenkassen-Ik der Versicherung"),
                    versicherten_nummer = table.Column<string>(type: "TEXT", maxLength: 12, nullable: true, comment: "vrsNr"),
                    kk_name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true, comment: "kName"),
                    versicherten_status = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true, comment: "vStat"),
                    versicherten_geburtsdatum = table.Column<DateTime>(type: "date", nullable: true, comment: "vGeb"),
                    kz_bvg = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "bvg"),
                    kz_sprechstundenbedarf = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "sprStBedarf"),
                    kz_gebuehren_frei = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "gebFrei"),
                    kz_noctu = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "noctu"),
                    bediener = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    arbeitsplatz = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true, comment: "arbPlatz"),
                    kz_sonstige = table.Column<short>(type: "INTEGER", nullable: true, defaultValueSql: "0", comment: "sonstige"),
                    versichertenkarte_gueltig_bis = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true, comment: "vkGueltigBis")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_senderezepte_prezept_pkey", x => x.id_senderezepte_prezept);
                    table.ForeignKey(
                        name: "er_senderezepte_prezept_id_senderezepte_header",
                        column: x => x.id_senderezepte_header,
                        principalSchema: "daten",
                        principalTable: "er_senderezepte_header",
                        principalColumn: "id_senderezepte_header",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_emuster16_artikel",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_emuster16_artikel = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_senderezepte_emuster16_art_id_senderezepte_emuster16_art_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    id_senderezepte_emuster16 = table.Column<int>(type: "INTEGER", nullable: true),
                    arznei_pzn = table.Column<long>(type: "INTEGER", nullable: true),
                    hilfsmittel_nr = table.Column<long>(type: "INTEGER", nullable: true),
                    atrikel_nr = table.Column<short>(type: "INTEGER", nullable: true),
                    artikel_faktor = table.Column<int>(type: "INTEGER", nullable: true),
                    artikel_taxe = table.Column<decimal>(type: "TEXT", precision: 11, scale: 2, nullable: true, defaultValueSql: "0"),
                    artikel_autidem = table.Column<short>(type: "INTEGER", nullable: true),
                    artikel_medi_name = table.Column<string>(type: "TEXT", maxLength: 130, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_senderezepte_emuster16_artikel_pkey", x => x.id_senderezepte_emuster16_artikel);
                    table.ForeignKey(
                        name: "er_senderezepte_emuster16_artike_id_senderezepte_emuster16_fkey",
                        column: x => x.id_senderezepte_emuster16,
                        principalSchema: "daten",
                        principalTable: "er_senderezepte_emuster16",
                        principalColumn: "id_senderezepte_emuster16",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_emuster16_daten",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_emuster16_daten = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_senderezepte_emuster16_dat_id_senderezepte_emuster16_dat_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    id_senderezepte_emuster16 = table.Column<int>(type: "INTEGER", nullable: true),
                    rezept_uuid = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false, comment: "Eindeutiger Rezept - Universal Unique Identifier (UUID)"),
                    transfer_arz = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "Bestätigung vom ARZ - Transfer der Rezeptdaten erfolgt"),
                    xml_request = table.Column<string>(type: "TEXT", nullable: false, comment: "Original XML-Request der Apotheke (nur Rezept-XML) - zur Weiterleitung ins ARZ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_senderezepte_emuster16_daten_pkey", x => x.id_senderezepte_emuster16_daten);
                    table.ForeignKey(
                        name: "er_senderezepte_emuster16_daten_id_senderezepte_emuster16",
                        column: x => x.id_senderezepte_emuster16,
                        principalSchema: "daten",
                        principalTable: "er_senderezepte_emuster16",
                        principalColumn: "id_senderezepte_emuster16",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_emuster16_status",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_emuster16_status = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_senderezepte_emuster16_sta_id_senderezepte_emuster16_sta_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    id_senderezepte_emuster16 = table.Column<int>(type: "INTEGER", nullable: true),
                    muster16_id = table.Column<long>(type: "INTEGER", nullable: true),
                    rezept_status = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true, defaultValueSql: "'VOR_PRUEFUNG'::character varying"),
                    rezept_check = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    status_abfrage_datum = table.Column<DateTime>(type: "date", nullable: true, comment: "Abfragedatum des Status zum Rezept"),
                    status_abfrage_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true, comment: "Abfragezeit des Status zum Rezept"),
                    abrechen_status = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true, defaultValueSql: "'VOR_PRUEFUNG'::character varying", comment: "Interner Status - enthält immer das Prüfergebnis"),
                    rz_abfrage_id = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true, comment: "ID mit der alle DS gekennzeichnet sind die innerhalb einer RCS Abfrage gesendet wurden")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_senderezepte_emuster16_status_pkey", x => x.id_senderezepte_emuster16_status);
                    table.ForeignKey(
                        name: "er_senderezepte_emuster16_status_id_senderezepte_emuster16",
                        column: x => x.id_senderezepte_emuster16,
                        principalSchema: "daten",
                        principalTable: "er_senderezepte_emuster16",
                        principalColumn: "id_senderezepte_emuster16",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_emuster16_statusinfo",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_emuster16_statusinfo = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_senderezepte_emuster16_sta_id_senderezepte_emuster16_st_seq1'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    id_senderezepte_emuster16 = table.Column<int>(type: "INTEGER", nullable: true),
                    fcode = table.Column<string>(type: "TEXT", maxLength: 4, nullable: true),
                    fstatus = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    fkommentar = table.Column<string>(type: "TEXT", nullable: true),
                    ftcode = table.Column<string>(type: "TEXT", maxLength: 3, nullable: true),
                    posnr = table.Column<short>(type: "INTEGER", nullable: true),
                    fkurztext = table.Column<string>(type: "TEXT", nullable: true),
                    regel_nr = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    regel_treffer_code = table.Column<string>(type: "TEXT", maxLength: 7, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_senderezepte_emuster16_statusinfo_pkey", x => x.id_senderezepte_emuster16_statusinfo);
                    table.ForeignKey(
                        name: "er_senderezepte_emuster16_statusinfo_id_senderezepte_emuster16",
                        column: x => x.id_senderezepte_emuster16,
                        principalSchema: "daten",
                        principalTable: "er_senderezepte_emuster16",
                        principalColumn: "id_senderezepte_emuster16",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_erezept_daten",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_erezept_daten = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_senderezepte_erezept = table.Column<int>(type: "INTEGER", nullable: true),
                    rezept_uuid = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false, comment: "Eindeutiger Rezept - Universal Unique Identifier (UUID)"),
                    transfer_arz = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "Bestätigung vom ARZ - Transfer der Rezeptdaten erfolgt"),
                    xml_request = table.Column<string>(type: "TEXT", nullable: false, comment: "Original XML-Request der Apotheke (nur Rezept-XML) - zur Weiterleitung ins ARZ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_senderezepte_erezept_daten_pkey", x => x.id_senderezepte_erezept_daten);
                    table.ForeignKey(
                        name: "er_senderezepte_erezept_daten_id_senderezepte_erezept",
                        column: x => x.id_senderezepte_erezept,
                        principalSchema: "daten",
                        principalTable: "er_senderezepte_erezept",
                        principalColumn: "id_senderezepte_erezept",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_erezept_status",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_erezept_status = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_senderezepte_erezept_statu_id_senderezepte_erezept_statu_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    id_senderezepte_erezept = table.Column<int>(type: "INTEGER", nullable: true),
                    erezept_id = table.Column<string>(type: "TEXT", maxLength: 22, nullable: true),
                    rezept_status = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true, defaultValueSql: "'VOR_PRUEFUNG'::character varying"),
                    rezept_check = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    status_abfrage_datum = table.Column<DateTime>(type: "date", nullable: true, comment: "Abfragedatum des Status zum Rezept"),
                    status_abfrage_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true, comment: "Abfragezeit des Status zum Rezept"),
                    abrechen_status = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true, defaultValueSql: "'VOR_PRUEFUNG'::character varying", comment: "Interner Status - enthält immer das Prüfergebnis"),
                    rz_abfrage_id = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true, comment: "ID mit der alle DS gekennzeichnet sind die innerhalb einer RCS Abfrage gesendet wurden")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_senderezepte_erezept_status_pkey", x => x.id_senderezepte_erezept_status);
                    table.ForeignKey(
                        name: "er_senderezepte_erezept_status_id_senderezepte_erezept",
                        column: x => x.id_senderezepte_erezept,
                        principalSchema: "daten",
                        principalTable: "er_senderezepte_erezept",
                        principalColumn: "id_senderezepte_erezept",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_erezept_statusinfo",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_erezept_statusinfo = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_senderezepte_erezept_statu_id_senderezepte_erezept_stat_seq1'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    id_senderezepte_erezept = table.Column<int>(type: "INTEGER", nullable: true),
                    fcode = table.Column<string>(type: "TEXT", maxLength: 4, nullable: true),
                    fstatus = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    fkommentar = table.Column<string>(type: "TEXT", nullable: true),
                    ftcode = table.Column<string>(type: "TEXT", maxLength: 3, nullable: true),
                    posnr = table.Column<short>(type: "INTEGER", nullable: true),
                    fkurztext = table.Column<string>(type: "TEXT", nullable: true),
                    regel_nr = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    regel_treffer_code = table.Column<string>(type: "TEXT", maxLength: 7, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_senderezepte_erezept_statusinfo_pkey", x => x.id_senderezepte_erezept_statusinfo);
                    table.ForeignKey(
                        name: "er_senderezepte_erezept_statusinfo_id_senderezepte_erezept",
                        column: x => x.id_senderezepte_erezept,
                        principalSchema: "daten",
                        principalTable: "er_senderezepte_erezept",
                        principalColumn: "id_senderezepte_erezept",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_prezept_daten",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_prezept_daten = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_senderezepte_prezept = table.Column<int>(type: "INTEGER", nullable: true),
                    rezept_uuid = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false, comment: "Eindeutiger Rezept - Universal Unique Identifier (UUID)"),
                    transfer_arz = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false", comment: "Bestätigung vom ARZ - Transfer der Rezeptdaten erfolgt"),
                    xml_request = table.Column<string>(type: "TEXT", nullable: false, comment: "Original XML-Request der Apotheke (nur Rezept-XML) - zur Weiterleitung ins ARZ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_senderezepte_prezept_daten_pkey", x => x.id_senderezepte_prezept_daten);
                    table.ForeignKey(
                        name: "er_senderezepte_prezept_daten_id_senderezepte_prezept",
                        column: x => x.id_senderezepte_prezept,
                        principalSchema: "daten",
                        principalTable: "er_senderezepte_prezept",
                        principalColumn: "id_senderezepte_prezept",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_prezept_pcharge",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_prezept_pcharge = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_senderezepte_prezept_pchar_id_senderezepte_prezept_pchar_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    id_senderezepte_prezept = table.Column<int>(type: "INTEGER", nullable: true),
                    hersteller_schluessel = table.Column<short>(type: "INTEGER", nullable: true, comment: "herstellerSchluessel - Werte 1|2|3|4"),
                    hersteller_nr = table.Column<long>(type: "INTEGER", nullable: true, comment: "herstellerNr - IK der Apotheke"),
                    herstellungs_datum = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true, comment: "herstellungsDatum Format 2011-08-19T11:37:04.000"),
                    chargen_nr = table.Column<short>(type: "INTEGER", nullable: true, comment: "chargenNr - Werte 1-99"),
                    anzahl_applikationen = table.Column<short>(type: "INTEGER", nullable: true, comment: "anzahlApplikationen - Werte 1-99")
                },
                constraints: table =>
                {
                    table.PrimaryKey("id_senderezepte_prez_pcharge_pkey", x => x.id_senderezepte_prezept_pcharge);
                    table.ForeignKey(
                        name: "er_senderezepte_prezept_pcharge_id_srez_prez_fkey",
                        column: x => x.id_senderezepte_prezept,
                        principalSchema: "daten",
                        principalTable: "er_senderezepte_prezept",
                        principalColumn: "id_senderezepte_prezept",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_prezept_status",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_prezept_status = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_senderezepte_prezept_statu_id_senderezepte_prezept_stat_seq1'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    id_senderezepte_prezept = table.Column<int>(type: "INTEGER", nullable: true),
                    transaktions_nummer = table.Column<long>(type: "INTEGER", nullable: true),
                    rezept_status = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true, defaultValueSql: "'VOR_PRUEFUNG'::character varying"),
                    rezept_check = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "false"),
                    status_abfrage_datum = table.Column<DateTime>(type: "date", nullable: true, comment: "Abfragedatum des Status zum Rezept"),
                    status_abfrage_zeit = table.Column<TimeSpan>(type: "time without time zone", nullable: true, comment: "Abfragezeit des Status zum Rezept"),
                    abrechen_status = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true, defaultValueSql: "'VOR_PRUEFUNG'::character varying", comment: "Interner Status - enthält immer das Prüfergebnis"),
                    rz_abfrage_id = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true, comment: "ID mit der alle DS gekennzeichnet sind die innerhalb einer RCS Abfrage gesendet wurden")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_senderezepte_prezept_status_pkey", x => x.id_senderezepte_prezept_status);
                    table.ForeignKey(
                        name: "er_senderezepte_prezept_status_id_senderezepte_prezept",
                        column: x => x.id_senderezepte_prezept,
                        principalSchema: "daten",
                        principalTable: "er_senderezepte_prezept",
                        principalColumn: "id_senderezepte_prezept",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_prezept_statusinfo",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_prezept_statusinfo = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_senderezepte_prezept_statu_id_senderezepte_prezept_statu_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    id_senderezepte_prezept = table.Column<int>(type: "INTEGER", nullable: true),
                    fcode = table.Column<string>(type: "TEXT", maxLength: 4, nullable: true),
                    fstatus = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    fkommentar = table.Column<string>(type: "TEXT", nullable: true),
                    ftcode = table.Column<string>(type: "TEXT", maxLength: 3, nullable: true),
                    posnr = table.Column<short>(type: "INTEGER", nullable: true),
                    fkurztext = table.Column<string>(type: "TEXT", nullable: true),
                    regel_nr = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    regel_treffer_code = table.Column<string>(type: "TEXT", maxLength: 7, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_senderezepte_prezept_statusinfo_pkey", x => x.id_senderezepte_prezept_statusinfo);
                    table.ForeignKey(
                        name: "er_senderezepte_prezept_statusinfo_id_senderezepte_prezept",
                        column: x => x.id_senderezepte_prezept,
                        principalSchema: "daten",
                        principalTable: "er_senderezepte_prezept",
                        principalColumn: "id_senderezepte_prezept",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "er_senderezepte_prezept_pcharge_pwirkstoff",
                schema: "daten",
                columns: table => new
                {
                    id_senderezepte_prezept_pwirkstoff = table.Column<int>(type: "INTEGER", nullable: false, defaultValueSql: "nextval('daten.er_senderezepte_prezept_pchar_id_senderezepte_prezept_pwirk_seq'::regclass)")
                        .Annotation("Sqlite:Autoincrement", true),
                    id_senderezepte_prezept_pcharge = table.Column<int>(type: "INTEGER", nullable: true),
                    pzn = table.Column<long>(type: "INTEGER", nullable: true, comment: "pzn"),
                    p_pos_nr = table.Column<short>(type: "INTEGER", nullable: true, comment: "pPosNr"),
                    faktor = table.Column<int>(type: "INTEGER", nullable: true, comment: "faktor"),
                    faktor_kennzeichen = table.Column<string>(type: "TEXT", maxLength: 2, nullable: true, comment: "faktorKennzeichen"),
                    taxe = table.Column<decimal>(type: "TEXT", precision: 11, scale: 2, nullable: true, defaultValueSql: "0", comment: "taxe"),
                    preis_kennzeichen = table.Column<string>(type: "TEXT", maxLength: 2, nullable: true, comment: "preisKennzeichen"),
                    wirkstoff_name = table.Column<string>(type: "TEXT", maxLength: 130, nullable: true, comment: "wirkstoffName"),
                    notiz = table.Column<string>(type: "TEXT", maxLength: 130, nullable: true, comment: "notiz")
                },
                constraints: table =>
                {
                    table.PrimaryKey("er_senderezepte_prezept_pcharge_pwirkstoff_pkey", x => x.id_senderezepte_prezept_pwirkstoff);
                    table.ForeignKey(
                        name: "er_senderezepte_prez_pcharge_pwirk_id_senderezepte_prez_pch_fke",
                        column: x => x.id_senderezepte_prezept_pcharge,
                        principalSchema: "daten",
                        principalTable: "er_senderezepte_prezept_pcharge",
                        principalColumn: "id_senderezepte_prezept_pcharge",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "idx_er_abda_pzn_gueltigabbis_20210401",
                schema: "daten",
                table: "er_abda",
                columns: new[] { "pzn", "gueltig_ab", "gueltig_bis" });

            migrationBuilder.CreateIndex(
                name: "idx_er_abda_us_pzn_gueltigabbis_20210401",
                schema: "daten",
                table: "er_abda_us",
                columns: new[] { "pzn", "gueltig_ab", "gueltig_bis" });

            migrationBuilder.CreateIndex(
                name: "idx_er_apotheke_apo_ik_nr",
                schema: "daten",
                table: "er_apotheke",
                column: "apo_ik_nr");

            migrationBuilder.CreateIndex(
                name: "idx_er_apotheke_apo_int_nr",
                schema: "daten",
                table: "er_apotheke",
                column: "apo_int_nr");

            migrationBuilder.CreateIndex(
                name: "IX_er_prueferezept_emuster16_artikel_id_prueferezept_emuster16",
                schema: "daten",
                table: "er_prueferezept_emuster16_artikel",
                column: "id_prueferezept_emuster16");

            migrationBuilder.CreateIndex(
                name: "IX_er_prueferezept_emuster16_status_id_prueferezept_emuster16",
                schema: "daten",
                table: "er_prueferezept_emuster16_status",
                column: "id_prueferezept_emuster16");

            migrationBuilder.CreateIndex(
                name: "IX_er_prueferezept_emuster16_statusinfo_id_prueferezept_emuster16",
                schema: "daten",
                table: "er_prueferezept_emuster16_statusinfo",
                column: "id_prueferezept_emuster16");

            migrationBuilder.CreateIndex(
                name: "IX_er_prueferezept_erezept_lieferid_id_prueferezept_header",
                schema: "daten",
                table: "er_prueferezept_erezept_lieferid",
                column: "id_prueferezept_header");

            migrationBuilder.CreateIndex(
                name: "IX_er_prueferezept_erezept_statusinfo_id_prueferezept_erezept",
                schema: "daten",
                table: "er_prueferezept_erezept_statusinfo",
                column: "id_prueferezept_erezept");

            migrationBuilder.CreateIndex(
                name: "idx_er_rabatt_gruppe_keygruppe_gueltigabbis_20210401",
                schema: "daten",
                table: "er_rabatt_gruppe",
                columns: new[] { "key_gruppe", "gueltig_ab", "gueltig_bis" });

            migrationBuilder.CreateIndex(
                name: "idx_er_rabatt_indika_indikation_pzn_20210401",
                schema: "daten",
                table: "er_rabatt_indika",
                columns: new[] { "indikation", "pzn" });

            migrationBuilder.CreateIndex(
                name: "idx_er_rabatt_indika_pzn_gueltigabbis_20210401",
                schema: "daten",
                table: "er_rabatt_indika",
                columns: new[] { "pzn", "gueltig_ab", "gueltig_bis" });

            migrationBuilder.CreateIndex(
                name: "idx_er_rabatt_kasse_keygruppe_gueltigabbis_20210401",
                schema: "daten",
                table: "er_rabatt_kasse",
                columns: new[] { "key_gruppe", "gueltig_ab", "gueltig_bis" });

            migrationBuilder.CreateIndex(
                name: "idx_er_rabatt_pzn_arzneipzn_keygruppe_gueltigabbis_20210401",
                schema: "daten",
                table: "er_rabatt_pzn",
                columns: new[] { "arznei_pzn", "key_gruppe", "gueltig_ab", "gueltig_bis" });

            migrationBuilder.CreateIndex(
                name: "idx_er_rabatt_wirkstoff_pzn_gueltigabbis_20210401",
                schema: "daten",
                table: "er_rabatt_wirkstoff",
                columns: new[] { "pzn", "gueltig_ab", "gueltig_bis" });

            migrationBuilder.CreateIndex(
                name: "er_sec_access_fiverx_login_id_key",
                schema: "daten",
                table: "er_sec_access_fiverx",
                column: "login_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idx_er_sec_access_fiverx_login_id",
                schema: "daten",
                table: "er_sec_access_fiverx",
                column: "login_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_er_sec_access_fiverx_id_apotheke",
                schema: "daten",
                table: "er_sec_access_fiverx",
                column: "id_apotheke");

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_apoik",
                schema: "daten",
                table: "er_senderezepte_emuster16",
                column: "apo_ik_nr");

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_em16_muster16_id",
                schema: "daten",
                table: "er_senderezepte_emuster16",
                columns: new[] { "muster16_id", "rz_liefer_id" });

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_em16_rz_liefer_id",
                schema: "daten",
                table: "er_senderezepte_emuster16",
                columns: new[] { "rz_liefer_id", "muster16_id" });

            migrationBuilder.CreateIndex(
                name: "IX_er_senderezepte_emuster16_id_senderezepte_header",
                schema: "daten",
                table: "er_senderezepte_emuster16",
                column: "id_senderezepte_header");

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_em16_artikel_id",
                schema: "daten",
                table: "er_senderezepte_emuster16_artikel",
                column: "id_senderezepte_emuster16");

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_em16_daten_id",
                schema: "daten",
                table: "er_senderezepte_emuster16_daten",
                column: "id_senderezepte_emuster16");

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_em16_stat_idrezem16",
                schema: "daten",
                table: "er_senderezepte_emuster16_status",
                columns: new[] { "id_senderezepte_emuster16", "muster16_id", "rezept_status" });

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_em16_stinfo_id",
                schema: "daten",
                table: "er_senderezepte_emuster16_statusinfo",
                column: "id_senderezepte_emuster16");

            migrationBuilder.CreateIndex(
                name: "IX_er_senderezepte_erezept_id_senderezepte_header",
                schema: "daten",
                table: "er_senderezepte_erezept",
                column: "id_senderezepte_header");

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_erez_daten_id",
                schema: "daten",
                table: "er_senderezepte_erezept_daten",
                column: "id_senderezepte_erezept");

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_erez_stat_idrezerez",
                schema: "daten",
                table: "er_senderezepte_erezept_status",
                columns: new[] { "id_senderezepte_erezept", "erezept_id", "rezept_status" });

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_erez_stinfo_id",
                schema: "daten",
                table: "er_senderezepte_erezept_statusinfo",
                column: "id_senderezepte_erezept");

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_head_apo_int_nr",
                schema: "daten",
                table: "er_senderezepte_header",
                columns: new[] { "apo_int_nr", "rz_liefer_id" });

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_head_rz_liefer_id",
                schema: "daten",
                table: "er_senderezepte_header",
                columns: new[] { "rz_liefer_id", "apo_int_nr" });

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_header_daten_id",
                schema: "daten",
                table: "er_senderezepte_header_daten",
                column: "id_senderezepte_header");

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_prez_rz_liefer_id",
                schema: "daten",
                table: "er_senderezepte_prezept",
                columns: new[] { "rz_liefer_id", "transaktions_nummer" });

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_prez_transaktionsnummer",
                schema: "daten",
                table: "er_senderezepte_prezept",
                columns: new[] { "transaktions_nummer", "rz_liefer_id" });

            migrationBuilder.CreateIndex(
                name: "IX_er_senderezepte_prezept_id_senderezepte_header",
                schema: "daten",
                table: "er_senderezepte_prezept",
                column: "id_senderezepte_header");

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_prez_daten_id",
                schema: "daten",
                table: "er_senderezepte_prezept_daten",
                column: "id_senderezepte_prezept");

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_prez_pch_prezid",
                schema: "daten",
                table: "er_senderezepte_prezept_pcharge",
                column: "id_senderezepte_prezept");

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_prez_pch_pwirk_pchid",
                schema: "daten",
                table: "er_senderezepte_prezept_pcharge_pwirkstoff",
                column: "id_senderezepte_prezept_pcharge");

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_prez_stat_idrezprez",
                schema: "daten",
                table: "er_senderezepte_prezept_status",
                columns: new[] { "id_senderezepte_prezept", "transaktions_nummer", "rezept_status" });

            migrationBuilder.CreateIndex(
                name: "idx_er_sendrez_prez_stinfo_id",
                schema: "daten",
                table: "er_senderezepte_prezept_statusinfo",
                column: "id_senderezepte_prezept");

            migrationBuilder.CreateIndex(
                name: "idx_er_sonder_pzn_sonderpzn_gueltigabbis_20191024",
                schema: "daten",
                table: "er_sonder_pzn",
                columns: new[] { "sonder_pzn", "gueltig_ab", "gueltig_bis" });

            migrationBuilder.CreateIndex(
                name: "idx_uc_mucnr_sucnr",
                schema: "daten",
                table: "er_usecase",
                columns: new[] { "main_uc_nr", "sub_uc_nr" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "er_abda",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_abda_import",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_abda_temp",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_abda_us",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_abda_us_temp",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_fiverx_version",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_prueferezept_emuster16_artikel",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_prueferezept_emuster16_status",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_prueferezept_emuster16_statusinfo",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_prueferezept_erezept_lieferid",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_prueferezept_erezept_statusinfo",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_rabatt_gruppe",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_rabatt_gruppe_temp",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_rabatt_indika",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_rabatt_indika_temp",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_rabatt_kasse",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_rabatt_kasse_temp",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_rabatt_pzn",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_rabatt_pzn_temp",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_rabatt_wirkstoff",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_rabatt_wirkstoff_temp",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_sec_access_fiverx",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_emuster16_artikel",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_emuster16_daten",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_emuster16_status",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_emuster16_statusinfo",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_erezept_daten",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_erezept_status",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_erezept_statusinfo",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_header_daten",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_prezept_daten",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_prezept_pcharge_pwirkstoff",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_prezept_status",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_prezept_statusinfo",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_sonder_pzn",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_usecase",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_prueferezept_emuster16",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_prueferezept_header",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_prueferezept_erezept",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_apotheke",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_emuster16",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_erezept",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_prezept_pcharge",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_prezept",
                schema: "daten");

            migrationBuilder.DropTable(
                name: "er_senderezepte_header",
                schema: "daten");

            migrationBuilder.DropSequence(
                name: "er_fiverx_schema_id_fiverx_schema_seq",
                schema: "daten");

            migrationBuilder.DropSequence(
                name: "er_senderezepte_prezept_pwirk_id_senderezepte_prezept_pwirk_seq",
                schema: "daten");
        }
    }
}
