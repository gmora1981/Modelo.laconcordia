using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Direccion
{
    public decimal Latitud { get; set; }

    public decimal Longitud { get; set; }

    public string? Calle { get; set; }

    public int? Numero { get; set; }

    public string? Referencia { get; set; }

    public string Celular { get; set; } = null!;

    public virtual Pasajero CelularNavigation { get; set; } = null!;
}
