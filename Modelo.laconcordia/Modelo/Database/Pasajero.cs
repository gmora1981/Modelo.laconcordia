using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Pasajero
{
    public string Celular { get; set; } = null!;

    public string? Nombres { get; set; }

    public string? Observacion { get; set; }

    public string? Correo { get; set; }

    public string? Sexo { get; set; }

    public string? Whatsapp { get; set; }

    public int? Publicidad { get; set; }

    public virtual ICollection<Direccion> Direccions { get; set; } = new List<Direccion>();
}
