using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDashboarddbdatasource
{
    public decimal DboddsId { get; set; }

    public DateTime DboddsTcreation { get; set; }

    public DateTime DboddsTupdate { get; set; }

    public string DboddsKey { get; set; } = null!;

    public string DboddsDescr { get; set; } = null!;

    public string DboddsDatabasetype { get; set; } = null!;

    public string? DboddsUrl { get; set; }

    public string DboddsDriverclass { get; set; } = null!;

    public string DboddsName { get; set; } = null!;

    public string DboddsPassword { get; set; } = null!;

    public string? DboddsTestquery { get; set; }

    public virtual ICollection<JDashboarddataprovider> JDashboarddataproviders { get; set; } = new List<JDashboarddataprovider>();

    public virtual ICollection<JKpi> JKpis { get; set; } = new List<JKpi>();
}
