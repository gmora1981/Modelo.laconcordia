using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Segurovidum
{
    public string CiBeneficiario { get; set; } = null!;

    public int? Pkparentesco { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string CiAfiliado { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Tipo { get; set; }

    public string? Estado { get; set; }

    public virtual Fichapersonal CiAfiliadoNavigation { get; set; } = null!;

    public virtual Parentesco? PkparentescoNavigation { get; set; }
}
