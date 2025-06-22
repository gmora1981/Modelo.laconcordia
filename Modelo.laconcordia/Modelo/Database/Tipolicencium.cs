using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Tipolicencium
{
    public int Idtipo { get; set; }

    public string? Tipolicencia { get; set; }

    public string? Profesional { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Fichapersonal> Fichapersonals { get; set; } = new List<Fichapersonal>();
}
