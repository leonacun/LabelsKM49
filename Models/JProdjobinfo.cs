using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdjobinfo
{
    public decimal PjiId { get; set; }

    public decimal PjiProdjobId { get; set; }

    public DateTime PjiTcreation { get; set; }

    public DateTime PjiTupdate { get; set; }

    public string PjiType { get; set; } = null!;

    public string? PjiKey1 { get; set; }

    public string? PjiKey2 { get; set; }

    public string? PjiKey3 { get; set; }

    public DateTime? PjiTimevalue { get; set; }

    public string? PjiStringvalue { get; set; }

    public int? PjiIntvalue { get; set; }

    public virtual JProdjob PjiProdjob { get; set; } = null!;
}
