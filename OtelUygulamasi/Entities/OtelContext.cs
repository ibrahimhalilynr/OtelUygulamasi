using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OtelUygulamasi.Entities;

public partial class OtelContext : DbContext
{
    public OtelContext()
    {
    }

    public OtelContext(DbContextOptions<OtelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Guvenliksifresi> Guvenliksifresis { get; set; }

    public virtual DbSet<Musteri> Musteris { get; set; }

    public virtual DbSet<Odum> Oda { get; set; }

    public virtual DbSet<Rezervasyon> Rezervasyons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ESMANUR\\SQLEXPRESS;Database=otel;Trusted_Connection=True; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Guvenliksifresi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("guvenliksifresi");

            entity.Property(e => e.Guvenliksifresi1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Guvenliksifresi");
        });

        modelBuilder.Entity<Musteri>(entity =>
        {
            entity.ToTable("musteri");

            entity.Property(e => e.Musteriid).HasColumnName("musteriid");
            entity.Property(e => e.Ad)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("ad");
            entity.Property(e => e.Adres)
                .HasMaxLength(300)
                .IsFixedLength()
                .HasColumnName("adres");
            entity.Property(e => e.Soyad)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("soyad");
            entity.Property(e => e.Tc)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("tc");
            entity.Property(e => e.Telefon)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("telefon");
        });

        modelBuilder.Entity<Odum>(entity =>
        {
            entity.HasKey(e => e.Odaid);

            entity.ToTable("oda");

            entity.Property(e => e.Odaid).HasColumnName("odaid");
            entity.Property(e => e.Durum).HasColumnName("durum");
            entity.Property(e => e.Fiyat)
                .HasColumnType("money")
                .HasColumnName("fiyat");
            entity.Property(e => e.Kat).HasColumnName("kat");
            entity.Property(e => e.Odano).HasColumnName("odano");
            entity.Property(e => e.YatakSayisi).HasColumnName("yatak sayisi");
        });

        modelBuilder.Entity<Rezervasyon>(entity =>
        {
            entity.ToTable("rezervasyon");

            entity.Property(e => e.Rezervasyonid).HasColumnName("rezervasyonid");
            entity.Property(e => e.Cikistarihi).HasColumnName("cikistarihi");
            entity.Property(e => e.Giristarihi).HasColumnName("giristarihi");
            entity.Property(e => e.Musteriid).HasColumnName("musteriid");
            entity.Property(e => e.Odaid).HasColumnName("odaid");
            entity.Property(e => e.Toplamucret)
                .HasColumnType("money")
                .HasColumnName("toplamucret");

            entity.HasOne(d => d.Musteri).WithMany(p => p.Rezervasyons)
                .HasForeignKey(d => d.Musteriid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_rezervasyon_musteri");

            entity.HasOne(d => d.Oda).WithMany(p => p.Rezervasyons)
                .HasForeignKey(d => d.Odaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_rezervasyon_oda");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
