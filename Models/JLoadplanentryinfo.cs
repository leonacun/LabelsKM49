using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLoadplanentryinfo
{
    public decimal LpeiId { get; set; }

    public decimal LpeiLoadplanentryId { get; set; }

    public DateTime LpeiTcreation { get; set; }

    public string LpeiType { get; set; } = null!;

    public string? LpeiKey1 { get; set; }

    public DateTime? LpeiTimevalue { get; set; }

    public string? LpeiStringvalue { get; set; }

    public virtual JLoadplanentry LpeiLoadplanentry { get; set; } = null!;
}
