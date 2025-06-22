using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Fichapersonal
{
    public string Cedula { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public string? Telefono { get; set; }

    public string? Celular { get; set; }

    public string? Correo { get; set; }

    public DateOnly? Fechanacimiento { get; set; }

    public DateTime? Fechaingreso { get; set; }

    public int? Fknacionalidad { get; set; }

    public string? Fkunidad { get; set; }

    public string? Domicilio { get; set; }

    public string? Referencia { get; set; }

    public int? Fkestadocivil { get; set; }

    public int? Fktipolicencia { get; set; }

    public int? Fkcargo { get; set; }

    public string? Estado { get; set; }

    public int? Fkniveleducacion { get; set; }

    public string? Fkdpuesto { get; set; }

    public string? Estadoservicio { get; set; }

    public decimal? Cuotaf { get; set; }

    public virtual ICollection<Fichaobservacione> Fichaobservaciones { get; set; } = new List<Fichaobservacione>();

    public virtual Cargo? FkcargoNavigation { get; set; }

    public virtual Duenopuesto? FkdpuestoNavigation { get; set; }

    public virtual Estadocivil? FkestadocivilNavigation { get; set; }

    public virtual Nacionalidad? FknacionalidadNavigation { get; set; }

    public virtual Niveleducacion? FkniveleducacionNavigation { get; set; }

    public virtual Tipolicencium? FktipolicenciaNavigation { get; set; }

    public virtual ICollection<Segurovidum> Segurovida { get; set; } = new List<Segurovidum>();
}
