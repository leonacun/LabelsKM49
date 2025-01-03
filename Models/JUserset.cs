using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JUserset
{
    public decimal UsId { get; set; }

    public decimal UsCompanyId { get; set; }

    public decimal? UsLoginpolicyId { get; set; }

    public DateTime UsTcreation { get; set; }

    public DateTime UsTupdate { get; set; }

    public string UsKey { get; set; } = null!;

    public string UsDescr { get; set; } = null!;

    public decimal? UsDoccfgId { get; set; }

    public virtual ICollection<JLoginpolicyitem> JLoginpolicyitems { get; set; } = new List<JLoginpolicyitem>();

    public virtual ICollection<JUser> JUsers { get; set; } = new List<JUser>();

    public virtual JCompany UsCompany { get; set; } = null!;

    public virtual JDoccfg? UsDoccfg { get; set; }

    public virtual JLoginpolicy? UsLoginpolicy { get; set; }
}
