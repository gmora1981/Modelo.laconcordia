using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Usuario
{
    public string Usuario1 { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int? Fktipousuario { get; set; }

    public string Passwd { get; set; } = null!;

    public string? Estado { get; set; }

    public virtual TipoUsuario? FktipousuarioNavigation { get; set; }
}
