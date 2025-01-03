using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDashboarddataprovider
{
    public decimal DbodpId { get; set; }

    public decimal? DbodpConfigdefId { get; set; }

    public decimal? DbodpDbdatasourceId { get; set; }

    public DateTime DbodpTcreation { get; set; }

    public DateTime DbodpTupdate { get; set; }

    public string DbodpKey { get; set; } = null!;

    public string DbodpDescr { get; set; } = null!;

    public string DbodpDatasourcetype { get; set; } = null!;

    public string? DbodpUrl { get; set; }

    public string? DbodpPath { get; set; }

    public virtual JConfigdef? DbodpConfigdef { get; set; }

    public virtual JDashboarddbdatasource? DbodpDbdatasource { get; set; }

    public virtual ICollection<JDashboardpaneldef> JDashboardpaneldefs { get; set; } = new List<JDashboardpaneldef>();
}
