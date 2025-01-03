using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDashboardpaneldefset
{
    public decimal DbopdsId { get; set; }

    public DateTime DbopdsTcreation { get; set; }

    public DateTime DbopdsTupdate { get; set; }

    public string DbopdsKey { get; set; } = null!;

    public string DbopdsDescr { get; set; } = null!;

    public virtual ICollection<JDashboardpaneldef> JDashboardpaneldefs { get; set; } = new List<JDashboardpaneldef>();
}
