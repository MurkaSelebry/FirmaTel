using System;
using System.Collections.Generic;

namespace FirmaTel.FirmaBasa;

public partial class Gorodum
{
    public int KodGoroda { get; set; }

    public string? Nazvanie { get; set; }

    public decimal? TarifDnevnoy { get; set; }

    public decimal? TarifNochnoy { get; set; }

    public virtual ICollection<Peregovory> Peregovories { get; } = new List<Peregovory>();

    public virtual Skidki? Skidki { get; set; }
}
