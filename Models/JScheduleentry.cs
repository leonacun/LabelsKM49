using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JScheduleentry
{
    public decimal ScheId { get; set; }

    public decimal ScheScheduleId { get; set; }

    public DateTime ScheTcreation { get; set; }

    public DateTime ScheTimestamp { get; set; }

    public DateTime? ScheUntiltimestamp { get; set; }

    public decimal ScheQuantity { get; set; }

    public string ScheQualifier { get; set; } = null!;

    public virtual ICollection<JScheduleentrystatus> JScheduleentrystatuses { get; set; } = new List<JScheduleentrystatus>();

    public virtual JSchedule ScheSchedule { get; set; } = null!;
}
