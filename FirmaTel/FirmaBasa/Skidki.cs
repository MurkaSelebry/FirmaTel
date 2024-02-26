using System;
using System.Collections.Generic;

namespace FirmaTel.FirmaBasa;

public partial class Skidki
{
    public int KodGoroda { get; set; }

    public decimal? Skidka { get; set; }

    public virtual Gorodum KodGorodaNavigation { get; set; } = null!;
}
