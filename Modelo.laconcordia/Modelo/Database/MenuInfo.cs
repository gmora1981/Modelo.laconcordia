using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class MenuInfo
{
    public int Menuid { get; set; }

    public int? ParentMenuid { get; set; }

    public string? PageName { get; set; }

    public string? MenuName { get; set; }

    public string? IcoName { get; set; }
}
