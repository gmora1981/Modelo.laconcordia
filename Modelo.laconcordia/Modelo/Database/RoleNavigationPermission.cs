using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class RoleNavigationPermission
{
    public int Id { get; set; }

    public string RoleId { get; set; } = null!;

    public int NavigationItemId { get; set; }

    public bool CanView { get; set; }

    public bool CanCreate { get; set; }

    public bool CanEdit { get; set; }

    public bool CanDelete { get; set; }

    public DateTime GrantedAt { get; set; }

    public string? GrantedBy { get; set; }

    public virtual AspNetUser? GrantedByNavigation { get; set; }

    public virtual NavigationItem NavigationItem { get; set; } = null!;

    public virtual AspNetRole Role { get; set; } = null!;
}
