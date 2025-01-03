using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdjobdatum
{
    public decimal PjdId { get; set; }

    public decimal PjdProdjobId { get; set; }

    public DateTime PjdTcreation { get; set; }

    public DateTime PjdTupdate { get; set; }

    public decimal? PjdDeletionid { get; set; }

    public DateTime? PjdTdeletion { get; set; }

    public string PjdKind { get; set; } = null!;

    public string? PjdKey { get; set; }

    public string? PjdValue { get; set; }

    public virtual JProdjob PjdProdjob { get; set; } = null!;
}
