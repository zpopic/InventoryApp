using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InventoryApp.Models
{
    public partial class inventoryContext : IdentityDbContext<IdentityUser>
    {
        public inventoryContext()
        {
        }

        public inventoryContext(DbContextOptions<inventoryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Artikl> Artikl { get; set; }
        public virtual DbSet<ArtiklAudit> ArtiklAudit { get; set; }
        public virtual DbSet<Aspnetroleclaims> Aspnetroleclaims { get; set; }
        public virtual DbSet<Aspnetroles> Aspnetroles { get; set; }
        public virtual DbSet<Aspnetuserclaims> Aspnetuserclaims { get; set; }
        public virtual DbSet<Aspnetuserlogins> Aspnetuserlogins { get; set; }
        public virtual DbSet<Aspnetuserroles> Aspnetuserroles { get; set; }
        public virtual DbSet<Aspnetusers> Aspnetusers { get; set; }
        public virtual DbSet<Aspnetusertokens> Aspnetusertokens { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistory { get; set; }
        public virtual DbSet<Izvedba> Izvedba { get; set; }
        public virtual DbSet<IzvedbaAudit> IzvedbaAudit { get; set; }
        public virtual DbSet<Kategorija> Kategorija { get; set; }
        public virtual DbSet<KategorijaAudit> KategorijaAudit { get; set; }
        public virtual DbSet<Skladiste> Skladiste { get; set; }
        public virtual DbSet<SkladisteAudit> SkladisteAudit { get; set; }
        public virtual DbSet<Tip> Tip { get; set; }
        public virtual DbSet<TipAudit> TipAudit { get; set; }
        public virtual DbSet<Vrsta> Vrsta { get; set; }
        public virtual DbSet<VrstaAudit> VrstaAudit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseMySQL("Server=localhost;Database=inventory;UID=zpopic;PWD=PleiadE974");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Artikl>(entity =>
            {
                entity.ToTable("artikl");

                entity.HasComment("					");

                entity.HasIndex(e => e.IzvedbaId)
                    .HasName("fk_artikl1_idx");

                entity.HasIndex(e => e.KategorijaId)
                    .HasName("fk_artikl4_idx");

                entity.HasIndex(e => e.TipId)
                    .HasName("fk_artikl2_idx");

                entity.HasIndex(e => e.VrstaId)
                    .HasName("fk_artikl3_idx");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AktualnoStanje)
                    .HasColumnName("aktualno_stanje")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Ident)
                    .HasColumnName("ident")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Izlaz)
                    .HasColumnName("izlaz")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IzvedbaId)
                    .HasColumnName("izvedba_Id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.KategorijaId)
                    .HasColumnName("kategorija_Id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Napomena)
                    .HasColumnName("napomena")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PocetnoStanje)
                    .HasColumnName("pocetno_stanje")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TipId)
                    .HasColumnName("tip_Id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Ulaz)
                    .HasColumnName("ulaz")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UsrChanged)
                    .HasColumnName("usr_changed")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.VrstaId)
                    .HasColumnName("vrsta_Id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ZavrsnoStanje)
                    .HasColumnName("zavrsno_stanje")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.Izvedba)
                    .WithMany(p => p.Artikl)
                    .HasForeignKey(d => d.IzvedbaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_artikl1");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Artikl)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_artikl4");

                entity.HasOne(d => d.Tip)
                    .WithMany(p => p.Artikl)
                    .HasForeignKey(d => d.TipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_artikl2");

                entity.HasOne(d => d.Vrsta)
                    .WithMany(p => p.Artikl)
                    .HasForeignKey(d => d.VrstaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_artikl3");
            });

            modelBuilder.Entity<ArtiklAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("artikl_audit");

                entity.Property(e => e.AktualnoStanje)
                    .HasColumnName("aktualno_stanje")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("change_type")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EditTime)
                    .HasColumnName("edit_time")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Izlaz)
                    .HasColumnName("izlaz")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Napomena)
                    .HasColumnName("napomena")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PocetnoStanje)
                    .HasColumnName("pocetno_stanje")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Ulaz)
                    .HasColumnName("ulaz")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UsrChanged)
                    .HasColumnName("usr_changed")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ZavrsnoStanje)
                    .HasColumnName("zavrsno_stanje")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Aspnetroleclaims>(entity =>
            {
                entity.ToTable("aspnetroleclaims");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClaimType).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClaimValue).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetroleclaims)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");
            });

            modelBuilder.Entity<Aspnetroles>(entity =>
            {
                entity.ToTable("aspnetroles");

                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ConcurrencyStamp).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Name)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NormalizedName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Aspnetuserclaims>(entity =>
            {
                entity.ToTable("aspnetuserclaims");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserClaims_UserId1");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClaimType).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClaimValue).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserclaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserClaims_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserlogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey })
                    .HasName("PRIMARY");

                entity.ToTable("aspnetuserlogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderKey)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderDisplayName).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserlogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserLogins_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserroles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PRIMARY");

                entity.ToTable("aspnetuserroles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetUserRoles_RoleId");

                entity.Property(e => e.UserId)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetusers>(entity =>
            {
                entity.ToTable("aspnetusers");

                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.AccessFailedCount).HasColumnType("int(11)");

                entity.Property(e => e.ConcurrencyStamp).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmailConfirmed).HasColumnType("bit(1)");

                entity.Property(e => e.LockoutEnabled).HasColumnType("bit(1)");

                entity.Property(e => e.LockoutEnd).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NormalizedEmail)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NormalizedUserName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PasswordHash).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PhoneNumber).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PhoneNumberConfirmed).HasColumnType("bit(1)");

                entity.Property(e => e.SecurityStamp).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TwoFactorEnabled).HasColumnType("bit(1)");

                entity.Property(e => e.UserName)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Aspnetusertokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name })
                    .HasName("PRIMARY");

                entity.ToTable("aspnetusertokens");

                entity.Property(e => e.UserId)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.LoginProvider)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetusertokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserTokens_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Izvedba>(entity =>
            {
                entity.ToTable("izvedba");

                entity.HasIndex(e => e.KategorijaId)
                    .HasName("fk_izvedba3_idx");

                entity.HasIndex(e => e.TipId)
                    .HasName("fk_izvedba1_idx");

                entity.HasIndex(e => e.VrstaId)
                    .HasName("fk_izvedba2_idx");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.KategorijaId)
                    .HasColumnName("kategorija_Id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasColumnName("naziv")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .HasColumnName("opis")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TipId)
                    .HasColumnName("tip_Id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UsrChanged)
                    .HasColumnName("usr_changed")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.VrstaId)
                    .HasColumnName("vrsta_Id")
                    .HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Izvedba)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_izvedba3");

                entity.HasOne(d => d.Tip)
                    .WithMany(p => p.Izvedba)
                    .HasForeignKey(d => d.TipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_izvedba1");

                entity.HasOne(d => d.Vrsta)
                    .WithMany(p => p.Izvedba)
                    .HasForeignKey(d => d.VrstaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_izvedba2");
            });

            modelBuilder.Entity<IzvedbaAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("izvedba_audit");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("change_type")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EditTime)
                    .HasColumnName("edit_time")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Naziv)
                    .HasColumnName("naziv")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Opis)
                    .HasColumnName("opis")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UsrChanged)
                    .HasColumnName("usr_changed")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Kategorija>(entity =>
            {
                entity.ToTable("kategorija");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasColumnName("naziv")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .HasColumnName("opis")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UsrChanged)
                    .HasColumnName("usr_changed")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<KategorijaAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kategorija_audit");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("change_type")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EditTime)
                    .HasColumnName("edit_time")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Naziv)
                    .HasColumnName("naziv")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Opis)
                    .HasColumnName("opis")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UsrChanged)
                    .HasColumnName("usr_changed")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Skladiste>(entity =>
            {
                entity.ToTable("skladiste");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .HasColumnName("opis")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UsrChanged)
                    .HasColumnName("usr_changed")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<SkladisteAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("skladiste_audit");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("change_type")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EditTime)
                    .HasColumnName("edit_time")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Naziv)
                    .HasColumnName("naziv")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Opis)
                    .HasColumnName("opis")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UsrChanged)
                    .HasColumnName("usr_changed")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Tip>(entity =>
            {
                entity.ToTable("tip");

                entity.HasIndex(e => e.KategorijaId)
                    .HasName("fk_tip2_idx");

                entity.HasIndex(e => e.VrstaId)
                    .HasName("fk_tip1_idx");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.KategorijaId)
                    .HasColumnName("kategorija_Id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasColumnName("naziv")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .HasColumnName("opis")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UsrChanged)
                    .HasColumnName("usr_changed")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.VrstaId)
                    .HasColumnName("vrsta_Id")
                    .HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Tip)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tip2");

                entity.HasOne(d => d.Vrsta)
                    .WithMany(p => p.Tip)
                    .HasForeignKey(d => d.VrstaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tip1");
            });

            modelBuilder.Entity<TipAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tip_audit");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("change_type")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EditTime)
                    .HasColumnName("edit_time")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Naziv)
                    .HasColumnName("naziv")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Opis)
                    .HasColumnName("opis")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UsrChanged)
                    .HasColumnName("usr_changed")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Vrsta>(entity =>
            {
                entity.ToTable("vrsta");

                entity.HasIndex(e => e.KategorijaId)
                    .HasName("fk_vrsta_kategorija1_idx");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.KategorijaId)
                    .HasColumnName("kategorija_Id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasColumnName("naziv")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .HasColumnName("opis")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UsrChanged)
                    .HasColumnName("usr_changed")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Vrsta)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vrsta_kategorija1");
            });

            modelBuilder.Entity<VrstaAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vrsta_audit");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("change_type")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EditTime)
                    .HasColumnName("edit_time")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Naziv)
                    .HasColumnName("naziv")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Opis)
                    .HasColumnName("opis")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UsrChanged)
                    .HasColumnName("usr_changed")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
