using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JKpi
{
    public decimal KpiId { get; set; }

    public decimal KpiKpisetId { get; set; }

    public decimal? KpiConfigdefId { get; set; }

    public decimal? KpiDbdatasourceId { get; set; }

    public DateTime KpiTcreation { get; set; }

    public DateTime KpiTupdate { get; set; }

    public string KpiKey { get; set; } = null!;

    public string KpiDescr { get; set; } = null!;

    public string KpiComputationtype { get; set; } = null!;

    public DateTime? KpiTimecomputed { get; set; }

    public bool? KpiEnabled { get; set; }

    public virtual ICollection<JKpicol> JKpicols { get; set; } = new List<JKpicol>();

    public virtual ICollection<JKpivalue> JKpivalues { get; set; } = new List<JKpivalue>();

    public virtual JConfigdef? KpiConfigdef { get; set; }

    public virtual JDashboarddbdatasource? KpiDbdatasource { get; set; }

    public virtual JKpiset KpiKpiset { get; set; } = null!;
}
