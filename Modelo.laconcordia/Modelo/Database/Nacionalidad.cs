using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Nacionalidad
{
    public int Idnacionalidad { get; set; }

    public string? Nacionalidad1 { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Fichapersonal> Fichapersonals { get; set; } = new List<Fichapersonal>();
}
