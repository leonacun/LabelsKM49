using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrderinfo
{
    public decimal OiId { get; set; }

    public decimal OiOrderId { get; set; }

    public DateTime OiTcreation { get; set; }

    public DateTime OiTupdate { get; set; }

    public string OiType { get; set; } = null!;

    public string? OiKey1 { get; set; }

    public string? OiKey2 { get; set; }

    public string? OiKey3 { get; set; }

    public DateTime? OiTimevalue { get; set; }

    public string? OiStringvalue { get; set; }

    public DateTime? OiTimevalue2 { get; set; }

    public decimal? OiUomId { get; set; }

    public virtual JOrder OiOrder { get; set; } = null!;

    public virtual JUnitofmeasure? OiUom { get; set; }
}
