using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FirmaTel.FirmaBasa;

public partial class FirmaDbContext : DbContext
{
    public FirmaDbContext()
    {
    }

    public FirmaDbContext(DbContextOptions<FirmaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Abonnent> Abonnents { get; set; }

    public virtual DbSet<Gorodum> Goroda { get; set; }

    public virtual DbSet<Peregovory> Peregovories { get; set; }

    public virtual DbSet<Skidki> Skidkis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user id=root;password=12345;database=FirmaDB", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.36-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Abonnent>(entity =>
        {
            entity.HasKey(e => e.KodAbonenta).HasName("PRIMARY");

            entity.ToTable("abonnents");

            entity.Property(e => e.KodAbonenta)
                .ValueGeneratedNever()
                .HasColumnName("Kod_abonenta");
            entity.Property(e => e.Adres).HasMaxLength(255);
            entity.Property(e => e.Inn)
                .HasMaxLength(12)
                .HasColumnName("INN");
            entity.Property(e => e.NomberTelefona)
                .HasMaxLength(15)
                .HasColumnName("Nomber_telefona");
        });

        modelBuilder.Entity<Gorodum>(entity =>
        {
            entity.HasKey(e => e.KodGoroda).HasName("PRIMARY");

            entity.ToTable("goroda");

            entity.Property(e => e.KodGoroda)
                .ValueGeneratedNever()
                .HasColumnName("Kod_goroda");
            entity.Property(e => e.Nazvanie).HasMaxLength(255);
            entity.Property(e => e.TarifDnevnoy)
                .HasPrecision(5, 2)
                .HasColumnName("Tarif_dnevnoy");
            entity.Property(e => e.TarifNochnoy)
                .HasPrecision(5, 2)
                .HasColumnName("Tarif_nochnoy");
        });

        modelBuilder.Entity<Peregovory>(entity =>
        {
            entity.HasKey(e => e.KodPeregovorov).HasName("PRIMARY");

            entity.ToTable("peregovory");

            entity.HasIndex(e => e.KodAbonenta, "Kod_abonenta");

            entity.HasIndex(e => e.KodGoroda, "Kod_goroda");

            entity.Property(e => e.KodPeregovorov).HasColumnName("Kod_peregovorov");
            entity.Property(e => e.KodAbonenta).HasColumnName("Kod_abonenta");
            entity.Property(e => e.KodGoroda).HasColumnName("Kod_goroda");
            entity.Property(e => e.KolichestvoMinut).HasColumnName("Kolichestvo_minut");
            entity.Property(e => e.VremyaSutok)
                .HasMaxLength(255)
                .HasColumnName("Vremya_sutok");

            entity.HasOne(d => d.KodAbonentaNavigation).WithMany(p => p.Peregovories)
                .HasForeignKey(d => d.KodAbonenta)
                .HasConstraintName("peregovory_ibfk_1");

            entity.HasOne(d => d.KodGorodaNavigation).WithMany(p => p.Peregovories)
                .HasForeignKey(d => d.KodGoroda)
                .HasConstraintName("peregovory_ibfk_2");
        });

        modelBuilder.Entity<Skidki>(entity =>
        {
            entity.HasKey(e => e.KodGoroda).HasName("PRIMARY");

            entity.ToTable("skidki");

            entity.Property(e => e.KodGoroda)
                .ValueGeneratedOnAdd()
                .HasColumnName("Kod_goroda");
            entity.Property(e => e.Skidka).HasPrecision(5, 2);

            entity.HasOne(d => d.KodGorodaNavigation).WithOne(p => p.Skidki)
                .HasForeignKey<Skidki>(d => d.KodGoroda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("skidki_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
