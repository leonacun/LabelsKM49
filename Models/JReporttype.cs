using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JReporttype
{
    public decimal RtId { get; set; }

    public decimal RtReporttypesetId { get; set; }

    public DateTime RtTcreation { get; set; }

    public DateTime RtTupdate { get; set; }

    public string RtKey { get; set; } = null!;

    public string RtDescr { get; set; } = null!;

    public string RtType { get; set; } = null!;

    public virtual ICollection<JReport> JReports { get; set; } = new List<JReport>();

    public virtual JReporttypeset RtReporttypeset { get; set; } = null!;
}
