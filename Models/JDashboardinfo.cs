using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDashboardinfo
{
    public decimal DboiId { get; set; }

    public decimal DboiDashboardId { get; set; }

    public DateTime DboiTcreation { get; set; }

    public DateTime DboiTupdate { get; set; }

    public string DboiType { get; set; } = null!;

    public string? DboiKey1 { get; set; }

    public string? DboiKey2 { get; set; }

    public string? DboiKey3 { get; set; }

    public string? DboiStringvalue { get; set; }

    public string? DboiDescr { get; set; }

    public virtual JDashboard DboiDashboard { get; set; } = null!;
}
