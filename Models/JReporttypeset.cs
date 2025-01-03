using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JReporttypeset
{
    public decimal RtsId { get; set; }

    public decimal RtsCompanyId { get; set; }

    public DateTime RtsTcreation { get; set; }

    public DateTime RtsTupdate { get; set; }

    public string RtsKey { get; set; } = null!;

    public string RtsDescr { get; set; } = null!;

    public virtual ICollection<JReporttype> JReporttypes { get; set; } = new List<JReporttype>();

    public virtual JCompany RtsCompany { get; set; } = null!;
}
