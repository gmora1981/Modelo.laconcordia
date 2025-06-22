using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Unidad
{
    public string Unidad1 { get; set; } = null!;

    public string Placa { get; set; } = null!;

    public string? Idpropietario { get; set; }

    public string? Propietario { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public int? Anio { get; set; }

    public string? Estado { get; set; }

    public string? Color { get; set; }

    public DateTime? Fecha { get; set; }
}
