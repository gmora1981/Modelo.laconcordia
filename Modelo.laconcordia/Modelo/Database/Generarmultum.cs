using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Generarmultum
{
    public string Idmulta { get; set; } = null!;

    public string Cidentidad { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public string? Observacion { get; set; }

    public decimal? Valor { get; set; }

    public decimal? Abono { get; set; }

    public string? Tipo { get; set; }
}
