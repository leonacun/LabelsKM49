using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockinfo
{
    public decimal StinId { get; set; }

    public decimal StinStockId { get; set; }

    public DateTime StinTcreation { get; set; }

    public DateTime StinTupdate { get; set; }

    public string StinType { get; set; } = null!;

    public string? StinKey { get; set; }

    public DateTime? StinTimevalue { get; set; }

    public string? StinStringvalue { get; set; }

    public int StinIntvalue { get; set; }

    public decimal? StinErpentityId { get; set; }

    public virtual JErpentity? StinErpentity { get; set; }

    public virtual JStock StinStock { get; set; } = null!;
}
