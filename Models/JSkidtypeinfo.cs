using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkidtypeinfo
{
    public decimal SktiId { get; set; }

    public decimal SktiSkidtypeId { get; set; }

    public DateTime SktiTcreation { get; set; }

    public DateTime SktiTupdate { get; set; }

    public string SktiType { get; set; } = null!;

    public string? SktiKey1 { get; set; }

    public string? SktiKey2 { get; set; }

    public string? SktiKey3 { get; set; }

    public DateTime? SktiTimevalue { get; set; }

    public string? SktiStringvalue { get; set; }

    public virtual JSkidtype SktiSkidtype { get; set; } = null!;
}
