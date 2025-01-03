using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPaintplanentryinfo
{
    public decimal PpeiId { get; set; }

    public decimal PpeiPaintplanentryId { get; set; }

    public DateTime PpeiTcreation { get; set; }

    public DateTime PpeiTupdate { get; set; }

    public string PpeiType { get; set; } = null!;

    public string? PpeiKey1 { get; set; }

    public string? PpeiKey2 { get; set; }

    public string? PpeiKey3 { get; set; }

    public DateTime? PpeiTimevalue { get; set; }

    public string? PpeiStringvalue { get; set; }

    public int? PpeiIntvalue { get; set; }

    public virtual JPaintplanentry PpeiPaintplanentry { get; set; } = null!;
}
