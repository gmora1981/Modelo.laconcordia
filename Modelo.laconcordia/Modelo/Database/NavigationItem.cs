using System;
using System.Collections.Generic;

namespace Modelo.laconcordia.Modelo.Database;

public partial class NavigationItem
{
    public int Id { get; set; }

    public int? ParentId { get; set; }

    public string Title { get; set; } = null!;

    public string? Url { get; set; }

    public string? Icon { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public string? RequiredRole { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<NavigationItem> InverseParent { get; set; } = new List<NavigationItem>();

    public virtual NavigationItem? Parent { get; set; }

    public virtual ICollection<RoleNavigationPermission> RoleNavigationPermissions { get; set; } = new List<RoleNavigationPermission>();

    public virtual ICollection<UserNavigationPermission> UserNavigationPermissions { get; set; } = new List<UserNavigationPermission>();
}
