using System;
using System.Collections.Generic;

namespace PointOfSales.Models;

public partial class Produk
{
    public int Id { get; set; }

    public string? NamaProduk { get; set; }

    public int Harga { get; set; }

    public int KategoriId { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public virtual Kategori Kategori { get; set; } = null!;
}
