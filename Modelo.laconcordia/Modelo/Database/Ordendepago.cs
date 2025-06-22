using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Ordendepago
{
    public string Numvoucher { get; set; } = null!;

    public DateTime? Fechayhora { get; set; }

    public string? Ruc { get; set; }

    public string? Empresa { get; set; }

    public string? Celular { get; set; }

    public string? Empleado { get; set; }

    public string? Tiempoespera { get; set; }

    public string? Puntopartida { get; set; }

    public string? Recorrido { get; set; }

    public string? Puntofinal { get; set; }

    public string? Unidad { get; set; }

    public string? Ciconductor { get; set; }

    public string? Conductor { get; set; }

    public decimal? Precio { get; set; }

    public string? Observacion { get; set; }

    public decimal? Preciodesc { get; set; }

    public DateTime? Fechaderegistro { get; set; }

    public string? Usuario { get; set; }

    public string? Valija { get; set; }

    public string? Cliente { get; set; }

    public DateTime? Fechaproceso { get; set; }

    public string? Estadoproceso { get; set; }

    public DateOnly? Fechacorte { get; set; }
}
