using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMenu
{
    public decimal MId { get; set; }

    public decimal MCompanyId { get; set; }

    public DateTime MTcreation { get; set; }

    public DateTime MTupdate { get; set; }

    public string MKind { get; set; } = null!;

    public string MShortname { get; set; } = null!;

    public string MDescr { get; set; } = null!;

    public virtual ICollection<JMenuitem> JMenuitemMiMenus { get; set; } = new List<JMenuitem>();

    public virtual ICollection<JMenuitem> JMenuitemMiSubmenus { get; set; } = new List<JMenuitem>();

    public virtual ICollection<JUserrole> JUserroles { get; set; } = new List<JUserrole>();

    public virtual ICollection<JUser> JUsers { get; set; } = new List<JUser>();

    public virtual JCompany MCompany { get; set; } = null!;
}
