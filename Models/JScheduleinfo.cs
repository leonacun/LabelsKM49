using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JScheduleinfo
{
    public decimal SchiId { get; set; }

    public decimal SchiScheduleId { get; set; }

    public DateTime SchiTcreation { get; set; }

    public DateTime SchiTupdate { get; set; }

    public string SchiType { get; set; } = null!;

    public string? SchiKey1 { get; set; }

    public string? SchiKey2 { get; set; }

    public string? SchiKey3 { get; set; }

    public DateTime? SchiTimevalue { get; set; }

    public string? SchiStringvalue { get; set; }

    public virtual JSchedule SchiSchedule { get; set; } = null!;
}
