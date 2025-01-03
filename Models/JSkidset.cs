using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkidset
{
    public decimal SksId { get; set; }

    public decimal SksCompanyId { get; set; }

    public decimal? SksDoccfgId { get; set; }

    public DateTime SksTcreation { get; set; }

    public DateTime SksTupdate { get; set; }

    public string SksKey { get; set; } = null!;

    public string SksDescr { get; set; } = null!;

    public decimal? SksContainersetclassId { get; set; }

    public virtual ICollection<JSkid> JSkids { get; set; } = new List<JSkid>();

    public virtual JCompany SksCompany { get; set; } = null!;

    public virtual JContainersetclass? SksContainersetclass { get; set; }

    public virtual JDoccfg? SksDoccfg { get; set; }
}
