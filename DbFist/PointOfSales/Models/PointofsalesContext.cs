using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PointOfSales.Models;

public partial class PointofsalesContext : DbContext
{
    public PointofsalesContext()
    {
    }

    public PointofsalesContext(DbContextOptions<PointofsalesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Kategori> Kategoris { get; set; }

    public virtual DbSet<Produk> Produks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=SqlConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kategori>(entity =>
        {
            entity.HasKey(e => e.IdKategori);

            entity.ToTable("Kategori");

            entity.Property(e => e.IdKategori).HasColumnName("Id_kategori");
            entity.Property(e => e.NamaKategori).HasColumnName("Nama_Kategori");
        });

        modelBuilder.Entity<Produk>(entity =>
        {
            entity.ToTable("Produk");

            entity.HasIndex(e => e.KategoriId, "IX_Produk_KategoriId");

            entity.Property(e => e.CreateAt).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.NamaProduk).HasColumnName("Nama_produk");
            entity.Property(e => e.UpdateAt).HasDefaultValueSql("(getutcdate())");

            entity.HasOne(d => d.Kategori).WithMany(p => p.Produks).HasForeignKey(d => d.KategoriId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
