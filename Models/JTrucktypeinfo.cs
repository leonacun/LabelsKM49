using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTrucktypeinfo
{
    public decimal TtiId { get; set; }

    public decimal TtiTrucktypeId { get; set; }

    public DateTime TtiTcreation { get; set; }

    public DateTime TtiTupdate { get; set; }

    public string TtiType { get; set; } = null!;

    public string? TtiKey1 { get; set; }

    public string? TtiKey2 { get; set; }

    public string? TtiKey3 { get; set; }

    public DateTime? TtiTimevalue { get; set; }

    public string? TtiStringvalue { get; set; }

    public virtual JTrucktype TtiTrucktype { get; set; } = null!;
}
