using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class PedidoAut
{
    public string? Ruc { get; set; }

    public DateTime Fecharegistro { get; set; }

    public string? Usuario { get; set; }

    public decimal? Precio { get; set; }

    public string? Numvoucher { get; set; }

    public string? Empleado { get; set; }

    public string? Recorrido { get; set; }
}
