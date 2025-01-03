using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JKpiset
{
    public decimal KpisId { get; set; }

    public DateTime KpisTcreation { get; set; }

    public DateTime KpisTupdate { get; set; }

    public string KpisKey { get; set; } = null!;

    public string KpisDescr { get; set; } = null!;

    public virtual ICollection<JKpi> JKpis { get; set; } = new List<JKpi>();
}
