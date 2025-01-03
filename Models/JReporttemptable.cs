using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JReporttemptable
{
    public decimal RttId { get; set; }

    public DateTime RttTcreation { get; set; }

    public string RttReportid { get; set; } = null!;

    public string RttTablename { get; set; } = null!;

    public string RttSequencename { get; set; } = null!;
}
