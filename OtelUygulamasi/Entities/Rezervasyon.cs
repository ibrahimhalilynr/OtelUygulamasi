using System;
using System.Collections.Generic;

namespace OtelUygulamasi.Entities;

public partial class Rezervasyon
{
    public int Rezervasyonid { get; set; }

    public int Odaid { get; set; }

    public int Musteriid { get; set; }

    public DateOnly Giristarihi { get; set; }

    public DateOnly Cikistarihi { get; set; }

    public decimal Toplamucret { get; set; }

    public virtual Musteri Musteri { get; set; } = null!;

    public virtual Odum Oda { get; set; } = null!;
}
