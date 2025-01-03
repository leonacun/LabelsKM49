using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkideventdatum
{
    public decimal SkedId { get; set; }

    public decimal SkedSkideventId { get; set; }

    public DateTime SkedTcreation { get; set; }

    public string? SkedKey { get; set; }

    public string? SkedValue { get; set; }

    public virtual JSkidevent SkedSkidevent { get; set; } = null!;
}
