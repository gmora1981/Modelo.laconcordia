using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Movimientocuotum
{
    public string Periodo { get; set; } = null!;

    public string Semana { get; set; } = null!;

    public string Cidentidad { get; set; } = null!;

    public DateTime Fechapago { get; set; }

    public decimal? Valorpagado { get; set; }

    public string? Formadepago { get; set; }

    public string? Usuario { get; set; }

    public string? Detalle { get; set; }

    public string? Banco { get; set; }

    public string? Numcomprobante { get; set; }
}
