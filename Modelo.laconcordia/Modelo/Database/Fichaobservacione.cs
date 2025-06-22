using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class Fichaobservacione
{
    public int Idfichaobs { get; set; }

    public string? Fkcedula { get; set; }

    public string? Fkunidad { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Motivo { get; set; }

    public virtual Fichapersonal? FkcedulaNavigation { get; set; }
}
