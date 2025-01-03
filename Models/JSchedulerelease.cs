using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSchedulerelease
{
    public decimal SchrId { get; set; }

    public decimal SchrOrderId { get; set; }

    public DateTime SchrTcreation { get; set; }

    public DateTime SchrTupdate { get; set; }

    public string? SchrNo { get; set; }

    public DateTime? SchrTimeissued { get; set; }

    public virtual ICollection<JSchedule> JSchedules { get; set; } = new List<JSchedule>();

    public virtual JOrder SchrOrder { get; set; } = null!;
}
