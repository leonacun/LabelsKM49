using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCounterset
{
    public decimal CnsId { get; set; }

    public decimal CnsCompanyId { get; set; }

    public DateTime CnsTcreation { get; set; }

    public DateTime CnsTupdate { get; set; }

    public string CnsKey { get; set; } = null!;

    public string CnsDescr { get; set; } = null!;

    public virtual JCompany CnsCompany { get; set; } = null!;

    public virtual ICollection<JCounter> JCounters { get; set; } = new List<JCounter>();
}
