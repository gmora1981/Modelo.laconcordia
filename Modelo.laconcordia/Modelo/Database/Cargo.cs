using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Cargo
{
    public int Idcargo { get; set; }

    public string? Cargo1 { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Fichapersonal> Fichapersonals { get; set; } = new List<Fichapersonal>();
}
