using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdunitintervalinfo
{
    public decimal PuiviId { get; set; }

    public decimal PuiviProdunitintervalId { get; set; }

    public decimal? PuiviFreasongroupId { get; set; }

    public DateTime PuiviTcreation { get; set; }

    public DateTime PuiviTupdate { get; set; }

    public string PuiviType { get; set; } = null!;

    public string? PuiviKey1 { get; set; }

    public string? PuiviKey2 { get; set; }

    public string? PuiviKey3 { get; set; }

    public DateTime? PuiviTimevalue { get; set; }

    public string? PuiviStringvalue { get; set; }

    public int? PuiviIntvalue { get; set; }

    public virtual JFreasongroup? PuiviFreasongroup { get; set; }

    public virtual JProdunitinterval PuiviProdunitinterval { get; set; } = null!;
}
