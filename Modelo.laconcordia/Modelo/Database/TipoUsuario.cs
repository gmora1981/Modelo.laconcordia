using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class TipoUsuario
{
    public int IdtipoUsuario { get; set; }

    public string TipoUsuario1 { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
