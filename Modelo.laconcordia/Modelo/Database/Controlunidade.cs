using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Controlunidade
{
    public DateTime Fecharegistro { get; set; }

    public string Unidad { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string? Turno { get; set; }

    public string? Monitora { get; set; }

    public string? Monitorasig { get; set; }

    public string? Ciconductor { get; set; }

    public string? Conductor { get; set; }
}
