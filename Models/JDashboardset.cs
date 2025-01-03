using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDashboardset
{
    public decimal DbosId { get; set; }

    public DateTime DbosTcreation { get; set; }

    public DateTime DbosTupdate { get; set; }

    public string DbosKey { get; set; } = null!;

    public string DbosDescr { get; set; } = null!;

    public virtual ICollection<JDashboard> JDashboards { get; set; } = new List<JDashboard>();
}
