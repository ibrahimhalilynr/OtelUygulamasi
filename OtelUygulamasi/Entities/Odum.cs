using System;
using System.Collections.Generic;

namespace OtelUygulamasi.Entities;

public partial class Odum
{
    public int Odaid { get; set; }

    public int Odano { get; set; }

    public int Kat { get; set; }

    public int YatakSayisi { get; set; }

    public bool Durum { get; set; }

    public decimal Fiyat { get; set; }

    public virtual ICollection<Rezervasyon> Rezervasyons { get; set; } = new List<Rezervasyon>();
}
