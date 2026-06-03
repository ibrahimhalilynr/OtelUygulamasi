using System;
using System.Collections.Generic;

namespace OtelUygulamasi.Entities;

public partial class Musteri
{
    public int Musteriid { get; set; }

    public string Tc { get; set; } = null!;

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string? Adres { get; set; }

    public string Telefon { get; set; } = null!;

    public virtual ICollection<Rezervasyon> Rezervasyons { get; set; } = new List<Rezervasyon>();
}
