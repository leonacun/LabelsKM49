using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkiddatum
{
    public decimal SkdId { get; set; }

    public decimal SkdSkidId { get; set; }

    public DateTime SkdTcreation { get; set; }

    public DateTime SkdTupdate { get; set; }

    public string SkdKey { get; set; } = null!;

    public string? SkdValue { get; set; }

    public virtual JSkid SkdSkid { get; set; } = null!;
}
