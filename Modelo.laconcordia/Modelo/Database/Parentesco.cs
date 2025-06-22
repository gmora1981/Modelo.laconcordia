using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Parentesco
{
    public int Idparentesco { get; set; }

    public string? Parentesco1 { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Segurovidum> Segurovida { get; set; } = new List<Segurovidum>();
}
