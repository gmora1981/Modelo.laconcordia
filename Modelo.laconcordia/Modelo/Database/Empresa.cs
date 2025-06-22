using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Empresa
{
    public string Ruc { get; set; } = null!;

    public string? Razonsocial { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Estado { get; set; }
}
