using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JUserrole
{
    public decimal UrId { get; set; }

    public decimal UrCompanyId { get; set; }

    public decimal UrAccessrightsetId { get; set; }

    public decimal? UrMenuId { get; set; }

    public decimal UrGroupId { get; set; }

    public DateTime UrTcreation { get; set; }

    public DateTime UrTupdate { get; set; }

    public string UrKey { get; set; } = null!;

    public string UrDescr { get; set; } = null!;

    public bool? UrAllowfilterassignment { get; set; }

    public virtual ICollection<JToolaccessrightset> JToolaccessrightsets { get; set; } = new List<JToolaccessrightset>();

    public virtual ICollection<JUser> JUsers { get; set; } = new List<JUser>();

    public virtual ICollection<JUsersetting> JUsersettings { get; set; } = new List<JUsersetting>();

    public virtual JAccessrightset UrAccessrightset { get; set; } = null!;

    public virtual JCompany UrCompany { get; set; } = null!;

    public virtual JGroup UrGroup { get; set; } = null!;

    public virtual JMenu? UrMenu { get; set; }
}
