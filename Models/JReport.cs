using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JReport
{
    public decimal RId { get; set; }

    public decimal RReportsetId { get; set; }

    public decimal RReporttypeId { get; set; }

    public DateTime RTcreation { get; set; }

    public DateTime RTupdate { get; set; }

    public string RKey { get; set; } = null!;

    public string RDescr { get; set; } = null!;

    public DateTime? RTimeinactivated { get; set; }

    public DateTime? RTimeexecuted { get; set; }

    public string? RComment { get; set; }

    public virtual ICollection<JReportclassmember> JReportclassmembers { get; set; } = new List<JReportclassmember>();

    public virtual ICollection<JReportparam> JReportparamRpJoinedreports { get; set; } = new List<JReportparam>();

    public virtual ICollection<JReportparam> JReportparamRpReports { get; set; } = new List<JReportparam>();

    public virtual JReportset RReportset { get; set; } = null!;

    public virtual JReporttype RReporttype { get; set; } = null!;
}
