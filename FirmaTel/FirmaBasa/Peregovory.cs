using System;
using System.Collections.Generic;

namespace FirmaTel.FirmaBasa;

public partial class Peregovory
{
    public int KodPeregovorov { get; set; }

    public int? KodAbonenta { get; set; }

    public int? KodGoroda { get; set; }

    public DateOnly? Data { get; set; }

    public int? KolichestvoMinut { get; set; }

    public string? VremyaSutok { get; set; }

    public virtual Abonnent? KodAbonentaNavigation { get; set; }

    public virtual Gorodum? KodGorodaNavigation { get; set; }
}
