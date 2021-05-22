using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ArzTiServer.Models
{
    public partial class ArzDBContext : DbContext
    {
        public ArzDBContext()
        {
        }

        public ArzDBContext(DbContextOptions<ArzDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ErAbdaImport> ErAbdaImports { get; set; }
        public virtual DbSet<ErAbdaTemp> ErAbdaTemps { get; set; }
        public virtual DbSet<ErAbdaU> ErAbdaUs { get; set; }
        public virtual DbSet<ErAbdaUsTemp> ErAbdaUsTemps { get; set; }
        public virtual DbSet<ErAbdum> ErAbda { get; set; }
        public virtual DbSet<ErApotheke> ErApothekes { get; set; }
        public virtual DbSet<ErFiverxVersion> ErFiverxVersions { get; set; }
        public virtual DbSet<ErPrueferezeptEmuster16> ErPrueferezeptEmuster16s { get; set; }
        public virtual DbSet<ErPrueferezeptEmuster16Artikel> ErPrueferezeptEmuster16Artikels { get; set; }
        public virtual DbSet<ErPrueferezeptEmuster16Status> ErPrueferezeptEmuster16Statuses { get; set; }
        public virtual DbSet<ErPrueferezeptEmuster16Statusinfo> ErPrueferezeptEmuster16Statusinfos { get; set; }
        public virtual DbSet<ErPrueferezeptErezept> ErPrueferezeptErezepts { get; set; }
        public virtual DbSet<ErPrueferezeptErezeptLieferid> ErPrueferezeptErezeptLieferids { get; set; }
        public virtual DbSet<ErPrueferezeptErezeptStatusinfo> ErPrueferezeptErezeptStatusinfos { get; set; }
        public virtual DbSet<ErPrueferezeptHeader> ErPrueferezeptHeaders { get; set; }
        public virtual DbSet<ErRabattGruppe> ErRabattGruppes { get; set; }
        public virtual DbSet<ErRabattGruppeTemp> ErRabattGruppeTemps { get; set; }
        public virtual DbSet<ErRabattIndika> ErRabattIndikas { get; set; }
        public virtual DbSet<ErRabattIndikaTemp> ErRabattIndikaTemps { get; set; }
        public virtual DbSet<ErRabattKasse> ErRabattKasses { get; set; }
        public virtual DbSet<ErRabattKasseTemp> ErRabattKasseTemps { get; set; }
        public virtual DbSet<ErRabattPzn> ErRabattPzns { get; set; }
        public virtual DbSet<ErRabattPznTemp> ErRabattPznTemps { get; set; }
        public virtual DbSet<ErRabattWirkstoff> ErRabattWirkstoffs { get; set; }
        public virtual DbSet<ErRabattWirkstoffTemp> ErRabattWirkstoffTemps { get; set; }
        public virtual DbSet<ErSecAccessFiverx> ErSecAccessFiverxes { get; set; }
        public virtual DbSet<ErSenderezepteEmuster16> ErSenderezepteEmuster16s { get; set; }
        public virtual DbSet<ErSenderezepteEmuster16Artikel> ErSenderezepteEmuster16Artikels { get; set; }
        public virtual DbSet<ErSenderezepteEmuster16Daten> ErSenderezepteEmuster16Datens { get; set; }
        public virtual DbSet<ErSenderezepteEmuster16Status> ErSenderezepteEmuster16Statuses { get; set; }
        public virtual DbSet<ErSenderezepteEmuster16Statusinfo> ErSenderezepteEmuster16Statusinfos { get; set; }
        public virtual DbSet<ErSenderezepteErezept> ErSenderezepteErezepts { get; set; }
        public virtual DbSet<ErSenderezepteErezeptDaten> ErSenderezepteErezeptDatens { get; set; }
        public virtual DbSet<ErSenderezepteErezeptStatus> ErSenderezepteErezeptStatuses { get; set; }
        public virtual DbSet<ErSenderezepteErezeptStatusinfo> ErSenderezepteErezeptStatusinfos { get; set; }
        public virtual DbSet<ErSenderezepteHeader> ErSenderezepteHeaders { get; set; }
        public virtual DbSet<ErSenderezepteHeaderDaten> ErSenderezepteHeaderDatens { get; set; }
        public virtual DbSet<ErSenderezeptePrezept> ErSenderezeptePrezepts { get; set; }
        public virtual DbSet<ErSenderezeptePrezeptDaten> ErSenderezeptePrezeptDatens { get; set; }
        public virtual DbSet<ErSenderezeptePrezeptPcharge> ErSenderezeptePrezeptPcharges { get; set; }
        public virtual DbSet<ErSenderezeptePrezeptPchargePwirkstoff> ErSenderezeptePrezeptPchargePwirkstoffs { get; set; }
        public virtual DbSet<ErSenderezeptePrezeptStatus> ErSenderezeptePrezeptStatuses { get; set; }
        public virtual DbSet<ErSenderezeptePrezeptStatusinfo> ErSenderezeptePrezeptStatusinfos { get; set; }
        public virtual DbSet<ErSonderPzn> ErSonderPzns { get; set; }
        public virtual DbSet<ErUsecase> ErUsecases { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlite("Data Source=CustomerDB.db;");
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseNpgsql("Username=dbuser;Password=pass1234;Server=opipc;Port=5432;Database=ArzDB;Integrated Security=true;Pooling=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.utf8");

            modelBuilder.Entity<ErAbdaImport>(entity =>
            {
                entity.HasKey(e => e.IdAbdaImport)
                    .HasName("er_abda_import_pkey");

                entity.ToTable("er_abda_import", "apoti");

                entity.Property(e => e.IdAbdaImport).HasColumnName("id_abda_import");

                entity.Property(e => e.AbsenderKennung)
                    .HasMaxLength(3)
                    .HasColumnName("absender_kennung");

                entity.Property(e => e.AnzahlTeildateien).HasColumnName("anzahl_teildateien");

                entity.Property(e => e.Datei)
                    .HasMaxLength(100)
                    .HasColumnName("datei");

                entity.Property(e => e.DateiErweiterung)
                    .HasMaxLength(10)
                    .HasColumnName("datei_erweiterung");

                entity.Property(e => e.DateiGroesse)
                    .HasColumnName("datei_groesse")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DateiType)
                    .HasMaxLength(1)
                    .HasColumnName("datei_type")
                    .HasComment("L-löschen - N-neu");

                entity.Property(e => e.Impkenner)
                    .HasMaxLength(30)
                    .HasColumnName("impkenner")
                    .HasComment("Identifiziert DS die durch diese Datei eingefügt wurden");

                entity.Property(e => e.Importiert)
                    .HasColumnName("importiert")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ImportiertDatum)
                    .HasColumnType("date")
                    .HasColumnName("importiert_datum");

                entity.Property(e => e.ImportiertDsFehler)
                    .HasColumnName("importiert_ds_fehler")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImportiertDsGesamt).HasColumnName("importiert_ds_gesamt");

                entity.Property(e => e.ImportiertDsImportiert)
                    .HasColumnName("importiert_ds_importiert")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImportiertTeildatei).HasColumnName("importiert_teildatei");

                entity.Property(e => e.ImportiertZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("importiert_zeit");

                entity.Property(e => e.Konvertiert)
                    .HasColumnName("konvertiert")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.KonvertiertDatum)
                    .HasColumnType("date")
                    .HasColumnName("konvertiert_datum");

                entity.Property(e => e.KonvertiertDsFehler)
                    .HasColumnName("konvertiert_ds_fehler")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KonvertiertDsGesamt).HasColumnName("konvertiert_ds_gesamt");

                entity.Property(e => e.KonvertiertDsKonvertiert)
                    .HasColumnName("konvertiert_ds_konvertiert")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KonvertiertZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("konvertiert_zeit");

                entity.Property(e => e.MandantKennung)
                    .HasMaxLength(4)
                    .HasColumnName("mandant_kennung");

                entity.Property(e => e.MandantType)
                    .HasMaxLength(4)
                    .HasColumnName("mandant_type");

                entity.Property(e => e.Nummer).HasColumnName("nummer");

                entity.Property(e => e.Schnittstelle)
                    .HasMaxLength(15)
                    .HasColumnName("schnittstelle");

                entity.Property(e => e.Uebertragungszaehler)
                    .HasMaxLength(3)
                    .HasColumnName("uebertragungszaehler");

                entity.Property(e => e.Zeitstempel)
                    .HasMaxLength(8)
                    .HasColumnName("zeitstempel");

                entity.Property(e => e.Zusatzdatei).HasColumnName("zusatzdatei");
            });

            modelBuilder.Entity<ErAbdaTemp>(entity =>
            {
                entity.HasKey(e => e.IdAbda)
                    .HasName("er_abda_pkey");

                entity.ToTable("er_abda_temp", "apoti");

                entity.Property(e => e.IdAbda).HasColumnName("id_abda");

                entity.Property(e => e.Abgabeschluessel).HasColumnName("abgabeschluessel");

                entity.Property(e => e.Ampvamg).HasColumnName("ampvamg");

                entity.Property(e => e.Ampvsgb).HasColumnName("ampvsgb");

                entity.Property(e => e.Anbieter).HasColumnName("anbieter");

                entity.Property(e => e.ApoEkPreis).HasColumnName("apo_ek_preis");

                entity.Property(e => e.ApoRabatt).HasColumnName("apo_rabatt");

                entity.Property(e => e.ApoVkOriginal).HasColumnName("apo_vk_original");

                entity.Property(e => e.ApoVkPEmpf).HasColumnName("apo_vk_p_empf");

                entity.Property(e => e.ApoVkPreis).HasColumnName("apo_vk_preis");

                entity.Property(e => e.Apothekenpflicht).HasColumnName("apothekenpflicht");

                entity.Property(e => e.AusErsetzung)
                    .HasColumnName("aus_ersetzung")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Betaeubungsmittel).HasColumnName("betaeubungsmittel");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(255)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.Biotech)
                    .HasColumnName("biotech")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CalcRabatt).HasColumnName("calc_rabatt");

                entity.Property(e => e.CheckPzn).HasColumnName("check_pzn");

                entity.Property(e => e.Darreichungsform)
                    .HasMaxLength(20)
                    .HasColumnName("darreichungsform");

                entity.Property(e => e.EigenePzn).HasColumnName("eigene_pzn");

                entity.Property(e => e.ErstFaehigFam).HasColumnName("erst_faehig_fam");

                entity.Property(e => e.Fertigarzneimittel).HasColumnName("fertigarzneimittel");

                entity.Property(e => e.Festbetrag).HasColumnName("festbetrag");

                entity.Property(e => e.GhRabatt).HasColumnName("gh_rabatt");

                entity.Property(e => e.GhRabattBetr).HasColumnName("gh_rabatt_betr");

                entity.Property(e => e.GrNr01).HasColumnName("gr_nr_01");

                entity.Property(e => e.GueltigAb)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_ab");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.Hilfsmittel).HasColumnName("hilfsmittel");

                entity.Property(e => e.HimiZuVerb).HasColumnName("himi_zu_verb");

                entity.Property(e => e.HmPositionsNr).HasColumnName("hm_positions_nr");

                entity.Property(e => e.HsRabatt).HasColumnName("hs_rabatt");

                entity.Property(e => e.HsRabattBetrag).HasColumnName("hs_rabatt_betrag");

                entity.Property(e => e.HsVkPreis).HasColumnName("hs_vk_preis");

                entity.Property(e => e.Impfstoff).HasColumnName("impfstoff");

                entity.Property(e => e.Import).HasColumnName("import");

                entity.Property(e => e.ImportMoeglich).HasColumnName("import_moeglich");

                entity.Property(e => e.Importkenner)
                    .HasMaxLength(30)
                    .HasColumnName("importkenner");

                entity.Property(e => e.IndikationsNr)
                    .HasMaxLength(20)
                    .HasColumnName("indikations_nr");

                entity.Property(e => e.Invalid)
                    .HasColumnType("date")
                    .HasColumnName("invalid");

                entity.Property(e => e.KannHilfsmittel).HasColumnName("kann_hilfsmittel");

                entity.Property(e => e.Klinikpackung).HasColumnName("klinikpackung");

                entity.Property(e => e.LifeStyle).HasColumnName("life_style");

                entity.Property(e => e.Medizinprodukt).HasColumnName("medizinprodukt");

                entity.Property(e => e.Menge)
                    .HasMaxLength(10)
                    .HasColumnName("menge");

                entity.Property(e => e.Mengeneinheit)
                    .HasMaxLength(10)
                    .HasColumnName("mengeneinheit");

                entity.Property(e => e.MwstSatz).HasColumnName("mwst_satz");

                entity.Property(e => e.Negativliste).HasColumnName("negativliste");

                entity.Property(e => e.Normpackung).HasColumnName("normpackung");

                entity.Property(e => e.Packungsgroesse).HasColumnName("packungsgroesse");

                entity.Property(e => e.PlusVArt).HasColumnName("plus_v_art");

                entity.Property(e => e.Preiswert).HasColumnName("preiswert");

                entity.Property(e => e.Pzn).HasColumnName("pzn");

                entity.Property(e => e.PznOld).HasColumnName("pzn_old");

                entity.Property(e => e.PznOriginal).HasColumnName("pzn_original");

                entity.Property(e => e.RabApo).HasColumnName("rab_apo");

                entity.Property(e => e.RabVertrag).HasColumnName("rab_vertrag");

                entity.Property(e => e.RabWAnbieter).HasColumnName("rab_w_anbieter");

                entity.Property(e => e.RabWGenerika).HasColumnName("rab_w_generika");

                entity.Property(e => e.RabWImpfstof).HasColumnName("rab_w_impfstof");

                entity.Property(e => e.RabWPreisMor).HasColumnName("rab_w_preis_mor");

                entity.Property(e => e.SteuerPzn).HasColumnName("steuer_pzn");

                entity.Property(e => e.TierAm).HasColumnName("tier_am");

                entity.Property(e => e.VeMenge).HasColumnName("ve_menge");

                entity.Property(e => e.Verkehrsstatus).HasColumnName("verkehrsstatus");

                entity.Property(e => e.Verschreibungspflicht).HasColumnName("verschreibungspflicht");

                entity.Property(e => e.Warengruppenschluessel)
                    .HasMaxLength(20)
                    .HasColumnName("warengruppenschluessel");

                entity.Property(e => e.ZuzFreiFeb).HasColumnName("zuz_frei_feb");

                entity.Property(e => e.ZuzFreiTstr).HasColumnName("zuz_frei_tstr");

                entity.Property(e => e.Zuzahlungskennzeichen).HasColumnName("zuzahlungskennzeichen");
            });

            modelBuilder.Entity<ErAbdaU>(entity =>
            {
                entity.HasKey(e => e.IdAbdaUs)
                    .HasName("er_abda_us_pkey");

                entity.ToTable("er_abda_us", "apoti");

                entity.HasIndex(e => new { e.Pzn, e.GueltigAb, e.GueltigBis }, "idx_er_abda_us_pzn_gueltigabbis_20210401");

                entity.Property(e => e.IdAbdaUs)
                    .HasColumnName("id_abda_us")
                    .HasDefaultValueSql("nextval('daten.er_abda_us_temp_id_abda_us_seq'::regclass)");

                entity.Property(e => e.AusnahmeErsetzung)
                    .HasColumnName("ausnahme_ersetzung")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(255)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.Darreichungsform)
                    .HasMaxLength(20)
                    .HasColumnName("darreichungsform");

                entity.Property(e => e.GueltigAb)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_ab");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.ImportGruppeNr).HasColumnName("import_gruppe_nr");

                entity.Property(e => e.KeyAus).HasColumnName("key_aus");

                entity.Property(e => e.Menge)
                    .HasMaxLength(10)
                    .HasColumnName("menge");

                entity.Property(e => e.Mengeneinheit)
                    .HasMaxLength(10)
                    .HasColumnName("mengeneinheit");

                entity.Property(e => e.Pzn).HasColumnName("pzn");

                entity.Property(e => e.Warengruppe)
                    .HasMaxLength(10)
                    .HasColumnName("warengruppe");
            });

            modelBuilder.Entity<ErAbdaUsTemp>(entity =>
            {
                entity.HasKey(e => e.IdAbdaUs)
                    .HasName("er_abda_us_temp_pkey");

                entity.ToTable("er_abda_us_temp", "apoti");

                entity.Property(e => e.IdAbdaUs)
                    .HasColumnName("id_abda_us")
                    .HasDefaultValueSql("nextval('daten.er_abda_us_temp_id_abda_us_seq1'::regclass)");

                entity.Property(e => e.AusnahmeErsetzung)
                    .HasColumnName("ausnahme_ersetzung")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(255)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.Darreichungsform)
                    .HasMaxLength(20)
                    .HasColumnName("darreichungsform");

                entity.Property(e => e.GueltigAb)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_ab");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.ImportGruppeNr).HasColumnName("import_gruppe_nr");

                entity.Property(e => e.KeyAus).HasColumnName("key_aus");

                entity.Property(e => e.Menge)
                    .HasMaxLength(10)
                    .HasColumnName("menge");

                entity.Property(e => e.Mengeneinheit)
                    .HasMaxLength(10)
                    .HasColumnName("mengeneinheit");

                entity.Property(e => e.Pzn).HasColumnName("pzn");

                entity.Property(e => e.Warengruppe)
                    .HasMaxLength(10)
                    .HasColumnName("warengruppe");
            });

            modelBuilder.Entity<ErAbdum>(entity =>
            {
                entity.HasKey(e => e.IdAbda)
                    .HasName("er_abda_temp_pkey");

                entity.ToTable("er_abda", "apoti");

                entity.HasIndex(e => new { e.Pzn, e.GueltigAb, e.GueltigBis }, "idx_er_abda_pzn_gueltigabbis_20210401");

                entity.Property(e => e.IdAbda)
                    .HasColumnName("id_abda")
                    .HasDefaultValueSql("nextval('daten.er_abda_temp_id_abda_seq1'::regclass)");

                entity.Property(e => e.Abgabeschluessel).HasColumnName("abgabeschluessel");

                entity.Property(e => e.Ampvamg).HasColumnName("ampvamg");

                entity.Property(e => e.Ampvsgb).HasColumnName("ampvsgb");

                entity.Property(e => e.Anbieter).HasColumnName("anbieter");

                entity.Property(e => e.ApoEkPreis).HasColumnName("apo_ek_preis");

                entity.Property(e => e.ApoRabatt).HasColumnName("apo_rabatt");

                entity.Property(e => e.ApoVkOriginal).HasColumnName("apo_vk_original");

                entity.Property(e => e.ApoVkPEmpf).HasColumnName("apo_vk_p_empf");

                entity.Property(e => e.ApoVkPreis).HasColumnName("apo_vk_preis");

                entity.Property(e => e.Apothekenpflicht).HasColumnName("apothekenpflicht");

                entity.Property(e => e.AusErsetzung)
                    .HasColumnName("aus_ersetzung")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Betaeubungsmittel).HasColumnName("betaeubungsmittel");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(255)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.Biotech)
                    .HasColumnName("biotech")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CalcRabatt).HasColumnName("calc_rabatt");

                entity.Property(e => e.CheckPzn).HasColumnName("check_pzn");

                entity.Property(e => e.Darreichungsform)
                    .HasMaxLength(20)
                    .HasColumnName("darreichungsform");

                entity.Property(e => e.EigenePzn).HasColumnName("eigene_pzn");

                entity.Property(e => e.ErstFaehigFam).HasColumnName("erst_faehig_fam");

                entity.Property(e => e.Fertigarzneimittel).HasColumnName("fertigarzneimittel");

                entity.Property(e => e.Festbetrag).HasColumnName("festbetrag");

                entity.Property(e => e.GhRabatt).HasColumnName("gh_rabatt");

                entity.Property(e => e.GhRabattBetr).HasColumnName("gh_rabatt_betr");

                entity.Property(e => e.GrNr01).HasColumnName("gr_nr_01");

                entity.Property(e => e.GueltigAb)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_ab");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.Hilfsmittel).HasColumnName("hilfsmittel");

                entity.Property(e => e.HimiZuVerb).HasColumnName("himi_zu_verb");

                entity.Property(e => e.HmPositionsNr).HasColumnName("hm_positions_nr");

                entity.Property(e => e.HsRabatt).HasColumnName("hs_rabatt");

                entity.Property(e => e.HsRabattBetrag).HasColumnName("hs_rabatt_betrag");

                entity.Property(e => e.HsVkPreis).HasColumnName("hs_vk_preis");

                entity.Property(e => e.Impfstoff).HasColumnName("impfstoff");

                entity.Property(e => e.Import).HasColumnName("import");

                entity.Property(e => e.ImportMoeglich).HasColumnName("import_moeglich");

                entity.Property(e => e.Importkenner)
                    .HasMaxLength(30)
                    .HasColumnName("importkenner");

                entity.Property(e => e.IndikationsNr)
                    .HasMaxLength(20)
                    .HasColumnName("indikations_nr");

                entity.Property(e => e.Invalid)
                    .HasColumnType("date")
                    .HasColumnName("invalid");

                entity.Property(e => e.KannHilfsmittel).HasColumnName("kann_hilfsmittel");

                entity.Property(e => e.Klinikpackung).HasColumnName("klinikpackung");

                entity.Property(e => e.LifeStyle).HasColumnName("life_style");

                entity.Property(e => e.Medizinprodukt).HasColumnName("medizinprodukt");

                entity.Property(e => e.Menge)
                    .HasMaxLength(10)
                    .HasColumnName("menge");

                entity.Property(e => e.Mengeneinheit)
                    .HasMaxLength(10)
                    .HasColumnName("mengeneinheit");

                entity.Property(e => e.MwstSatz).HasColumnName("mwst_satz");

                entity.Property(e => e.Negativliste).HasColumnName("negativliste");

                entity.Property(e => e.Normpackung).HasColumnName("normpackung");

                entity.Property(e => e.Packungsgroesse).HasColumnName("packungsgroesse");

                entity.Property(e => e.PlusVArt).HasColumnName("plus_v_art");

                entity.Property(e => e.Preiswert).HasColumnName("preiswert");

                entity.Property(e => e.Pzn).HasColumnName("pzn");

                entity.Property(e => e.PznOld).HasColumnName("pzn_old");

                entity.Property(e => e.PznOriginal).HasColumnName("pzn_original");

                entity.Property(e => e.RabApo).HasColumnName("rab_apo");

                entity.Property(e => e.RabVertrag).HasColumnName("rab_vertrag");

                entity.Property(e => e.RabWAnbieter).HasColumnName("rab_w_anbieter");

                entity.Property(e => e.RabWGenerika).HasColumnName("rab_w_generika");

                entity.Property(e => e.RabWImpfstof).HasColumnName("rab_w_impfstof");

                entity.Property(e => e.RabWPreisMor).HasColumnName("rab_w_preis_mor");

                entity.Property(e => e.SteuerPzn).HasColumnName("steuer_pzn");

                entity.Property(e => e.TierAm).HasColumnName("tier_am");

                entity.Property(e => e.VeMenge).HasColumnName("ve_menge");

                entity.Property(e => e.Verkehrsstatus).HasColumnName("verkehrsstatus");

                entity.Property(e => e.Verschreibungspflicht).HasColumnName("verschreibungspflicht");

                entity.Property(e => e.Warengruppenschluessel)
                    .HasMaxLength(20)
                    .HasColumnName("warengruppenschluessel");

                entity.Property(e => e.ZuzFreiFeb).HasColumnName("zuz_frei_feb");

                entity.Property(e => e.ZuzFreiTstr).HasColumnName("zuz_frei_tstr");

                entity.Property(e => e.Zuzahlungskennzeichen).HasColumnName("zuzahlungskennzeichen");
            });

            modelBuilder.Entity<ErApotheke>(entity =>
            {
                entity.HasKey(e => e.IdApotheke)
                    .HasName("apotheke_pkey");

                entity.ToTable("er_apotheke", "apoti");

                entity.HasIndex(e => e.ApoIkNr, "idx_er_apotheke_apo_ik_nr");

                entity.HasIndex(e => e.ApoIntNr, "idx_er_apotheke_apo_int_nr");

                entity.Property(e => e.IdApotheke).HasColumnName("id_apotheke");

                entity.Property(e => e.AenDatum)
                    .HasColumnType("date")
                    .HasColumnName("aen_datum");

                entity.Property(e => e.AenIdSecUser).HasColumnName("aen_id_sec_user");

                entity.Property(e => e.AenZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("aen_zeit");

                entity.Property(e => e.ApoIkNr).HasColumnName("apo_ik_nr");

                entity.Property(e => e.ApoIntNr).HasColumnName("apo_int_nr");

                entity.Property(e => e.ApothekeName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("apotheke_name");

                entity.Property(e => e.ApothekeNameZusatz)
                    .HasMaxLength(255)
                    .HasColumnName("apotheke_name_zusatz");

                entity.Property(e => e.Bemerkung).HasColumnName("bemerkung");

                entity.Property(e => e.Bundesland)
                    .HasMaxLength(255)
                    .HasColumnName("bundesland");

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .HasColumnName("fax");

                entity.Property(e => e.Filialapotheke)
                    .HasColumnName("filialapotheke")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Gesperrt)
                    .HasColumnName("gesperrt")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IdHauptapotheke)
                    .HasColumnName("id_hauptapotheke")
                    .HasDefaultValueSql("0")
                    .HasComment("ID der Hauptapotheke wenn dies eine Filialapotheke ist");

                entity.Property(e => e.IdHtAnrede)
                    .HasColumnName("id_ht_anrede")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdLeType)
                    .HasColumnName("id_le_type")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InhaberNachname)
                    .HasMaxLength(65)
                    .HasColumnName("inhaber_nachname");

                entity.Property(e => e.InhaberVorname)
                    .HasMaxLength(65)
                    .HasColumnName("inhaber_vorname");

                entity.Property(e => e.MandantType)
                    .HasMaxLength(4)
                    .HasColumnName("mandant_type")
                    .HasDefaultValueSql("'APO'::character varying")
                    .HasComment("APO - Apotheke\nHRST - Hersteller (Dienstleister)");

                entity.Property(e => e.Mobil)
                    .HasMaxLength(20)
                    .HasColumnName("mobil");

                entity.Property(e => e.Ort)
                    .HasMaxLength(45)
                    .HasColumnName("ort");

                entity.Property(e => e.Plz).HasColumnName("plz");

                entity.Property(e => e.SecLogin)
                    .HasColumnName("sec_login")
                    .HasDefaultValueSql("0")
                    .HasComment("Security-Login - 0-Keiner, 1-Feste-IP, 2-DynDNS URLs, ...");

                entity.Property(e => e.SecLoginNurApoUser)
                    .HasColumnName("sec_login_nur_apo_user")
                    .HasDefaultValueSql("false")
                    .HasComment("Seurity-Login nur für Apotheken-Benutzer - F-nein, T-ja");

                entity.Property(e => e.SecLoginWerte)
                    .HasMaxLength(580)
                    .HasColumnName("sec_login_werte")
                    .HasComment("Werte zum Security-Login");

                entity.Property(e => e.Strasse)
                    .HasMaxLength(45)
                    .HasColumnName("strasse");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(20)
                    .HasColumnName("telefon");
            });

            modelBuilder.Entity<ErFiverxVersion>(entity =>
            {
                entity.HasKey(e => e.IdFiverxVersion)
                    .HasName("er_fiverx_version_pkey");

                entity.ToTable("er_fiverx_version", "apoti");

                entity.Property(e => e.IdFiverxVersion)
                    .ValueGeneratedNever()
                    .HasColumnName("id_fiverx_version");

                entity.Property(e => e.Ablaufdatum)
                    .HasColumnType("date")
                    .HasColumnName("ablaufdatum")
                    .HasDefaultValueSql("'1000-01-01'::date")
                    .HasComment("grance Periode - Version wird unterstützt bis zu diesem Datum");

                entity.Property(e => e.FiverxVersion)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("fiverx_version");

                entity.Property(e => e.Schemadatei)
                    .HasMaxLength(45)
                    .HasColumnName("schemadatei");
            });

            modelBuilder.Entity<ErPrueferezeptEmuster16>(entity =>
            {
                entity.HasKey(e => e.IdPrueferezeptEmuster16)
                    .HasName("er_prueferezept_emuster16_pkey");

                entity.ToTable("er_prueferezept_emuster16", "apoti");

                entity.Property(e => e.IdPrueferezeptEmuster16).HasColumnName("id_prueferezept_emuster16");

                entity.Property(e => e.AbdaKassentyp)
                    .HasMaxLength(5)
                    .HasColumnName("abda_kassentyp")
                    .HasComment("kArt");

                entity.Property(e => e.Abgabedatum)
                    .HasColumnType("date")
                    .HasColumnName("abgabedatum")
                    .HasComment("abDatum");

                entity.Property(e => e.ApoIkNr).HasColumnName("apo_ik_nr");

                entity.Property(e => e.Arbeitsplatz)
                    .HasMaxLength(50)
                    .HasColumnName("arbeitsplatz")
                    .HasComment("arbPlatz");

                entity.Property(e => e.ArztNr)
                    .HasColumnName("arzt_nr")
                    .HasComment("laNr - Lebenslange Arzt-Nummer");

                entity.Property(e => e.AvsId)
                    .HasMaxLength(20)
                    .HasColumnName("avs_id");

                entity.Property(e => e.Bediener)
                    .HasMaxLength(50)
                    .HasColumnName("bediener");

                entity.Property(e => e.BegrPflicht)
                    .HasColumnName("begr_pflicht")
                    .HasDefaultValueSql("0")
                    .HasComment("bgrPfl");

                entity.Property(e => e.BetriebsstaettenNr)
                    .HasColumnName("betriebsstaetten_nr")
                    .HasComment("vrtrgsArztNr - Betriebsstättennummer oder Praxis-Nummer");

                entity.Property(e => e.Eigenanteil)
                    .HasPrecision(11, 2)
                    .HasColumnName("eigenanteil")
                    .HasDefaultValueSql("0")
                    .HasComment("eigBet");

                entity.Property(e => e.GesamtesBrutto)
                    .HasPrecision(11, 2)
                    .HasColumnName("gesamtes_brutto")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdPrueferezepteHeader).HasColumnName("id_prueferezepte_header");

                entity.Property(e => e.KkIkNr)
                    .HasColumnName("kk_ik_nr")
                    .HasComment("Krankenkassen-Ik der Versicherung");

                entity.Property(e => e.KkName)
                    .HasMaxLength(50)
                    .HasColumnName("kk_name")
                    .HasComment("kName");

                entity.Property(e => e.KkTyp)
                    .HasMaxLength(5)
                    .HasColumnName("kk_typ")
                    .HasComment("rTyp");

                entity.Property(e => e.KzArbeitsunfall)
                    .HasColumnName("kz_arbeitsunfall")
                    .HasDefaultValueSql("0")
                    .HasComment("aUnfall");

                entity.Property(e => e.KzBvg)
                    .HasColumnName("kz_bvg")
                    .HasDefaultValueSql("0")
                    .HasComment("bvg");

                entity.Property(e => e.KzGebuehrenFrei)
                    .HasColumnName("kz_gebuehren_frei")
                    .HasDefaultValueSql("0")
                    .HasComment("gebFrei");

                entity.Property(e => e.KzHilfsmittel)
                    .HasColumnName("kz_hilfsmittel")
                    .HasDefaultValueSql("0")
                    .HasComment("hilf");

                entity.Property(e => e.KzImpfstoff)
                    .HasColumnName("kz_impfstoff")
                    .HasDefaultValueSql("0")
                    .HasComment("impf");

                entity.Property(e => e.KzNoctu)
                    .HasColumnName("kz_noctu")
                    .HasDefaultValueSql("0")
                    .HasComment("noctu");

                entity.Property(e => e.KzSonstige)
                    .HasColumnName("kz_sonstige")
                    .HasDefaultValueSql("0")
                    .HasComment("sonstige");

                entity.Property(e => e.KzSprechstundenbedarf)
                    .HasColumnName("kz_sprechstundenbedarf")
                    .HasDefaultValueSql("0")
                    .HasComment("sprStBedarf");

                entity.Property(e => e.KzUnfall)
                    .HasColumnName("kz_unfall")
                    .HasDefaultValueSql("0")
                    .HasComment("unfall");

                entity.Property(e => e.Muster16Id).HasColumnName("muster16_id");

                entity.Property(e => e.PruefModus)
                    .HasMaxLength(20)
                    .HasColumnName("pruef_modus")
                    .HasComment("SYNCHRON oder ASYNCHRON");

                entity.Property(e => e.RezeptTyp)
                    .HasMaxLength(30)
                    .HasColumnName("rezept_typ")
                    .HasComment("Nur STANDARDREZEPT, BTM, SPRECHSTUNDENBEDARF");

                entity.Property(e => e.RzDatum)
                    .HasMaxLength(30)
                    .HasColumnName("rz_datum");

                entity.Property(e => e.RzLieferDatum)
                    .HasColumnType("date")
                    .HasColumnName("rz_liefer_datum");

                entity.Property(e => e.RzLieferId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("rz_liefer_id");

                entity.Property(e => e.RzLieferZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("rz_liefer_zeit");

                entity.Property(e => e.TFachinformation)
                    .HasColumnName("t_fachinformation")
                    .HasDefaultValueSql("0")
                    .HasComment("tFachinformation");

                entity.Property(e => e.TInLabel)
                    .HasColumnName("t_in_label")
                    .HasDefaultValueSql("0")
                    .HasComment("tInLabel");

                entity.Property(e => e.TOffLabel)
                    .HasColumnName("t_off_label")
                    .HasDefaultValueSql("0")
                    .HasComment("tOffLabel");

                entity.Property(e => e.TSicherheitsbestimmung)
                    .HasColumnName("t_sicherheitsbestimmung")
                    .HasDefaultValueSql("0")
                    .HasComment("tSicherheitsbestimmung");

                entity.Property(e => e.UnfallDatum)
                    .HasColumnType("date")
                    .HasColumnName("unfall_datum")
                    .HasComment("unfallTag");

                entity.Property(e => e.Verordnungsdatum)
                    .HasColumnType("date")
                    .HasColumnName("verordnungsdatum")
                    .HasComment("verDat - Ausstellungsdatum - Verordnungsdatum");

                entity.Property(e => e.VersichertenGeburtsdatum)
                    .HasColumnType("date")
                    .HasColumnName("versicherten_geburtsdatum")
                    .HasComment("vGeb");

                entity.Property(e => e.VersichertenName)
                    .HasMaxLength(50)
                    .HasColumnName("versicherten_name")
                    .HasComment("vName");

                entity.Property(e => e.VersichertenNummer)
                    .HasMaxLength(10)
                    .HasColumnName("versicherten_nummer")
                    .HasComment("vrsNr");

                entity.Property(e => e.VersichertenOrt)
                    .HasMaxLength(50)
                    .HasColumnName("versicherten_ort")
                    .HasComment("vOrt");

                entity.Property(e => e.VersichertenPlz)
                    .HasMaxLength(5)
                    .HasColumnName("versicherten_plz")
                    .HasComment("vPlz");

                entity.Property(e => e.VersichertenStatus)
                    .HasMaxLength(5)
                    .HasColumnName("versicherten_status")
                    .HasComment("vStat");

                entity.Property(e => e.VersichertenStrasse)
                    .HasMaxLength(50)
                    .HasColumnName("versicherten_strasse")
                    .HasComment("vStr");

                entity.Property(e => e.VersichertenTitel)
                    .HasMaxLength(20)
                    .HasColumnName("versicherten_titel")
                    .HasComment("vTitel");

                entity.Property(e => e.VersichertenVorname)
                    .HasMaxLength(50)
                    .HasColumnName("versicherten_vorname")
                    .HasComment("vVorname");

                entity.Property(e => e.VersichertenkarteGueltigBis)
                    .HasMaxLength(10)
                    .HasColumnName("versichertenkarte_gueltig_bis")
                    .HasComment("vkGueltigBis");

                entity.Property(e => e.Zuzahlung)
                    .HasPrecision(11, 2)
                    .HasColumnName("zuzahlung")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ErPrueferezeptEmuster16Artikel>(entity =>
            {
                entity.HasKey(e => e.IdPrueferezeptEmuster16Artikel)
                    .HasName("er_prueferezept_emuster16_artikel_pkey");

                entity.ToTable("er_prueferezept_emuster16_artikel", "apoti");

                entity.Property(e => e.IdPrueferezeptEmuster16Artikel)
                    .HasColumnName("id_prueferezept_emuster16_artikel")
                    .HasDefaultValueSql("nextval('daten.er_prueferezept_emuster16_art_id_prueferezept_emuster16_art_seq'::regclass)");

                entity.Property(e => e.ArtikelAutidem).HasColumnName("artikel_autidem");

                entity.Property(e => e.ArtikelFaktor).HasColumnName("artikel_faktor");

                entity.Property(e => e.ArtikelMediName)
                    .HasMaxLength(130)
                    .HasColumnName("artikel_medi_name");

                entity.Property(e => e.ArtikelTaxe)
                    .HasPrecision(11, 2)
                    .HasColumnName("artikel_taxe")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArzneiPzn).HasColumnName("arznei_pzn");

                entity.Property(e => e.AtrikelNr).HasColumnName("atrikel_nr");

                entity.Property(e => e.HilfsmittelNr).HasColumnName("hilfsmittel_nr");

                entity.Property(e => e.IdPrueferezeptEmuster16).HasColumnName("id_prueferezept_emuster16");

                entity.HasOne(d => d.IdPrueferezeptEmuster16Navigation)
                    .WithMany(p => p.ErPrueferezeptEmuster16Artikels)
                    .HasForeignKey(d => d.IdPrueferezeptEmuster16)
                    .HasConstraintName("er_prueferezept_emuster16_artike_id_prueferezept_emuster16_fkey");
            });

            modelBuilder.Entity<ErPrueferezeptEmuster16Status>(entity =>
            {
                entity.HasKey(e => e.IdPrueferezeptEmuster16Status)
                    .HasName("er_prueferezept_emuster16_status_pkey");

                entity.ToTable("er_prueferezept_emuster16_status", "apoti");

                entity.Property(e => e.IdPrueferezeptEmuster16Status)
                    .HasColumnName("id_prueferezept_emuster16_status")
                    .HasDefaultValueSql("nextval('daten.er_prueferezept_emuster16_sta_id_prueferezept_emuster16_sta_seq'::regclass)");

                entity.Property(e => e.IdPrueferezeptEmuster16).HasColumnName("id_prueferezept_emuster16");

                entity.Property(e => e.Muster16Id).HasColumnName("muster16_id");

                entity.Property(e => e.RezeptCheck)
                    .HasColumnName("rezept_check")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.RezeptStatus)
                    .HasMaxLength(20)
                    .HasColumnName("rezept_status")
                    .HasDefaultValueSql("'VOR_PRUEFUNG'::character varying");

                entity.Property(e => e.StatusAbfrageDatum)
                    .HasColumnType("date")
                    .HasColumnName("status_abfrage_datum")
                    .HasComment("Abfragedatum des Status zum Rezept");

                entity.Property(e => e.StatusAbfrageZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("status_abfrage_zeit")
                    .HasComment("Abfragezeit des Status zum Rezept");

                entity.HasOne(d => d.IdPrueferezeptEmuster16Navigation)
                    .WithMany(p => p.ErPrueferezeptEmuster16Statuses)
                    .HasForeignKey(d => d.IdPrueferezeptEmuster16)
                    .HasConstraintName("er_prueferezept_emuster16_status_id_prueferezept_emuster16");
            });

            modelBuilder.Entity<ErPrueferezeptEmuster16Statusinfo>(entity =>
            {
                entity.HasKey(e => e.IdPrueferezeptEmuster16Statusinfo)
                    .HasName("er_prueferezept_emuster16_statusinfo_pkey");

                entity.ToTable("er_prueferezept_emuster16_statusinfo", "apoti");

                entity.Property(e => e.IdPrueferezeptEmuster16Statusinfo)
                    .HasColumnName("id_prueferezept_emuster16_statusinfo")
                    .HasDefaultValueSql("nextval('daten.er_prueferezept_emuster16_sta_id_prueferezept_emuster16_st_seq1'::regclass)");

                entity.Property(e => e.Fcode)
                    .HasMaxLength(4)
                    .HasColumnName("fcode");

                entity.Property(e => e.Fkommentar).HasColumnName("fkommentar");

                entity.Property(e => e.Fkurztext).HasColumnName("fkurztext");

                entity.Property(e => e.Fstatus)
                    .HasMaxLength(20)
                    .HasColumnName("fstatus");

                entity.Property(e => e.Ftcode)
                    .HasMaxLength(3)
                    .HasColumnName("ftcode");

                entity.Property(e => e.IdPrueferezeptEmuster16).HasColumnName("id_prueferezept_emuster16");

                entity.Property(e => e.Posnr).HasColumnName("posnr");

                entity.HasOne(d => d.IdPrueferezeptEmuster16Navigation)
                    .WithMany(p => p.ErPrueferezeptEmuster16Statusinfos)
                    .HasForeignKey(d => d.IdPrueferezeptEmuster16)
                    .HasConstraintName("er_prueferezept_emuster16_statusinfo_id_prueferezept_emuster16");
            });

            modelBuilder.Entity<ErPrueferezeptErezept>(entity =>
            {
                entity.HasKey(e => e.IdPrueferezeptErezept)
                    .HasName("er_prueferezept_erezept_pkey");

                entity.ToTable("er_prueferezept_erezept", "apoti");

                entity.Property(e => e.IdPrueferezeptErezept).HasColumnName("id_prueferezept_erezept");

                entity.Property(e => e.AvsId)
                    .HasMaxLength(20)
                    .HasColumnName("avs_id");

                entity.Property(e => e.ErezeptData)
                    .HasColumnName("erezept_data")
                    .HasComment("Base64 Codierung der eRezept Daten");

                entity.Property(e => e.ErezeptId)
                    .HasMaxLength(255)
                    .HasColumnName("erezept_id");

                entity.Property(e => e.PruefModus)
                    .HasMaxLength(20)
                    .HasColumnName("pruef_modus");

                entity.Property(e => e.RzDatum)
                    .HasMaxLength(30)
                    .HasColumnName("rz_datum");

                entity.Property(e => e.RzLieferDatum)
                    .HasColumnType("date")
                    .HasColumnName("rz_liefer_datum");

                entity.Property(e => e.RzLieferId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("rz_liefer_id");

                entity.Property(e => e.RzLieferZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("rz_liefer_zeit");
            });

            modelBuilder.Entity<ErPrueferezeptErezeptLieferid>(entity =>
            {
                entity.HasKey(e => new { e.IdPrueferezeptErezept, e.IdPrueferezeptHeader })
                    .HasName("er_prueferezept_erezept_lieferid_pkey");

                entity.ToTable("er_prueferezept_erezept_lieferid", "apoti");

                entity.Property(e => e.IdPrueferezeptErezept).HasColumnName("id_prueferezept_erezept");

                entity.Property(e => e.IdPrueferezeptHeader).HasColumnName("id_prueferezept_header");

                entity.HasOne(d => d.IdPrueferezeptErezeptNavigation)
                    .WithMany(p => p.ErPrueferezeptErezeptLieferids)
                    .HasForeignKey(d => d.IdPrueferezeptErezept)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("er_prueferezept_erezept_lieferid_id_prueferezept_prezept");

                entity.HasOne(d => d.IdPrueferezeptHeaderNavigation)
                    .WithMany(p => p.ErPrueferezeptErezeptLieferids)
                    .HasForeignKey(d => d.IdPrueferezeptHeader)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("er_prueferezept_erezept_lieferid_id_prueferezept_header");
            });

            modelBuilder.Entity<ErPrueferezeptErezeptStatusinfo>(entity =>
            {
                entity.HasKey(e => e.IdPrueferezeptErezeptStatusinfo)
                    .HasName("er_prueferezept_erezept_statusinfo_pkey");

                entity.ToTable("er_prueferezept_erezept_statusinfo", "apoti");

                entity.Property(e => e.IdPrueferezeptErezeptStatusinfo)
                    .HasColumnName("id_prueferezept_erezept_statusinfo")
                    .HasDefaultValueSql("nextval('daten.er_prueferezept_erezept_statu_id_prueferezept_erezept_statu_seq'::regclass)");

                entity.Property(e => e.Fcode).HasColumnName("fcode");

                entity.Property(e => e.Fkommentar).HasColumnName("fkommentar");

                entity.Property(e => e.Fkurztext).HasColumnName("fkurztext");

                entity.Property(e => e.Fstatus)
                    .HasMaxLength(20)
                    .HasColumnName("fstatus");

                entity.Property(e => e.Ftcode).HasColumnName("ftcode");

                entity.Property(e => e.IdPrueferezeptErezept).HasColumnName("id_prueferezept_erezept");

                entity.Property(e => e.Posnr).HasColumnName("posnr");

                entity.HasOne(d => d.IdPrueferezeptErezeptNavigation)
                    .WithMany(p => p.ErPrueferezeptErezeptStatusinfos)
                    .HasForeignKey(d => d.IdPrueferezeptErezept)
                    .HasConstraintName("er_prueferezept_erezept_statusinfo_id_prueferezept_erezept");
            });

            modelBuilder.Entity<ErPrueferezeptHeader>(entity =>
            {
                entity.HasKey(e => e.IdPrueferezeptHeader)
                    .HasName("er_prueferezept_header_pkey");

                entity.ToTable("er_prueferezept_header", "apoti");

                entity.Property(e => e.IdPrueferezeptHeader).HasColumnName("id_prueferezept_header");

                entity.Property(e => e.ApoIkNr)
                    .HasColumnName("apo_ik_nr")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ApoIntNr).HasColumnName("apo_int_nr");

                entity.Property(e => e.ApoPassword)
                    .HasMaxLength(25)
                    .HasColumnName("apo_password");

                entity.Property(e => e.AvsSendeId).HasColumnName("avs_sende_id");

                entity.Property(e => e.CheckEm16)
                    .HasColumnName("check_em16")
                    .HasDefaultValueSql("false")
                    .HasComment("eMuster16 Rezepte wurden überprüft");

                entity.Property(e => e.CheckErez)
                    .HasColumnName("check_erez")
                    .HasDefaultValueSql("false")
                    .HasComment("eRezepte wurden überprüft");

                entity.Property(e => e.CheckPrez)
                    .HasColumnName("check_prez")
                    .HasDefaultValueSql("false")
                    .HasComment("pRezepte wurden überprüft");

                entity.Property(e => e.ImportTyp)
                    .HasColumnName("import_typ")
                    .HasDefaultValueSql("0")
                    .HasComment("Art wie das Rezept importiert wurde - 0-WebService, 1-Formular, 2-Datei");

                entity.Property(e => e.RezTyp)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("rez_typ")
                    .HasDefaultValueSql("'X'::character varying")
                    .HasComment("eRez->ERezept, pRez->pRezept, eM16->eMuster16 Rezept, X->Unbekannt");

                entity.Property(e => e.RezeptCheck)
                    .HasColumnName("rezept_check")
                    .HasDefaultValueSql("false")
                    .HasComment("Rezeptprüfung durchgeführt TRUE|FALSE");

                entity.Property(e => e.RezeptStatus)
                    .HasMaxLength(20)
                    .HasColumnName("rezept_status")
                    .HasDefaultValueSql("'VOR_PRUEFUNG'::character varying");

                entity.Property(e => e.ReztypEm16)
                    .HasColumnName("reztyp_em16")
                    .HasDefaultValueSql("false")
                    .HasComment("Rezept-Typ eMuster16");

                entity.Property(e => e.ReztypErez)
                    .HasColumnName("reztyp_erez")
                    .HasDefaultValueSql("false")
                    .HasComment("Rezept-Typ eRezept");

                entity.Property(e => e.ReztypPrez)
                    .HasColumnName("reztyp_prez")
                    .HasDefaultValueSql("false")
                    .HasComment("Rezept-Typ pRezept");

                entity.Property(e => e.RzLieferDatum)
                    .HasColumnType("date")
                    .HasColumnName("rz_liefer_datum");

                entity.Property(e => e.RzLieferId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("rz_liefer_id");

                entity.Property(e => e.RzLieferZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("rz_liefer_zeit");

                entity.Property(e => e.SoftwareHersteller)
                    .HasMaxLength(200)
                    .HasColumnName("software_hersteller");

                entity.Property(e => e.SoftwareName)
                    .HasMaxLength(200)
                    .HasColumnName("software_name");

                entity.Property(e => e.SoftwareVersion)
                    .HasMaxLength(20)
                    .HasColumnName("software_version");

                entity.Property(e => e.StatusAbfrageDatum)
                    .HasColumnType("date")
                    .HasColumnName("status_abfrage_datum")
                    .HasComment("Abfragedatum des Status zur Liefer-ID");

                entity.Property(e => e.StatusAbfrageZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("status_abfrage_zeit")
                    .HasComment("Abfragezeit des Status zur Liefer-ID");

                entity.Property(e => e.Testdaten)
                    .HasColumnName("testdaten")
                    .HasDefaultValueSql("false");
            });

            modelBuilder.Entity<ErRabattGruppe>(entity =>
            {
                entity.HasKey(e => e.IdRabattGruppe)
                    .HasName("er_rabatt_gruppe_temp_pkey");

                entity.ToTable("er_rabatt_gruppe", "apoti");

                entity.HasIndex(e => new { e.KeyGruppe, e.GueltigAb, e.GueltigBis }, "idx_er_rabatt_gruppe_keygruppe_gueltigabbis_20210401");

                entity.Property(e => e.IdRabattGruppe)
                    .HasColumnName("id_rabatt_gruppe")
                    .HasDefaultValueSql("nextval('daten.er_rabatt_gruppe_temp_id_rabatt_gruppe_seq'::regclass)");

                entity.Property(e => e.GueltigAb)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_ab");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.KeyGruppe).HasColumnName("key_gruppe");

                entity.Property(e => e.Mkv).HasColumnName("mkv");

                entity.Property(e => e.ZuzahlungFaktor).HasColumnName("zuzahlung_faktor");
            });

            modelBuilder.Entity<ErRabattGruppeTemp>(entity =>
            {
                entity.HasKey(e => e.IdRabattGruppe)
                    .HasName("er_rabatt_gruppe_pkey");

                entity.ToTable("er_rabatt_gruppe_temp", "apoti");

                entity.Property(e => e.IdRabattGruppe)
                    .HasColumnName("id_rabatt_gruppe")
                    .HasDefaultValueSql("nextval('daten.er_rabatt_gruppe_id_rabatt_gruppe_seq'::regclass)");

                entity.Property(e => e.GueltigAb)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_ab");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.KeyGruppe).HasColumnName("key_gruppe");

                entity.Property(e => e.Mkv).HasColumnName("mkv");

                entity.Property(e => e.ZuzahlungFaktor).HasColumnName("zuzahlung_faktor");
            });

            modelBuilder.Entity<ErRabattIndika>(entity =>
            {
                entity.HasKey(e => e.IdRabattIndika)
                    .HasName("er_rabatt_indika_pkey");

                entity.ToTable("er_rabatt_indika", "apoti");

                entity.HasIndex(e => new { e.Indikation, e.Pzn }, "idx_er_rabatt_indika_indikation_pzn_20210401");

                entity.HasIndex(e => new { e.Pzn, e.GueltigAb, e.GueltigBis }, "idx_er_rabatt_indika_pzn_gueltigabbis_20210401");

                entity.Property(e => e.IdRabattIndika)
                    .HasColumnName("id_rabatt_indika")
                    .HasDefaultValueSql("nextval('daten.er_rabatt_indika_temp_id_rabatt_indika_seq'::regclass)");

                entity.Property(e => e.GueltigAb)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_ab");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.Indikation).HasColumnName("indikation");

                entity.Property(e => e.Pzn).HasColumnName("pzn");
            });

            modelBuilder.Entity<ErRabattIndikaTemp>(entity =>
            {
                entity.HasKey(e => e.IdRabattIndika)
                    .HasName("er_rabatt_indika_temp_pkey");

                entity.ToTable("er_rabatt_indika_temp", "apoti");

                entity.Property(e => e.IdRabattIndika)
                    .HasColumnName("id_rabatt_indika")
                    .HasDefaultValueSql("nextval('daten.er_rabatt_indika_id_rabatt_indika_seq'::regclass)");

                entity.Property(e => e.GueltigAb)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_ab");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.Indikation).HasColumnName("indikation");

                entity.Property(e => e.Pzn).HasColumnName("pzn");
            });

            modelBuilder.Entity<ErRabattKasse>(entity =>
            {
                entity.HasKey(e => e.IdRabattKasse)
                    .HasName("er_rabatt_kasse_temp_pkey");

                entity.ToTable("er_rabatt_kasse", "apoti");

                entity.HasIndex(e => new { e.KeyGruppe, e.GueltigAb, e.GueltigBis }, "idx_er_rabatt_kasse_keygruppe_gueltigabbis_20210401");

                entity.Property(e => e.IdRabattKasse)
                    .HasColumnName("id_rabatt_kasse")
                    .HasDefaultValueSql("nextval('daten.er_rabatt_kasse_temp_id_rabatt_kasse_seq'::regclass)");

                entity.Property(e => e.GueltigAb)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_ab");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.KasseIk).HasColumnName("kasse_ik");

                entity.Property(e => e.KeyGruppe).HasColumnName("key_gruppe");
            });

            modelBuilder.Entity<ErRabattKasseTemp>(entity =>
            {
                entity.HasKey(e => e.IdRabattKasse)
                    .HasName("er_rabatt_kasse_pkey");

                entity.ToTable("er_rabatt_kasse_temp", "apoti");

                entity.Property(e => e.IdRabattKasse)
                    .HasColumnName("id_rabatt_kasse")
                    .HasDefaultValueSql("nextval('daten.er_rabatt_kasse_id_rabatt_kasse_seq'::regclass)");

                entity.Property(e => e.GueltigAb)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_ab");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.KasseIk).HasColumnName("kasse_ik");

                entity.Property(e => e.KeyGruppe).HasColumnName("key_gruppe");
            });

            modelBuilder.Entity<ErRabattPzn>(entity =>
            {
                entity.HasKey(e => e.IdRabattPzn)
                    .HasName("er_rabatt_pzn_pkey");

                entity.ToTable("er_rabatt_pzn", "apoti");

                entity.HasIndex(e => new { e.ArzneiPzn, e.KeyGruppe, e.GueltigAb, e.GueltigBis }, "idx_er_rabatt_pzn_arzneipzn_keygruppe_gueltigabbis_20210401");

                entity.Property(e => e.IdRabattPzn)
                    .HasColumnName("id_rabatt_pzn")
                    .HasDefaultValueSql("nextval('daten.er_rabatt_pzn_temp_id_rabatt_pzn_seq'::regclass)");

                entity.Property(e => e.ArzneiPzn).HasColumnName("arznei_pzn");

                entity.Property(e => e.GueltigAb)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_ab");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.KeyGruppe).HasColumnName("key_gruppe");
            });

            modelBuilder.Entity<ErRabattPznTemp>(entity =>
            {
                entity.HasKey(e => e.IdRabattPzn)
                    .HasName("er_rabatt_pzn_temp_pkey");

                entity.ToTable("er_rabatt_pzn_temp", "apoti");

                entity.Property(e => e.IdRabattPzn)
                    .HasColumnName("id_rabatt_pzn")
                    .HasDefaultValueSql("nextval('daten.er_rabatt_pzn_temp_id_rabatt_pzn_seq1'::regclass)");

                entity.Property(e => e.ArzneiPzn).HasColumnName("arznei_pzn");

                entity.Property(e => e.GueltigAb)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_ab");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.KeyGruppe).HasColumnName("key_gruppe");
            });

            modelBuilder.Entity<ErRabattWirkstoff>(entity =>
            {
                entity.HasKey(e => new { e.Pzn, e.Komponentennr, e.FaiDbRang, e.GueltigBis })
                    .HasName("er_rabatt_wirkstoff_pkey");

                entity.ToTable("er_rabatt_wirkstoff", "apoti");

                entity.HasIndex(e => new { e.Pzn, e.GueltigAb, e.GueltigBis }, "idx_er_rabatt_wirkstoff_pzn_gueltigabbis_20210401");

                entity.Property(e => e.Pzn).HasColumnName("pzn");

                entity.Property(e => e.Komponentennr).HasColumnName("komponentennr");

                entity.Property(e => e.FaiDbRang).HasColumnName("fai_db_rang");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.FaiDbKeySto).HasColumnName("fai_db_key_sto");

                entity.Property(e => e.FaiDbZahl).HasColumnName("fai_db_zahl");

                entity.Property(e => e.FakDbAbsolutbezugEinheit)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("fak_db_absolutbezug_einheit");

                entity.Property(e => e.FamDbKeyAtc)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("fam_db_key_atc");

                entity.Property(e => e.FamDbKeyDar)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("fam_db_key_dar");

                entity.Property(e => e.FamDbKeyIndHaupt)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("fam_db_key_ind_haupt");

                entity.Property(e => e.FamDbKeyIndNeben)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("fam_db_key_ind_neben");

                entity.Property(e => e.GueltigAb)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_ab");

                entity.Property(e => e.PacApoImportgruppennr).HasColumnName("pac_apo_importgruppennr");

                entity.Property(e => e.PacApoKeyAus).HasColumnName("pac_apo_key_aus");

                entity.Property(e => e.PacApoKeyWar)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("pac_apo_key_war");

                entity.Property(e => e.PgrApoEinstufung).HasColumnName("pgr_apo_einstufung");
            });

            modelBuilder.Entity<ErRabattWirkstoffTemp>(entity =>
            {
                entity.HasKey(e => new { e.Pzn, e.Komponentennr, e.FaiDbRang, e.GueltigBis })
                    .HasName("er_rabatt_wirkstoff_temp_pkey");

                entity.ToTable("er_rabatt_wirkstoff_temp", "apoti");

                entity.Property(e => e.Pzn).HasColumnName("pzn");

                entity.Property(e => e.Komponentennr).HasColumnName("komponentennr");

                entity.Property(e => e.FaiDbRang).HasColumnName("fai_db_rang");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.FaiDbKeySto).HasColumnName("fai_db_key_sto");

                entity.Property(e => e.FaiDbZahl).HasColumnName("fai_db_zahl");

                entity.Property(e => e.FakDbAbsolutbezugEinheit)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("fak_db_absolutbezug_einheit");

                entity.Property(e => e.FamDbKeyAtc)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("fam_db_key_atc");

                entity.Property(e => e.FamDbKeyDar)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("fam_db_key_dar");

                entity.Property(e => e.FamDbKeyIndHaupt)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("fam_db_key_ind_haupt");

                entity.Property(e => e.FamDbKeyIndNeben)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("fam_db_key_ind_neben");

                entity.Property(e => e.GueltigAb)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_ab");

                entity.Property(e => e.PacApoImportgruppennr).HasColumnName("pac_apo_importgruppennr");

                entity.Property(e => e.PacApoKeyAus).HasColumnName("pac_apo_key_aus");

                entity.Property(e => e.PacApoKeyWar)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("pac_apo_key_war");

                entity.Property(e => e.PgrApoEinstufung).HasColumnName("pgr_apo_einstufung");
            });

            modelBuilder.Entity<ErSecAccessFiverx>(entity =>
            {
                entity.HasKey(e => e.IdSecAccessFiverx)
                    .HasName("er_sec_access_fiverx_pkey");

                entity.ToTable("er_sec_access_fiverx", "apoti");

                entity.HasIndex(e => e.LoginId, "er_sec_access_fiverx_login_id_key")
                    .IsUnique();

                entity.HasIndex(e => e.LoginId, "idx_er_sec_access_fiverx_login_id")
                    .IsUnique();

                entity.Property(e => e.IdSecAccessFiverx).HasColumnName("id_sec_access_fiverx");

                entity.Property(e => e.AenDatum)
                    .HasColumnType("date")
                    .HasColumnName("aen_datum");

                entity.Property(e => e.AenIdSecUser).HasColumnName("aen_id_sec_user");

                entity.Property(e => e.AenZeit)
                    .HasColumnType("time(0) without time zone")
                    .HasColumnName("aen_zeit");

                entity.Property(e => e.Em16Uc61Asyn)
                    .HasColumnName("em16_uc61_asyn")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Em16Uc61Syn)
                    .HasColumnName("em16_uc61_syn")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Em16Uc61U1)
                    .HasColumnName("em16_uc61_u1")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ErezUc4)
                    .HasColumnName("erez_uc4")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ErezUc51)
                    .HasColumnName("erez_uc51")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ErezUc52)
                    .HasColumnName("erez_uc52")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ErezUc62Asyn)
                    .HasColumnName("erez_uc62_asyn")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ErezUc62Syn)
                    .HasColumnName("erez_uc62_syn")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ErezUc7)
                    .HasColumnName("erez_uc7")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Freigegeben)
                    .HasColumnName("freigegeben")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IdApotheke).HasColumnName("id_apotheke");

                entity.Property(e => e.LoginId)
                    .IsRequired()
                    .HasMaxLength(47)
                    .HasColumnName("login_id");

                entity.Property(e => e.LoginPasswort)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("login_passwort");

                entity.Property(e => e.LoginPasswortCrypt)
                    .HasMaxLength(255)
                    .HasColumnName("login_passwort_crypt");

                entity.HasOne(d => d.IdApothekeNavigation)
                    .WithMany(p => p.ErSecAccessFiverxes)
                    .HasForeignKey(d => d.IdApotheke)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("er_sec_access_fiverx_id_apotheke_fkey");
            });

            modelBuilder.Entity<ErSenderezepteEmuster16>(entity =>
            {
                entity.HasKey(e => e.IdSenderezepteEmuster16)
                    .HasName("er_senderezepte_emuster16_pkey");

                entity.ToTable("er_senderezepte_emuster16", "apoti");

                entity.HasIndex(e => e.ApoIkNr, "idx_er_sendrez_apoik");

                entity.HasIndex(e => new { e.Muster16Id, e.RzLieferId }, "idx_er_sendrez_em16_muster16_id");

                entity.HasIndex(e => new { e.RzLieferId, e.Muster16Id }, "idx_er_sendrez_em16_rz_liefer_id");

                entity.Property(e => e.IdSenderezepteEmuster16).HasColumnName("id_senderezepte_emuster16");

                entity.Property(e => e.AbdaKassentyp)
                    .HasMaxLength(5)
                    .HasColumnName("abda_kassentyp")
                    .HasComment("kArt");

                entity.Property(e => e.Abgabedatum)
                    .HasColumnType("date")
                    .HasColumnName("abgabedatum")
                    .HasComment("abDatum");

                entity.Property(e => e.AbrechnungsPeriode)
                    .HasMaxLength(10)
                    .HasColumnName("abrechnungs_periode")
                    .HasComment("aPeriode");

                entity.Property(e => e.ApoIkNr).HasColumnName("apo_ik_nr");

                entity.Property(e => e.Arbeitsplatz)
                    .HasMaxLength(50)
                    .HasColumnName("arbeitsplatz")
                    .HasComment("arbPlatz");

                entity.Property(e => e.ArztNr)
                    .HasColumnName("arzt_nr")
                    .HasComment("laNr - Lebenslange Arzt-Nummer");

                entity.Property(e => e.AvsId)
                    .HasMaxLength(20)
                    .HasColumnName("avs_id");

                entity.Property(e => e.Bediener)
                    .HasMaxLength(50)
                    .HasColumnName("bediener");

                entity.Property(e => e.BegrPflicht)
                    .HasColumnName("begr_pflicht")
                    .HasDefaultValueSql("0")
                    .HasComment("bgrPfl");

                entity.Property(e => e.BetriebsstaettenNr)
                    .HasColumnName("betriebsstaetten_nr")
                    .HasComment("vrtrgsArztNr - Betriebsstättennummer oder Praxis-Nummer");

                entity.Property(e => e.Eigenanteil)
                    .HasPrecision(11, 2)
                    .HasColumnName("eigenanteil")
                    .HasDefaultValueSql("0")
                    .HasComment("eigBet");

                entity.Property(e => e.GesamtesBrutto)
                    .HasPrecision(11, 2)
                    .HasColumnName("gesamtes_brutto")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdSenderezepteHeader).HasColumnName("id_senderezepte_header");

                entity.Property(e => e.KkIkNr)
                    .HasColumnName("kk_ik_nr")
                    .HasComment("Krankenkassen-Ik der Versicherung");

                entity.Property(e => e.KkName)
                    .HasMaxLength(50)
                    .HasColumnName("kk_name")
                    .HasComment("kName");

                entity.Property(e => e.KkTyp)
                    .HasMaxLength(5)
                    .HasColumnName("kk_typ")
                    .HasComment("rTyp");

                entity.Property(e => e.KzArbeitsunfall)
                    .HasColumnName("kz_arbeitsunfall")
                    .HasDefaultValueSql("0")
                    .HasComment("aUnfall");

                entity.Property(e => e.KzBvg)
                    .HasColumnName("kz_bvg")
                    .HasDefaultValueSql("0")
                    .HasComment("bvg");

                entity.Property(e => e.KzGebuehrenFrei)
                    .HasColumnName("kz_gebuehren_frei")
                    .HasDefaultValueSql("0")
                    .HasComment("gebFrei");

                entity.Property(e => e.KzHilfsmittel)
                    .HasColumnName("kz_hilfsmittel")
                    .HasDefaultValueSql("0")
                    .HasComment("hilf");

                entity.Property(e => e.KzImpfstoff)
                    .HasColumnName("kz_impfstoff")
                    .HasDefaultValueSql("0")
                    .HasComment("impf");

                entity.Property(e => e.KzNoctu)
                    .HasColumnName("kz_noctu")
                    .HasDefaultValueSql("0")
                    .HasComment("noctu");

                entity.Property(e => e.KzSonstige)
                    .HasColumnName("kz_sonstige")
                    .HasDefaultValueSql("0")
                    .HasComment("sonstige");

                entity.Property(e => e.KzSprechstundenbedarf)
                    .HasColumnName("kz_sprechstundenbedarf")
                    .HasDefaultValueSql("0")
                    .HasComment("sprStBedarf");

                entity.Property(e => e.KzUnfall)
                    .HasColumnName("kz_unfall")
                    .HasDefaultValueSql("0")
                    .HasComment("unfall");

                entity.Property(e => e.Muster16Id).HasColumnName("muster16_id");

                entity.Property(e => e.RezeptTyp)
                    .HasMaxLength(30)
                    .HasColumnName("rezept_typ")
                    .HasComment("Nur STANDARDREZEPT, BTM, SPRECHSTUNDENBEDARF");

                entity.Property(e => e.RzDatum)
                    .HasMaxLength(30)
                    .HasColumnName("rz_datum");

                entity.Property(e => e.RzLieferDatum)
                    .HasColumnType("date")
                    .HasColumnName("rz_liefer_datum");

                entity.Property(e => e.RzLieferId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("rz_liefer_id");

                entity.Property(e => e.RzLieferZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("rz_liefer_zeit");

                entity.Property(e => e.TFachinformation)
                    .HasColumnName("t_fachinformation")
                    .HasDefaultValueSql("0")
                    .HasComment("tFachinformation");

                entity.Property(e => e.TInLabel)
                    .HasColumnName("t_in_label")
                    .HasDefaultValueSql("0")
                    .HasComment("tInLabel");

                entity.Property(e => e.TOffLabel)
                    .HasColumnName("t_off_label")
                    .HasDefaultValueSql("0")
                    .HasComment("tOffLabel");

                entity.Property(e => e.TSicherheitsbestimmung)
                    .HasColumnName("t_sicherheitsbestimmung")
                    .HasDefaultValueSql("0")
                    .HasComment("tSicherheitsbestimmung");

                entity.Property(e => e.UnfallDatum)
                    .HasColumnType("date")
                    .HasColumnName("unfall_datum")
                    .HasComment("unfallTag");

                entity.Property(e => e.Verordnungsdatum)
                    .HasColumnType("date")
                    .HasColumnName("verordnungsdatum")
                    .HasComment("verDat - Ausstellungsdatum - Verordnungsdatum");

                entity.Property(e => e.VersichertenGeburtsdatum)
                    .HasColumnType("date")
                    .HasColumnName("versicherten_geburtsdatum")
                    .HasComment("vGeb");

                entity.Property(e => e.VersichertenName)
                    .HasMaxLength(50)
                    .HasColumnName("versicherten_name")
                    .HasComment("vName");

                entity.Property(e => e.VersichertenNummer)
                    .HasMaxLength(12)
                    .HasColumnName("versicherten_nummer")
                    .HasComment("vrsNr");

                entity.Property(e => e.VersichertenOrt)
                    .HasMaxLength(50)
                    .HasColumnName("versicherten_ort")
                    .HasComment("vOrt");

                entity.Property(e => e.VersichertenPlz)
                    .HasMaxLength(5)
                    .HasColumnName("versicherten_plz")
                    .HasComment("vPlz");

                entity.Property(e => e.VersichertenStatus)
                    .HasMaxLength(5)
                    .HasColumnName("versicherten_status")
                    .HasComment("vStat");

                entity.Property(e => e.VersichertenStrasse)
                    .HasMaxLength(50)
                    .HasColumnName("versicherten_strasse")
                    .HasComment("vStr");

                entity.Property(e => e.VersichertenTitel)
                    .HasMaxLength(20)
                    .HasColumnName("versicherten_titel")
                    .HasComment("vTitel");

                entity.Property(e => e.VersichertenVorname)
                    .HasMaxLength(50)
                    .HasColumnName("versicherten_vorname")
                    .HasComment("vVorname");

                entity.Property(e => e.VersichertenkarteGueltigBis)
                    .HasMaxLength(10)
                    .HasColumnName("versichertenkarte_gueltig_bis")
                    .HasComment("vkGueltigBis");

                entity.Property(e => e.Zuzahlung)
                    .HasPrecision(11, 2)
                    .HasColumnName("zuzahlung")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdSenderezepteHeaderNavigation)
                    .WithMany(p => p.ErSenderezepteEmuster16s)
                    .HasForeignKey(d => d.IdSenderezepteHeader)
                    .HasConstraintName("er_senderezepte_emuster16_id_senderezepte_header");
            });

            modelBuilder.Entity<ErSenderezepteEmuster16Artikel>(entity =>
            {
                entity.HasKey(e => e.IdSenderezepteEmuster16Artikel)
                    .HasName("er_senderezepte_emuster16_artikel_pkey");

                entity.ToTable("er_senderezepte_emuster16_artikel", "apoti");

                entity.HasIndex(e => e.IdSenderezepteEmuster16, "idx_er_sendrez_em16_artikel_id");

                entity.Property(e => e.IdSenderezepteEmuster16Artikel)
                    .HasColumnName("id_senderezepte_emuster16_artikel")
                    .HasDefaultValueSql("nextval('daten.er_senderezepte_emuster16_art_id_senderezepte_emuster16_art_seq'::regclass)");

                entity.Property(e => e.ArtikelAutidem).HasColumnName("artikel_autidem");

                entity.Property(e => e.ArtikelFaktor).HasColumnName("artikel_faktor");

                entity.Property(e => e.ArtikelMediName)
                    .HasMaxLength(130)
                    .HasColumnName("artikel_medi_name");

                entity.Property(e => e.ArtikelTaxe)
                    .HasPrecision(11, 2)
                    .HasColumnName("artikel_taxe")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArzneiPzn).HasColumnName("arznei_pzn");

                entity.Property(e => e.AtrikelNr).HasColumnName("atrikel_nr");

                entity.Property(e => e.HilfsmittelNr).HasColumnName("hilfsmittel_nr");

                entity.Property(e => e.IdSenderezepteEmuster16).HasColumnName("id_senderezepte_emuster16");

                entity.HasOne(d => d.IdSenderezepteEmuster16Navigation)
                    .WithMany(p => p.ErSenderezepteEmuster16Artikels)
                    .HasForeignKey(d => d.IdSenderezepteEmuster16)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("er_senderezepte_emuster16_artike_id_senderezepte_emuster16_fkey");
            });

            modelBuilder.Entity<ErSenderezepteEmuster16Daten>(entity =>
            {
                entity.HasKey(e => e.IdSenderezepteEmuster16Daten)
                    .HasName("er_senderezepte_emuster16_daten_pkey");

                entity.ToTable("er_senderezepte_emuster16_daten", "apoti");

                entity.HasIndex(e => e.IdSenderezepteEmuster16, "idx_er_sendrez_em16_daten_id");

                entity.Property(e => e.IdSenderezepteEmuster16Daten)
                    .HasColumnName("id_senderezepte_emuster16_daten")
                    .HasDefaultValueSql("nextval('daten.er_senderezepte_emuster16_dat_id_senderezepte_emuster16_dat_seq'::regclass)");

                entity.Property(e => e.IdSenderezepteEmuster16).HasColumnName("id_senderezepte_emuster16");

                entity.Property(e => e.RezeptUuid)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasColumnName("rezept_uuid")
                    .HasComment("Eindeutiger Rezept - Universal Unique Identifier (UUID)");

                entity.Property(e => e.TransferArz)
                    .HasColumnName("transfer_arz")
                    .HasDefaultValueSql("false")
                    .HasComment("Bestätigung vom ARZ - Transfer der Rezeptdaten erfolgt");

                entity.Property(e => e.XmlRequest)
                    .IsRequired()
                    .HasColumnName("xml_request")
                    .HasComment("Original XML-Request der Apotheke (nur Rezept-XML) - zur Weiterleitung ins ARZ");

                entity.HasOne(d => d.IdSenderezepteEmuster16Navigation)
                    .WithMany(p => p.ErSenderezepteEmuster16Datens)
                    .HasForeignKey(d => d.IdSenderezepteEmuster16)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("er_senderezepte_emuster16_daten_id_senderezepte_emuster16");
            });

            modelBuilder.Entity<ErSenderezepteEmuster16Status>(entity =>
            {
                entity.HasKey(e => e.IdSenderezepteEmuster16Status)
                    .HasName("er_senderezepte_emuster16_status_pkey");

                entity.ToTable("er_senderezepte_emuster16_status", "apoti");

                entity.HasIndex(e => new { e.IdSenderezepteEmuster16, e.Muster16Id, e.RezeptStatus }, "idx_er_sendrez_em16_stat_idrezem16");

                entity.Property(e => e.IdSenderezepteEmuster16Status)
                    .HasColumnName("id_senderezepte_emuster16_status")
                    .HasDefaultValueSql("nextval('daten.er_senderezepte_emuster16_sta_id_senderezepte_emuster16_sta_seq'::regclass)");

                entity.Property(e => e.AbrechenStatus)
                    .HasMaxLength(20)
                    .HasColumnName("abrechen_status")
                    .HasDefaultValueSql("'VOR_PRUEFUNG'::character varying")
                    .HasComment("Interner Status - enthält immer das Prüfergebnis");

                entity.Property(e => e.IdSenderezepteEmuster16).HasColumnName("id_senderezepte_emuster16");

                entity.Property(e => e.Muster16Id).HasColumnName("muster16_id");

                entity.Property(e => e.RezeptCheck)
                    .HasColumnName("rezept_check")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.RezeptStatus)
                    .HasMaxLength(20)
                    .HasColumnName("rezept_status")
                    .HasDefaultValueSql("'VOR_PRUEFUNG'::character varying");

                entity.Property(e => e.RzAbfrageId)
                    .HasMaxLength(20)
                    .HasColumnName("rz_abfrage_id")
                    .HasComment("ID mit der alle DS gekennzeichnet sind die innerhalb einer RCS Abfrage gesendet wurden");

                entity.Property(e => e.StatusAbfrageDatum)
                    .HasColumnType("date")
                    .HasColumnName("status_abfrage_datum")
                    .HasComment("Abfragedatum des Status zum Rezept");

                entity.Property(e => e.StatusAbfrageZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("status_abfrage_zeit")
                    .HasComment("Abfragezeit des Status zum Rezept");

                entity.HasOne(d => d.IdSenderezepteEmuster16Navigation)
                    .WithMany(p => p.ErSenderezepteEmuster16Statuses)
                    .HasForeignKey(d => d.IdSenderezepteEmuster16)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("er_senderezepte_emuster16_status_id_senderezepte_emuster16");
            });

            modelBuilder.Entity<ErSenderezepteEmuster16Statusinfo>(entity =>
            {
                entity.HasKey(e => e.IdSenderezepteEmuster16Statusinfo)
                    .HasName("er_senderezepte_emuster16_statusinfo_pkey");

                entity.ToTable("er_senderezepte_emuster16_statusinfo", "apoti");

                entity.HasIndex(e => e.IdSenderezepteEmuster16, "idx_er_sendrez_em16_stinfo_id");

                entity.Property(e => e.IdSenderezepteEmuster16Statusinfo)
                    .HasColumnName("id_senderezepte_emuster16_statusinfo")
                    .HasDefaultValueSql("nextval('daten.er_senderezepte_emuster16_sta_id_senderezepte_emuster16_st_seq1'::regclass)");

                entity.Property(e => e.Fcode)
                    .HasMaxLength(4)
                    .HasColumnName("fcode");

                entity.Property(e => e.Fkommentar).HasColumnName("fkommentar");

                entity.Property(e => e.Fkurztext).HasColumnName("fkurztext");

                entity.Property(e => e.Fstatus)
                    .HasMaxLength(20)
                    .HasColumnName("fstatus");

                entity.Property(e => e.Ftcode)
                    .HasMaxLength(3)
                    .HasColumnName("ftcode");

                entity.Property(e => e.IdSenderezepteEmuster16).HasColumnName("id_senderezepte_emuster16");

                entity.Property(e => e.Posnr).HasColumnName("posnr");

                entity.Property(e => e.RegelNr)
                    .HasMaxLength(10)
                    .HasColumnName("regel_nr");

                entity.Property(e => e.RegelTrefferCode)
                    .HasMaxLength(7)
                    .HasColumnName("regel_treffer_code");

                entity.HasOne(d => d.IdSenderezepteEmuster16Navigation)
                    .WithMany(p => p.ErSenderezepteEmuster16Statusinfos)
                    .HasForeignKey(d => d.IdSenderezepteEmuster16)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("er_senderezepte_emuster16_statusinfo_id_senderezepte_emuster16");
            });

            modelBuilder.Entity<ErSenderezepteErezept>(entity =>
            {
                entity.HasKey(e => e.IdSenderezepteErezept)
                    .HasName("er_senderezepte_erezept_pkey");

                entity.ToTable("er_senderezepte_erezept", "apoti");

                entity.Property(e => e.IdSenderezepteErezept).HasColumnName("id_senderezepte_erezept");

                entity.Property(e => e.AbrechnungsPeriode)
                    .HasMaxLength(10)
                    .HasColumnName("abrechnungs_periode");

                entity.Property(e => e.ApoIkNr).HasColumnName("apo_ik_nr");

                entity.Property(e => e.AvsId)
                    .HasMaxLength(20)
                    .HasColumnName("avs_id");

                entity.Property(e => e.ErezeptData)
                    .HasColumnName("erezept_data")
                    .HasComment("Base64 Codierung der eRezept Daten");

                entity.Property(e => e.ErezeptId)
                    .HasMaxLength(255)
                    .HasColumnName("erezept_id");

                entity.Property(e => e.IdSenderezepteHeader).HasColumnName("id_senderezepte_header");

                entity.Property(e => e.RzDatum)
                    .HasMaxLength(30)
                    .HasColumnName("rz_datum");

                entity.Property(e => e.RzLieferDatum)
                    .HasColumnType("date")
                    .HasColumnName("rz_liefer_datum");

                entity.Property(e => e.RzLieferId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("rz_liefer_id");

                entity.Property(e => e.RzLieferZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("rz_liefer_zeit");

                entity.HasOne(d => d.IdSenderezepteHeaderNavigation)
                    .WithMany(p => p.ErSenderezepteErezepts)
                    .HasForeignKey(d => d.IdSenderezepteHeader)
                    .HasConstraintName("er_senderezepte_erezept_id_senderezepte_header");
            });

            modelBuilder.Entity<ErSenderezepteErezeptDaten>(entity =>
            {
                entity.HasKey(e => e.IdSenderezepteErezeptDaten)
                    .HasName("er_senderezepte_erezept_daten_pkey");

                entity.ToTable("er_senderezepte_erezept_daten", "apoti");

                entity.HasIndex(e => e.IdSenderezepteErezept, "idx_er_sendrez_erez_daten_id");

                entity.Property(e => e.IdSenderezepteErezeptDaten).HasColumnName("id_senderezepte_erezept_daten");

                entity.Property(e => e.IdSenderezepteErezept).HasColumnName("id_senderezepte_erezept");

                entity.Property(e => e.RezeptUuid)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasColumnName("rezept_uuid")
                    .HasComment("Eindeutiger Rezept - Universal Unique Identifier (UUID)");

                entity.Property(e => e.TransferArz)
                    .HasColumnName("transfer_arz")
                    .HasDefaultValueSql("false")
                    .HasComment("Bestätigung vom ARZ - Transfer der Rezeptdaten erfolgt");

                entity.Property(e => e.XmlRequest)
                    .IsRequired()
                    .HasColumnName("xml_request")
                    .HasComment("Original XML-Request der Apotheke (nur Rezept-XML) - zur Weiterleitung ins ARZ");

                entity.HasOne(d => d.IdSenderezepteErezeptNavigation)
                    .WithMany(p => p.ErSenderezepteErezeptDatens)
                    .HasForeignKey(d => d.IdSenderezepteErezept)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("er_senderezepte_erezept_daten_id_senderezepte_erezept");
            });

            modelBuilder.Entity<ErSenderezepteErezeptStatus>(entity =>
            {
                entity.HasKey(e => e.IdSenderezepteErezeptStatus)
                    .HasName("er_senderezepte_erezept_status_pkey");

                entity.ToTable("er_senderezepte_erezept_status", "apoti");

                entity.HasIndex(e => new { e.IdSenderezepteErezept, e.ErezeptId, e.RezeptStatus }, "idx_er_sendrez_erez_stat_idrezerez");

                entity.Property(e => e.IdSenderezepteErezeptStatus)
                    .HasColumnName("id_senderezepte_erezept_status")
                    .HasDefaultValueSql("nextval('daten.er_senderezepte_erezept_statu_id_senderezepte_erezept_statu_seq'::regclass)");

                entity.Property(e => e.AbrechenStatus)
                    .HasMaxLength(20)
                    .HasColumnName("abrechen_status")
                    .HasDefaultValueSql("'VOR_PRUEFUNG'::character varying")
                    .HasComment("Interner Status - enthält immer das Prüfergebnis");

                entity.Property(e => e.ErezeptId)
                    .HasMaxLength(22)
                    .HasColumnName("erezept_id");

                entity.Property(e => e.IdSenderezepteErezept).HasColumnName("id_senderezepte_erezept");

                entity.Property(e => e.RezeptCheck)
                    .HasColumnName("rezept_check")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.RezeptStatus)
                    .HasMaxLength(20)
                    .HasColumnName("rezept_status")
                    .HasDefaultValueSql("'VOR_PRUEFUNG'::character varying");

                entity.Property(e => e.RzAbfrageId)
                    .HasMaxLength(20)
                    .HasColumnName("rz_abfrage_id")
                    .HasComment("ID mit der alle DS gekennzeichnet sind die innerhalb einer RCS Abfrage gesendet wurden");

                entity.Property(e => e.StatusAbfrageDatum)
                    .HasColumnType("date")
                    .HasColumnName("status_abfrage_datum")
                    .HasComment("Abfragedatum des Status zum Rezept");

                entity.Property(e => e.StatusAbfrageZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("status_abfrage_zeit")
                    .HasComment("Abfragezeit des Status zum Rezept");

                entity.HasOne(d => d.IdSenderezepteErezeptNavigation)
                    .WithMany(p => p.ErSenderezepteErezeptStatuses)
                    .HasForeignKey(d => d.IdSenderezepteErezept)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("er_senderezepte_erezept_status_id_senderezepte_erezept");
            });

            modelBuilder.Entity<ErSenderezepteErezeptStatusinfo>(entity =>
            {
                entity.HasKey(e => e.IdSenderezepteErezeptStatusinfo)
                    .HasName("er_senderezepte_erezept_statusinfo_pkey");

                entity.ToTable("er_senderezepte_erezept_statusinfo", "apoti");

                entity.HasIndex(e => e.IdSenderezepteErezept, "idx_er_sendrez_erez_stinfo_id");

                entity.Property(e => e.IdSenderezepteErezeptStatusinfo)
                    .HasColumnName("id_senderezepte_erezept_statusinfo")
                    .HasDefaultValueSql("nextval('daten.er_senderezepte_erezept_statu_id_senderezepte_erezept_stat_seq1'::regclass)");

                entity.Property(e => e.Fcode)
                    .HasMaxLength(4)
                    .HasColumnName("fcode");

                entity.Property(e => e.Fkommentar).HasColumnName("fkommentar");

                entity.Property(e => e.Fkurztext).HasColumnName("fkurztext");

                entity.Property(e => e.Fstatus)
                    .HasMaxLength(20)
                    .HasColumnName("fstatus");

                entity.Property(e => e.Ftcode)
                    .HasMaxLength(3)
                    .HasColumnName("ftcode");

                entity.Property(e => e.IdSenderezepteErezept).HasColumnName("id_senderezepte_erezept");

                entity.Property(e => e.Posnr).HasColumnName("posnr");

                entity.Property(e => e.RegelNr)
                    .HasMaxLength(10)
                    .HasColumnName("regel_nr");

                entity.Property(e => e.RegelTrefferCode)
                    .HasMaxLength(7)
                    .HasColumnName("regel_treffer_code");

                entity.HasOne(d => d.IdSenderezepteErezeptNavigation)
                    .WithMany(p => p.ErSenderezepteErezeptStatusinfos)
                    .HasForeignKey(d => d.IdSenderezepteErezept)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("er_senderezepte_erezept_statusinfo_id_senderezepte_erezept");
            });

            modelBuilder.Entity<ErSenderezepteHeader>(entity =>
            {
                entity.HasKey(e => e.IdSenderezepteHeader)
                    .HasName("er_senderezepte_header_pkey");

                entity.ToTable("er_senderezepte_header", "apoti");

                entity.HasIndex(e => new { e.ApoIntNr, e.RzLieferId }, "idx_er_sendrez_head_apo_int_nr");

                entity.HasIndex(e => new { e.RzLieferId, e.ApoIntNr }, "idx_er_sendrez_head_rz_liefer_id");

                entity.Property(e => e.IdSenderezepteHeader).HasColumnName("id_senderezepte_header");

                entity.Property(e => e.AbfrageDatum)
                    .HasColumnType("date")
                    .HasColumnName("abfrage_datum")
                    .HasComment("Abfragedatum des Status zur Liefer-ID");

                entity.Property(e => e.AbfrageZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("abfrage_zeit")
                    .HasComment("Abfragezeit des Status zur Liefer-ID");

                entity.Property(e => e.ApoIkNr)
                    .HasColumnName("apo_ik_nr")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ApoIntNr).HasColumnName("apo_int_nr");

                entity.Property(e => e.ApoPassword)
                    .HasMaxLength(25)
                    .HasColumnName("apo_password");

                entity.Property(e => e.AvsSendeId).HasColumnName("avs_sende_id");

                entity.Property(e => e.CheckDatum)
                    .HasColumnType("date")
                    .HasColumnName("check_datum")
                    .HasComment("Datum des letzten Checks der Rezepte dieser LieferID");

                entity.Property(e => e.CheckEm16)
                    .HasColumnName("check_em16")
                    .HasDefaultValueSql("false")
                    .HasComment("eMuster16 Rezepte wurden überprüft");

                entity.Property(e => e.CheckErez)
                    .HasColumnName("check_erez")
                    .HasDefaultValueSql("false")
                    .HasComment("eRezepte wurden überprüft");

                entity.Property(e => e.CheckPrez)
                    .HasColumnName("check_prez")
                    .HasDefaultValueSql("false")
                    .HasComment("pRezepte wurden überprüft");

                entity.Property(e => e.CheckZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("check_zeit")
                    .HasComment("Zeit des letzten Checks der Rezepte dieser LieferID");

                entity.Property(e => e.ImportTyp)
                    .HasColumnName("import_typ")
                    .HasDefaultValueSql("0")
                    .HasComment("Art wie das Rezept importiert wurde - 0-WebService, 1-Formular, 2-Datei");

                entity.Property(e => e.RezTyp)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("rez_typ")
                    .HasDefaultValueSql("'X'::character varying")
                    .HasComment("eRez->ERezept, pRez->pRezept, eM16->eMuster16 Rezept, X->Unbekannt");

                entity.Property(e => e.RezeptCheck)
                    .HasColumnName("rezept_check")
                    .HasDefaultValueSql("false")
                    .HasComment("Rezeptprüfung durchgeführt TRUE|FALSE");

                entity.Property(e => e.RezeptStatus)
                    .HasMaxLength(20)
                    .HasColumnName("rezept_status")
                    .HasDefaultValueSql("'VOR_PRUEFUNG'::character varying");

                entity.Property(e => e.ReztypEm16)
                    .HasColumnName("reztyp_em16")
                    .HasDefaultValueSql("false")
                    .HasComment("Rezept-Typ eMuster16");

                entity.Property(e => e.ReztypErez)
                    .HasColumnName("reztyp_erez")
                    .HasDefaultValueSql("false")
                    .HasComment("Rezept-Typ eRezept");

                entity.Property(e => e.ReztypPrez)
                    .HasColumnName("reztyp_prez")
                    .HasDefaultValueSql("false")
                    .HasComment("Rezept-Typ pRezept");

                entity.Property(e => e.RzLieferDatum)
                    .HasColumnType("date")
                    .HasColumnName("rz_liefer_datum");

                entity.Property(e => e.RzLieferId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("rz_liefer_id");

                entity.Property(e => e.RzLieferZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("rz_liefer_zeit");

                entity.Property(e => e.SoftwareHersteller)
                    .HasMaxLength(200)
                    .HasColumnName("software_hersteller");

                entity.Property(e => e.SoftwareName)
                    .HasMaxLength(200)
                    .HasColumnName("software_name");

                entity.Property(e => e.SoftwareVersion)
                    .HasMaxLength(20)
                    .HasColumnName("software_version");

                entity.Property(e => e.Testdaten)
                    .HasColumnName("testdaten")
                    .HasDefaultValueSql("false");
            });

            modelBuilder.Entity<ErSenderezepteHeaderDaten>(entity =>
            {
                entity.HasKey(e => e.IdSenderezepteHeaderDaten)
                    .HasName("er_senderezepte_header_daten_pkey");

                entity.ToTable("er_senderezepte_header_daten", "apoti");

                entity.HasIndex(e => e.IdSenderezepteHeader, "idx_er_sendrez_header_daten_id");

                entity.Property(e => e.IdSenderezepteHeaderDaten).HasColumnName("id_senderezepte_header_daten");

                entity.Property(e => e.HeaderUuid)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasColumnName("header_uuid")
                    .HasComment("Eindeutige Header - Universal Unique Identifier (UUID)");

                entity.Property(e => e.IdSenderezepteHeader).HasColumnName("id_senderezepte_header");

                entity.Property(e => e.TransferArz)
                    .HasColumnName("transfer_arz")
                    .HasDefaultValueSql("false")
                    .HasComment("Bestätigung vom ARZ - Transfer der Rezeptdaten erfolgt");

                entity.Property(e => e.XmlRequest)
                    .IsRequired()
                    .HasColumnName("xml_request")
                    .HasComment("Kompletter Original XML-Request der Apotheke - zur Weiterleitung ins ARZ");

                entity.HasOne(d => d.IdSenderezepteHeaderNavigation)
                    .WithMany(p => p.ErSenderezepteHeaderDatens)
                    .HasForeignKey(d => d.IdSenderezepteHeader)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("er_senderezepte_header_daten_id_senderezepte_header");
            });

            modelBuilder.Entity<ErSenderezeptePrezept>(entity =>
            {
                entity.HasKey(e => e.IdSenderezeptePrezept)
                    .HasName("er_senderezepte_prezept_pkey");

                entity.ToTable("er_senderezepte_prezept", "apoti");

                entity.HasIndex(e => new { e.RzLieferId, e.TransaktionsNummer }, "idx_er_sendrez_prez_rz_liefer_id");

                entity.HasIndex(e => new { e.TransaktionsNummer, e.RzLieferId }, "idx_er_sendrez_prez_transaktionsnummer");

                entity.Property(e => e.IdSenderezeptePrezept).HasColumnName("id_senderezepte_prezept");

                entity.Property(e => e.AbdaKassentyp)
                    .HasMaxLength(5)
                    .HasColumnName("abda_kassentyp")
                    .HasComment("kArt");

                entity.Property(e => e.Abgabedatum)
                    .HasColumnType("date")
                    .HasColumnName("abgabedatum")
                    .HasComment("abDatum");

                entity.Property(e => e.AbrechnungsPeriode)
                    .HasMaxLength(10)
                    .HasColumnName("abrechnungs_periode")
                    .HasComment("aPeriode");

                entity.Property(e => e.ApoIkNr)
                    .HasColumnName("apo_ik_nr")
                    .HasComment("apoIk");

                entity.Property(e => e.Arbeitsplatz)
                    .HasMaxLength(50)
                    .HasColumnName("arbeitsplatz")
                    .HasComment("arbPlatz");

                entity.Property(e => e.ArztNr)
                    .HasColumnName("arzt_nr")
                    .HasComment("laNr - Lebenslange Arzt-Nummer");

                entity.Property(e => e.AvsId)
                    .HasMaxLength(20)
                    .HasColumnName("avs_id");

                entity.Property(e => e.Bediener)
                    .HasMaxLength(50)
                    .HasColumnName("bediener");

                entity.Property(e => e.BetriebsstaettenNr)
                    .HasColumnName("betriebsstaetten_nr")
                    .HasComment("vrtrgsArztNr - Betriebsstättennummer oder Praxis-Nummer");

                entity.Property(e => e.ErstellungsZeitpunkt)
                    .HasMaxLength(30)
                    .HasColumnName("erstellungs_zeitpunkt")
                    .HasComment("erstellungsZeitpunkt");

                entity.Property(e => e.GesamtesBrutto)
                    .HasPrecision(11, 2)
                    .HasColumnName("gesamtes_brutto")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HashCode)
                    .HasMaxLength(40)
                    .HasColumnName("hash_code")
                    .HasComment("hashCode");

                entity.Property(e => e.IdSenderezepteHeader).HasColumnName("id_senderezepte_header");

                entity.Property(e => e.KkIkNr)
                    .HasColumnName("kk_ik_nr")
                    .HasComment("kkIk Krankenkassen-Ik der Versicherung");

                entity.Property(e => e.KkName)
                    .HasMaxLength(50)
                    .HasColumnName("kk_name")
                    .HasComment("kName");

                entity.Property(e => e.KkTyp)
                    .HasMaxLength(5)
                    .HasColumnName("kk_typ")
                    .HasComment("rTyp");

                entity.Property(e => e.KzBvg)
                    .HasColumnName("kz_bvg")
                    .HasDefaultValueSql("0")
                    .HasComment("bvg");

                entity.Property(e => e.KzGebuehrenFrei)
                    .HasColumnName("kz_gebuehren_frei")
                    .HasDefaultValueSql("0")
                    .HasComment("gebFrei");

                entity.Property(e => e.KzNoctu)
                    .HasColumnName("kz_noctu")
                    .HasDefaultValueSql("0")
                    .HasComment("noctu");

                entity.Property(e => e.KzSonstige)
                    .HasColumnName("kz_sonstige")
                    .HasDefaultValueSql("0")
                    .HasComment("sonstige");

                entity.Property(e => e.KzSprechstundenbedarf)
                    .HasColumnName("kz_sprechstundenbedarf")
                    .HasDefaultValueSql("0")
                    .HasComment("sprStBedarf");

                entity.Property(e => e.Ppos1Faktor)
                    .HasColumnName("ppos1_faktor")
                    .HasComment("pPosition1->faktor");

                entity.Property(e => e.Ppos1Pzn)
                    .HasColumnName("ppos1_pzn")
                    .HasComment("pPosition1->pzn");

                entity.Property(e => e.Ppos1Taxe)
                    .HasPrecision(11, 2)
                    .HasColumnName("ppos1_taxe")
                    .HasDefaultValueSql("0")
                    .HasComment("pPosition1->taxe");

                entity.Property(e => e.RezeptTyp)
                    .HasMaxLength(30)
                    .HasColumnName("rezept_typ")
                    .HasComment("Nur STANDARDREZEPT, BTM, SPRECHSTUNDENBEDARF");

                entity.Property(e => e.RzDatum)
                    .HasMaxLength(30)
                    .HasColumnName("rz_datum");

                entity.Property(e => e.RzLieferDatum)
                    .HasColumnType("date")
                    .HasColumnName("rz_liefer_datum");

                entity.Property(e => e.RzLieferId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("rz_liefer_id");

                entity.Property(e => e.RzLieferZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("rz_liefer_zeit");

                entity.Property(e => e.TransaktionsNummer)
                    .HasColumnName("transaktions_nummer")
                    .HasComment("transaktionsNummer");

                entity.Property(e => e.Verordnungsdatum)
                    .HasColumnType("date")
                    .HasColumnName("verordnungsdatum")
                    .HasComment("verDat - Ausstellungsdatum - Verordnungsdatum");

                entity.Property(e => e.VersichertenGeburtsdatum)
                    .HasColumnType("date")
                    .HasColumnName("versicherten_geburtsdatum")
                    .HasComment("vGeb");

                entity.Property(e => e.VersichertenNummer)
                    .HasMaxLength(12)
                    .HasColumnName("versicherten_nummer")
                    .HasComment("vrsNr");

                entity.Property(e => e.VersichertenStatus)
                    .HasMaxLength(5)
                    .HasColumnName("versicherten_status")
                    .HasComment("vStat");

                entity.Property(e => e.VersichertenkarteGueltigBis)
                    .HasMaxLength(10)
                    .HasColumnName("versichertenkarte_gueltig_bis")
                    .HasComment("vkGueltigBis");

                entity.Property(e => e.Zuzahlung)
                    .HasPrecision(11, 2)
                    .HasColumnName("zuzahlung")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdSenderezepteHeaderNavigation)
                    .WithMany(p => p.ErSenderezeptePrezepts)
                    .HasForeignKey(d => d.IdSenderezepteHeader)
                    .HasConstraintName("er_senderezepte_prezept_id_senderezepte_header");
            });

            modelBuilder.Entity<ErSenderezeptePrezeptDaten>(entity =>
            {
                entity.HasKey(e => e.IdSenderezeptePrezeptDaten)
                    .HasName("er_senderezepte_prezept_daten_pkey");

                entity.ToTable("er_senderezepte_prezept_daten", "apoti");

                entity.HasIndex(e => e.IdSenderezeptePrezept, "idx_er_sendrez_prez_daten_id");

                entity.Property(e => e.IdSenderezeptePrezeptDaten).HasColumnName("id_senderezepte_prezept_daten");

                entity.Property(e => e.IdSenderezeptePrezept).HasColumnName("id_senderezepte_prezept");

                entity.Property(e => e.RezeptUuid)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasColumnName("rezept_uuid")
                    .HasComment("Eindeutiger Rezept - Universal Unique Identifier (UUID)");

                entity.Property(e => e.TransferArz)
                    .HasColumnName("transfer_arz")
                    .HasDefaultValueSql("false")
                    .HasComment("Bestätigung vom ARZ - Transfer der Rezeptdaten erfolgt");

                entity.Property(e => e.XmlRequest)
                    .IsRequired()
                    .HasColumnName("xml_request")
                    .HasComment("Original XML-Request der Apotheke (nur Rezept-XML) - zur Weiterleitung ins ARZ");

                entity.HasOne(d => d.IdSenderezeptePrezeptNavigation)
                    .WithMany(p => p.ErSenderezeptePrezeptDatens)
                    .HasForeignKey(d => d.IdSenderezeptePrezept)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("er_senderezepte_prezept_daten_id_senderezepte_prezept");
            });

            modelBuilder.Entity<ErSenderezeptePrezeptPcharge>(entity =>
            {
                entity.HasKey(e => e.IdSenderezeptePrezeptPcharge)
                    .HasName("id_senderezepte_prez_pcharge_pkey");

                entity.ToTable("er_senderezepte_prezept_pcharge", "apoti");

                entity.HasIndex(e => e.IdSenderezeptePrezept, "idx_er_sendrez_prez_pch_prezid");

                entity.Property(e => e.IdSenderezeptePrezeptPcharge)
                    .HasColumnName("id_senderezepte_prezept_pcharge")
                    .HasDefaultValueSql("nextval('daten.er_senderezepte_prezept_pchar_id_senderezepte_prezept_pchar_seq'::regclass)");

                entity.Property(e => e.AnzahlApplikationen)
                    .HasColumnName("anzahl_applikationen")
                    .HasComment("anzahlApplikationen - Werte 1-99");

                entity.Property(e => e.ChargenNr)
                    .HasColumnName("chargen_nr")
                    .HasComment("chargenNr - Werte 1-99");

                entity.Property(e => e.HerstellerNr)
                    .HasColumnName("hersteller_nr")
                    .HasComment("herstellerNr - IK der Apotheke");

                entity.Property(e => e.HerstellerSchluessel)
                    .HasColumnName("hersteller_schluessel")
                    .HasComment("herstellerSchluessel - Werte 1|2|3|4");

                entity.Property(e => e.HerstellungsDatum)
                    .HasMaxLength(30)
                    .HasColumnName("herstellungs_datum")
                    .HasComment("herstellungsDatum Format 2011-08-19T11:37:04.000");

                entity.Property(e => e.IdSenderezeptePrezept).HasColumnName("id_senderezepte_prezept");

                entity.HasOne(d => d.IdSenderezeptePrezeptNavigation)
                    .WithMany(p => p.ErSenderezeptePrezeptPcharges)
                    .HasForeignKey(d => d.IdSenderezeptePrezept)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("er_senderezepte_prezept_pcharge_id_srez_prez_fkey");
            });

            modelBuilder.Entity<ErSenderezeptePrezeptPchargePwirkstoff>(entity =>
            {
                entity.HasKey(e => e.IdSenderezeptePrezeptPwirkstoff)
                    .HasName("er_senderezepte_prezept_pcharge_pwirkstoff_pkey");

                entity.ToTable("er_senderezepte_prezept_pcharge_pwirkstoff", "apoti");

                entity.HasIndex(e => e.IdSenderezeptePrezeptPcharge, "idx_er_sendrez_prez_pch_pwirk_pchid");

                entity.Property(e => e.IdSenderezeptePrezeptPwirkstoff)
                    .HasColumnName("id_senderezepte_prezept_pwirkstoff")
                    .HasDefaultValueSql("nextval('daten.er_senderezepte_prezept_pchar_id_senderezepte_prezept_pwirk_seq'::regclass)");

                entity.Property(e => e.Faktor)
                    .HasColumnName("faktor")
                    .HasComment("faktor");

                entity.Property(e => e.FaktorKennzeichen)
                    .HasMaxLength(2)
                    .HasColumnName("faktor_kennzeichen")
                    .HasComment("faktorKennzeichen");

                entity.Property(e => e.IdSenderezeptePrezeptPcharge).HasColumnName("id_senderezepte_prezept_pcharge");

                entity.Property(e => e.Notiz)
                    .HasMaxLength(130)
                    .HasColumnName("notiz")
                    .HasComment("notiz");

                entity.Property(e => e.PPosNr)
                    .HasColumnName("p_pos_nr")
                    .HasComment("pPosNr");

                entity.Property(e => e.PreisKennzeichen)
                    .HasMaxLength(2)
                    .HasColumnName("preis_kennzeichen")
                    .HasComment("preisKennzeichen");

                entity.Property(e => e.Pzn)
                    .HasColumnName("pzn")
                    .HasComment("pzn");

                entity.Property(e => e.Taxe)
                    .HasPrecision(11, 2)
                    .HasColumnName("taxe")
                    .HasDefaultValueSql("0")
                    .HasComment("taxe");

                entity.Property(e => e.WirkstoffName)
                    .HasMaxLength(130)
                    .HasColumnName("wirkstoff_name")
                    .HasComment("wirkstoffName");

                entity.HasOne(d => d.IdSenderezeptePrezeptPchargeNavigation)
                    .WithMany(p => p.ErSenderezeptePrezeptPchargePwirkstoffs)
                    .HasForeignKey(d => d.IdSenderezeptePrezeptPcharge)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("er_senderezepte_prez_pcharge_pwirk_id_senderezepte_prez_pch_fke");
            });

            modelBuilder.Entity<ErSenderezeptePrezeptStatus>(entity =>
            {
                entity.HasKey(e => e.IdSenderezeptePrezeptStatus)
                    .HasName("er_senderezepte_prezept_status_pkey");

                entity.ToTable("er_senderezepte_prezept_status", "apoti");

                entity.HasIndex(e => new { e.IdSenderezeptePrezept, e.TransaktionsNummer, e.RezeptStatus }, "idx_er_sendrez_prez_stat_idrezprez");

                entity.Property(e => e.IdSenderezeptePrezeptStatus)
                    .HasColumnName("id_senderezepte_prezept_status")
                    .HasDefaultValueSql("nextval('daten.er_senderezepte_prezept_statu_id_senderezepte_prezept_stat_seq1'::regclass)");

                entity.Property(e => e.AbrechenStatus)
                    .HasMaxLength(20)
                    .HasColumnName("abrechen_status")
                    .HasDefaultValueSql("'VOR_PRUEFUNG'::character varying")
                    .HasComment("Interner Status - enthält immer das Prüfergebnis");

                entity.Property(e => e.IdSenderezeptePrezept).HasColumnName("id_senderezepte_prezept");

                entity.Property(e => e.RezeptCheck)
                    .HasColumnName("rezept_check")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.RezeptStatus)
                    .HasMaxLength(20)
                    .HasColumnName("rezept_status")
                    .HasDefaultValueSql("'VOR_PRUEFUNG'::character varying");

                entity.Property(e => e.RzAbfrageId)
                    .HasMaxLength(20)
                    .HasColumnName("rz_abfrage_id")
                    .HasComment("ID mit der alle DS gekennzeichnet sind die innerhalb einer RCS Abfrage gesendet wurden");

                entity.Property(e => e.StatusAbfrageDatum)
                    .HasColumnType("date")
                    .HasColumnName("status_abfrage_datum")
                    .HasComment("Abfragedatum des Status zum Rezept");

                entity.Property(e => e.StatusAbfrageZeit)
                    .HasColumnType("time without time zone")
                    .HasColumnName("status_abfrage_zeit")
                    .HasComment("Abfragezeit des Status zum Rezept");

                entity.Property(e => e.TransaktionsNummer).HasColumnName("transaktions_nummer");

                entity.HasOne(d => d.IdSenderezeptePrezeptNavigation)
                    .WithMany(p => p.ErSenderezeptePrezeptStatuses)
                    .HasForeignKey(d => d.IdSenderezeptePrezept)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("er_senderezepte_prezept_status_id_senderezepte_prezept");
            });

            modelBuilder.Entity<ErSenderezeptePrezeptStatusinfo>(entity =>
            {
                entity.HasKey(e => e.IdSenderezeptePrezeptStatusinfo)
                    .HasName("er_senderezepte_prezept_statusinfo_pkey");

                entity.ToTable("er_senderezepte_prezept_statusinfo", "apoti");

                entity.HasIndex(e => e.IdSenderezeptePrezept, "idx_er_sendrez_prez_stinfo_id");

                entity.Property(e => e.IdSenderezeptePrezeptStatusinfo)
                    .HasColumnName("id_senderezepte_prezept_statusinfo")
                    .HasDefaultValueSql("nextval('daten.er_senderezepte_prezept_statu_id_senderezepte_prezept_statu_seq'::regclass)");

                entity.Property(e => e.Fcode)
                    .HasMaxLength(4)
                    .HasColumnName("fcode");

                entity.Property(e => e.Fkommentar).HasColumnName("fkommentar");

                entity.Property(e => e.Fkurztext).HasColumnName("fkurztext");

                entity.Property(e => e.Fstatus)
                    .HasMaxLength(20)
                    .HasColumnName("fstatus");

                entity.Property(e => e.Ftcode)
                    .HasMaxLength(3)
                    .HasColumnName("ftcode");

                entity.Property(e => e.IdSenderezeptePrezept).HasColumnName("id_senderezepte_prezept");

                entity.Property(e => e.Posnr).HasColumnName("posnr");

                entity.Property(e => e.RegelNr)
                    .HasMaxLength(10)
                    .HasColumnName("regel_nr");

                entity.Property(e => e.RegelTrefferCode)
                    .HasMaxLength(7)
                    .HasColumnName("regel_treffer_code");

                entity.HasOne(d => d.IdSenderezeptePrezeptNavigation)
                    .WithMany(p => p.ErSenderezeptePrezeptStatusinfos)
                    .HasForeignKey(d => d.IdSenderezeptePrezept)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("er_senderezepte_prezept_statusinfo_id_senderezepte_prezept");
            });

            modelBuilder.Entity<ErSonderPzn>(entity =>
            {
                entity.HasKey(e => e.IdSonderPzn)
                    .HasName("er_sonder_pzn_temp_pkey");

                entity.ToTable("er_sonder_pzn", "apoti");

                entity.HasIndex(e => new { e.SonderPzn, e.GueltigAb, e.GueltigBis }, "idx_er_sonder_pzn_sonderpzn_gueltigabbis_20191024");

                entity.Property(e => e.IdSonderPzn).HasColumnName("id_sonder_pzn");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(1000)
                    .HasColumnName("beschreibung");

                entity.Property(e => e.BeschreibungKurz)
                    .HasMaxLength(200)
                    .HasColumnName("beschreibung_kurz");

                entity.Property(e => e.GueltigAb)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_ab");

                entity.Property(e => e.GueltigBis)
                    .HasColumnType("date")
                    .HasColumnName("gueltig_bis");

                entity.Property(e => e.Kommentar)
                    .HasMaxLength(1000)
                    .HasColumnName("kommentar");

                entity.Property(e => e.SonderPzn).HasColumnName("sonder_pzn");

                entity.Property(e => e.Ust).HasColumnName("ust");
            });

            modelBuilder.Entity<ErUsecase>(entity =>
            {
                entity.HasKey(e => e.IdUsecase)
                    .HasName("er_usecase_pkey");

                entity.ToTable("er_usecase", "apoti");

                entity.HasIndex(e => new { e.MainUcNr, e.SubUcNr }, "idx_uc_mucnr_sucnr");

                entity.Property(e => e.IdUsecase).HasColumnName("id_usecase");

                entity.Property(e => e.Beschreibung).HasColumnName("beschreibung");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(25)
                    .HasColumnName("bezeichnung");

                entity.Property(e => e.Freigegeben)
                    .HasColumnName("freigegeben")
                    .HasComment("Freigabe von AVC (Rechenzentrum)");

                entity.Property(e => e.MainUc).HasColumnName("main_uc");

                entity.Property(e => e.MainUcId)
                    .HasColumnName("main_uc_id")
                    .HasComment("wenn sub_uc - die id_usecase des Main UC");

                entity.Property(e => e.MainUcNr).HasColumnName("main_uc_nr");

                entity.Property(e => e.Option)
                    .HasMaxLength(20)
                    .HasColumnName("option")
                    .HasComment("z.B. synchron oder asynchron");

                entity.Property(e => e.SubUc).HasColumnName("sub_uc");

                entity.Property(e => e.SubUcNr)
                    .HasColumnName("sub_uc_nr")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.HasSequence("er_fiverx_schema_id_fiverx_schema_seq", "apoti");

            modelBuilder.HasSequence("er_senderezepte_prezept_pwirk_id_senderezepte_prezept_pwirk_seq", "apoti");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
