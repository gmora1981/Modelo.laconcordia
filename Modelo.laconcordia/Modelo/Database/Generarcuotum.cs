using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Generarcuotum
{
    public string Periodo { get; set; } = null!;

    public string Semana { get; set; } = null!;

    public string Cidentidad { get; set; } = null!;

    public decimal? Valor { get; set; }

    public DateOnly? Fecha { get; set; }

    public decimal? Abono { get; set; }
}
