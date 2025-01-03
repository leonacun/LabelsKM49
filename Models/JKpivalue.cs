using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JKpivalue
{
    public decimal KpivId { get; set; }

    public decimal KpivKpiId { get; set; }

    public decimal KpivKpicolId { get; set; }

    public DateTime KpivTcreation { get; set; }

    public DateTime KpivTupdate { get; set; }

    public short KpivRowindex { get; set; }

    public string? KpivStringvalue { get; set; }

    public int? KpivIntvalue { get; set; }

    public decimal? KpivDecimalvalue { get; set; }

    public DateTime? KpivTimevalue { get; set; }

    public string? KpivStyleclass { get; set; }

    public virtual JKpi KpivKpi { get; set; } = null!;

    public virtual JKpicol KpivKpicol { get; set; } = null!;
}
