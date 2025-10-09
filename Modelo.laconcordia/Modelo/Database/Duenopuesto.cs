using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Duenopuesto
{
    public string Cedula { get; set; } = null!;

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Fichapersonal> Fichapersonals { get; set; } = new List<Fichapersonal>();
}
