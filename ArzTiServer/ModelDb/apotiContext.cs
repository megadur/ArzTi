using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ArzTiServer.ModelDb
{
    public partial class apotiContext : DbContext
    {
        public apotiContext()
        {
        }

        public apotiContext(DbContextOptions<apotiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ErApotheke> ErApothekes { get; set; }
        public virtual DbSet<ErFiverxVersion> ErFiverxVersions { get; set; }
        public virtual DbSet<ErSecAccessFiverx> ErSecAccessFiverxes { get; set; }
        public virtual DbSet<ErSenderezepteEmuster16> ErSenderezepteEmuster16s { get; set; }
        public virtual DbSet<ErSenderezepteEmuster16Artikel> ErSenderezepteEmuster16Artikels { get; set; }
        public virtual DbSet<ErSenderezepteEmuster16Daten> ErSenderezepteEmuster16Datens { get; set; }
        public virtual DbSet<ErSenderezepteEmuster16Lieferid> ErSenderezepteEmuster16Lieferids { get; set; }
        public virtual DbSet<ErSenderezepteEmuster16Status> ErSenderezepteEmuster16Statuses { get; set; }
        public virtual DbSet<ErSenderezepteEmuster16Statusinfo> ErSenderezepteEmuster16Statusinfos { get; set; }
        public virtual DbSet<ErSenderezepteErezept> ErSenderezepteErezepts { get; set; }
        public virtual DbSet<ErSenderezepteErezeptDaten> ErSenderezepteErezeptDatens { get; set; }
        public virtual DbSet<ErSenderezepteErezeptLieferid> ErSenderezepteErezeptLieferids { get; set; }
        public virtual DbSet<ErSenderezepteErezeptStatus> ErSenderezepteErezeptStatuses { get; set; }
        public virtual DbSet<ErSenderezepteErezeptStatusinfo> ErSenderezepteErezeptStatusinfos { get; set; }
        public virtual DbSet<ErSenderezepteHeader> ErSenderezepteHeaders { get; set; }
        public virtual DbSet<ErSenderezeptePrezept> ErSenderezeptePrezepts { get; set; }
        public virtual DbSet<ErSenderezeptePrezeptDaten> ErSenderezeptePrezeptDatens { get; set; }
        public virtual DbSet<ErSenderezeptePrezeptLieferid> ErSenderezeptePrezeptLieferids { get; set; }
        public virtual DbSet<ErSenderezeptePrezeptPcharge> ErSenderezeptePrezeptPcharges { get; set; }
        public virtual DbSet<ErSenderezeptePrezeptPchargePwirkstoff> ErSenderezeptePrezeptPchargePwirkstoffs { get; set; }
        public virtual DbSet<ErSenderezeptePrezeptStatus> ErSenderezeptePrezeptStatuses { get; set; }
        public virtual DbSet<ErSenderezeptePrezeptStatusinfo> ErSenderezeptePrezeptStatusinfos { get; set; }
        public virtual DbSet<ErUsecase> ErUsecases { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Username=postgres;Password=postgres;Server=localhost;Port=5432;Database=apoti;Integrated Security=true;Pooling=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.utf8");

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
                    .HasComment("Seurity-Login nur fÃ¼r Apotheken-Benutzer - F-nein, T-ja");

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
                    .HasComment("grance Periode - Version wird unterstÃ¼tzt bis zu diesem Datum");

                entity.Property(e => e.FiverxVersion)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("fiverx_version");

                entity.Property(e => e.Schemadatei)
                    .HasMaxLength(45)
                    .HasColumnName("schemadatei");
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
            });

            modelBuilder.Entity<ErSenderezepteEmuster16Artikel>(entity =>
            {
                entity.HasKey(e => e.IdSenderezepteEmuster16Artikel)
                    .HasName("er_senderezepte_emuster16_artikel_pkey");

                entity.ToTable("er_senderezepte_emuster16_artikel", "apoti");

                entity.HasIndex(e => e.IdSenderezepteEmuster16, "idx_er_sendrez_em16_artikel_id");

                entity.Property(e => e.IdSenderezepteEmuster16Artikel)
                    .HasColumnName("id_senderezepte_emuster16_artikel")
                    .HasDefaultValueSql("nextval('apoti.er_senderezepte_emuster16_art_id_senderezepte_emuster16_art_seq'::regclass)");

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
                    .HasDefaultValueSql("nextval('apoti.er_senderezepte_emuster16_dat_id_senderezepte_emuster16_dat_seq'::regclass)");

                entity.Property(e => e.IdSenderezepteEmuster16).HasColumnName("id_senderezepte_emuster16");

                entity.Property(e => e.RezeptGuid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("rezept_guid");

                entity.Property(e => e.TransferArz)
                    .HasColumnName("transfer_arz")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.XmlRequest)
                    .IsRequired()
                    .HasColumnName("xml_request");

                entity.HasOne(d => d.IdSenderezepteEmuster16Navigation)
                    .WithMany(p => p.ErSenderezepteEmuster16Datens)
                    .HasForeignKey(d => d.IdSenderezepteEmuster16)
                    .HasConstraintName("er_senderezepte_emuster16_daten_id_senderezepte_emuster16");
            });

            modelBuilder.Entity<ErSenderezepteEmuster16Lieferid>(entity =>
            {
                entity.HasKey(e => new { e.IdSenderezepteEmuster16, e.IdSenderezepteHeader })
                    .HasName("er_senderezepte_emuster16_lieferid_pkey");

                entity.ToTable("er_senderezepte_emuster16_lieferid", "apoti");

                entity.Property(e => e.IdSenderezepteEmuster16).HasColumnName("id_senderezepte_emuster16");

                entity.Property(e => e.IdSenderezepteHeader).HasColumnName("id_senderezepte_header");

                entity.HasOne(d => d.IdSenderezepteEmuster16Navigation)
                    .WithMany(p => p.ErSenderezepteEmuster16Lieferids)
                    .HasForeignKey(d => d.IdSenderezepteEmuster16)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("er_senderezepte_emuster16_lieferid_id_senderezepte_emuster16");

                entity.HasOne(d => d.IdSenderezepteHeaderNavigation)
                    .WithMany(p => p.ErSenderezepteEmuster16Lieferids)
                    .HasForeignKey(d => d.IdSenderezepteHeader)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("er_senderezepte_emuster16_lieferid_id_senderezepte_header");
            });

            modelBuilder.Entity<ErSenderezepteEmuster16Status>(entity =>
            {
                entity.HasKey(e => e.IdSenderezepteEmuster16Status)
                    .HasName("er_senderezepte_emuster16_status_pkey");

                entity.ToTable("er_senderezepte_emuster16_status", "apoti");

                entity.HasIndex(e => new { e.IdSenderezepteEmuster16, e.Muster16Id, e.RezeptStatus }, "idx_er_sendrez_em16_stat_idrezem16");

                entity.Property(e => e.IdSenderezepteEmuster16Status)
                    .HasColumnName("id_senderezepte_emuster16_status")
                    .HasDefaultValueSql("nextval('apoti.er_senderezepte_emuster16_sta_id_senderezepte_emuster16_sta_seq'::regclass)");

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
                    .HasDefaultValueSql("nextval('apoti.er_senderezepte_emuster16_sta_id_senderezepte_emuster16_st_seq1'::regclass)");

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

                entity.Property(e => e.AvsId)
                    .HasMaxLength(20)
                    .HasColumnName("avs_id");

                entity.Property(e => e.ErezeptData)
                    .HasColumnName("erezept_data")
                    .HasComment("Base64 Codierung der eRezept Daten");

                entity.Property(e => e.ErezeptId)
                    .HasMaxLength(255)
                    .HasColumnName("erezept_id");

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

            modelBuilder.Entity<ErSenderezepteErezeptDaten>(entity =>
            {
                entity.HasKey(e => e.IdSenderezepteErezeptDaten)
                    .HasName("er_senderezepte_erezept_daten_pkey");

                entity.ToTable("er_senderezepte_erezept_daten", "apoti");

                entity.HasIndex(e => e.IdSenderezepteErezept, "idx_er_sendrez_erez_daten_id");

                entity.Property(e => e.IdSenderezepteErezeptDaten).HasColumnName("id_senderezepte_erezept_daten");

                entity.Property(e => e.IdSenderezepteErezept).HasColumnName("id_senderezepte_erezept");

                entity.Property(e => e.RezeptGuid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("rezept_guid");

                entity.Property(e => e.TransferArz)
                    .HasColumnName("transfer_arz")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.XmlRequest)
                    .IsRequired()
                    .HasColumnName("xml_request");

                entity.HasOne(d => d.IdSenderezepteErezeptNavigation)
                    .WithMany(p => p.ErSenderezepteErezeptDatens)
                    .HasForeignKey(d => d.IdSenderezepteErezept)
                    .HasConstraintName("er_senderezepte_erezept_daten_id_senderezepte_erezept");
            });

            modelBuilder.Entity<ErSenderezepteErezeptLieferid>(entity =>
            {
                entity.HasKey(e => new { e.IdSenderezepteErezept, e.IdSenderezepteHeader })
                    .HasName("er_senderezepte_erezept_lieferid_pkey");

                entity.ToTable("er_senderezepte_erezept_lieferid", "apoti");

                entity.Property(e => e.IdSenderezepteErezept).HasColumnName("id_senderezepte_erezept");

                entity.Property(e => e.IdSenderezepteHeader).HasColumnName("id_senderezepte_header");

                entity.HasOne(d => d.IdSenderezepteErezeptNavigation)
                    .WithMany(p => p.ErSenderezepteErezeptLieferids)
                    .HasForeignKey(d => d.IdSenderezepteErezept)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("er_senderezepte_erezept_lieferid_id_senderezepte_prezept");

                entity.HasOne(d => d.IdSenderezepteHeaderNavigation)
                    .WithMany(p => p.ErSenderezepteErezeptLieferids)
                    .HasForeignKey(d => d.IdSenderezepteHeader)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("er_senderezepte_erezept_lieferid_id_senderezepte_header");
            });

            modelBuilder.Entity<ErSenderezepteErezeptStatus>(entity =>
            {
                entity.HasKey(e => e.IdSenderezepteErezeptStatus)
                    .HasName("er_senderezepte_erezept_status_pkey");

                entity.ToTable("er_senderezepte_erezept_status", "apoti");

                entity.HasIndex(e => new { e.IdSenderezepteErezept, e.TransaktionsNummer, e.RezeptStatus }, "idx_er_sendrez_erez_stat_idrezerez");

                entity.Property(e => e.IdSenderezepteErezeptStatus)
                    .HasColumnName("id_senderezepte_erezept_status")
                    .HasDefaultValueSql("nextval('apoti.er_senderezepte_erezept_statu_id_senderezepte_erezept_statu_seq'::regclass)");

                entity.Property(e => e.AbrechenStatus)
                    .HasMaxLength(20)
                    .HasColumnName("abrechen_status")
                    .HasDefaultValueSql("'VOR_PRUEFUNG'::character varying")
                    .HasComment("Interner Status - enthält immer das Prüfergebnis");

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

                entity.Property(e => e.TransaktionsNummer).HasColumnName("transaktions_nummer");

                entity.HasOne(d => d.IdSenderezepteErezeptNavigation)
                    .WithMany(p => p.ErSenderezepteErezeptStatuses)
                    .HasForeignKey(d => d.IdSenderezepteErezept)
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
                    .HasDefaultValueSql("nextval('apoti.er_senderezepte_erezept_statu_id_senderezepte_erezept_stat_seq1'::regclass)");

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
            });

            modelBuilder.Entity<ErSenderezeptePrezeptDaten>(entity =>
            {
                entity.HasKey(e => e.IdSenderezeptePrezeptDaten)
                    .HasName("er_senderezepte_prezept_daten_pkey");

                entity.ToTable("er_senderezepte_prezept_daten", "apoti");

                entity.HasIndex(e => e.IdSenderezeptePrezept, "idx_er_sendrez_prez_daten_id");

                entity.Property(e => e.IdSenderezeptePrezeptDaten).HasColumnName("id_senderezepte_prezept_daten");

                entity.Property(e => e.IdSenderezeptePrezept).HasColumnName("id_senderezepte_prezept");

                entity.Property(e => e.RezeptGuid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("rezept_guid");

                entity.Property(e => e.TransferArz)
                    .HasColumnName("transfer_arz")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.XmlRequest)
                    .IsRequired()
                    .HasColumnName("xml_request");

                entity.HasOne(d => d.IdSenderezeptePrezeptNavigation)
                    .WithMany(p => p.ErSenderezeptePrezeptDatens)
                    .HasForeignKey(d => d.IdSenderezeptePrezept)
                    .HasConstraintName("er_senderezepte_prezept_daten_id_senderezepte_prezept");
            });

            modelBuilder.Entity<ErSenderezeptePrezeptLieferid>(entity =>
            {
                entity.HasKey(e => new { e.IdSenderezeptePrezept, e.IdSenderezepteHeader })
                    .HasName("er_senderezepte_prezept_lieferid_pkey");

                entity.ToTable("er_senderezepte_prezept_lieferid", "apoti");

                entity.HasIndex(e => new { e.IdSenderezeptePrezept, e.IdSenderezepteHeader }, "idx_er_sendrez_prez_lid_rezid_headid")
                    .IsUnique();

                entity.Property(e => e.IdSenderezeptePrezept).HasColumnName("id_senderezepte_prezept");

                entity.Property(e => e.IdSenderezepteHeader).HasColumnName("id_senderezepte_header");

                entity.HasOne(d => d.IdSenderezepteHeaderNavigation)
                    .WithMany(p => p.ErSenderezeptePrezeptLieferids)
                    .HasForeignKey(d => d.IdSenderezepteHeader)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("er_senderezepte_prezept_lieferid_id_senderezepte_header");

                entity.HasOne(d => d.IdSenderezeptePrezeptNavigation)
                    .WithMany(p => p.ErSenderezeptePrezeptLieferids)
                    .HasForeignKey(d => d.IdSenderezeptePrezept)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("er_senderezepte_prezept_lieferid_id_senderezepte_prezept");
            });

            modelBuilder.Entity<ErSenderezeptePrezeptPcharge>(entity =>
            {
                entity.HasKey(e => e.IdSenderezeptePrezeptPcharge)
                    .HasName("id_senderezepte_prez_pcharge_pkey");

                entity.ToTable("er_senderezepte_prezept_pcharge", "apoti");

                entity.HasIndex(e => e.IdSenderezeptePrezept, "idx_er_sendrez_prez_pch_prezid");

                entity.Property(e => e.IdSenderezeptePrezeptPcharge)
                    .HasColumnName("id_senderezepte_prezept_pcharge")
                    .HasDefaultValueSql("nextval('apoti.er_senderezepte_prezept_pchar_id_senderezepte_prezept_pchar_seq'::regclass)");

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
                    .HasDefaultValueSql("nextval('apoti.er_senderezepte_prezept_pchar_id_senderezepte_prezept_pwirk_seq'::regclass)");

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
                    .HasDefaultValueSql("nextval('apoti.er_senderezepte_prezept_statu_id_senderezepte_prezept_stat_seq1'::regclass)");

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
                    .HasDefaultValueSql("nextval('apoti.er_senderezepte_prezept_statu_id_senderezepte_prezept_statu_seq'::regclass)");

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
                    .HasConstraintName("er_senderezepte_prezept_statusinfo_id_senderezepte_prezept");
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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
