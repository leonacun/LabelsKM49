using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSnapshot
{
    public decimal SnsId { get; set; }

    public decimal SnsSnapshotsetId { get; set; }

    public DateTime SnsTcreation { get; set; }

    public string? SnsKey { get; set; }

    public string SnsDescr { get; set; } = null!;

    public string SnsType { get; set; } = null!;

    public virtual ICollection<JObjectlog> JObjectlogs { get; set; } = new List<JObjectlog>();

    public virtual JSnapshotset SnsSnapshotset { get; set; } = null!;
}
