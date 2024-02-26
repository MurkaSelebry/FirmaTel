using System;
using System.Collections.Generic;

namespace FirmaTel.FirmaBasa;

public partial class Abonnent
{
    public int KodAbonenta { get; set; }

    public string? NomberTelefona { get; set; }

    public string? Inn { get; set; }

    public string? Adres { get; set; }

    public virtual ICollection<Peregovory> Peregovories { get; } = new List<Peregovory>();
}
