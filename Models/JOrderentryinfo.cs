using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrderentryinfo
{
    public decimal OeiId { get; set; }

    public decimal OeiOrderentryId { get; set; }

    public DateTime OeiTcreation { get; set; }

    public DateTime OeiTupdate { get; set; }

    public string OeiType { get; set; } = null!;

    public string? OeiKey1 { get; set; }

    public string? OeiKey2 { get; set; }

    public string? OeiKey3 { get; set; }

    public DateTime? OeiTimevalue { get; set; }

    public string? OeiStringvalue { get; set; }

    public int? OeiIntvalue { get; set; }

    public decimal? OeiUomId { get; set; }

    public virtual JOrderentry OeiOrderentry { get; set; } = null!;

    public virtual JUnitofmeasure? OeiUom { get; set; }
}
