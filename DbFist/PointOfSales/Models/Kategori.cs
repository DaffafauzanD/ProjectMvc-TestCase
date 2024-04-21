using System;
using System.Collections.Generic;

namespace PointOfSales.Models;

public partial class Kategori
{
    public int IdKategori { get; set; }

    public string? NamaKategori { get; set; }

    public virtual ICollection<Produk> Produks { get; set; } = new List<Produk>();
}
