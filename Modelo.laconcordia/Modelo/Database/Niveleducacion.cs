using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Niveleducacion
{
    public int Ideducacion { get; set; }

    public string? Descripcion { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Fichapersonal> Fichapersonals { get; set; } = new List<Fichapersonal>();
}
