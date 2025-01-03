using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStocklocinfo
{
    public decimal StliId { get; set; }

    public decimal StliStocklocId { get; set; }

    public DateTime StliTcreation { get; set; }

    public DateTime StliTupdate { get; set; }

    public string StliType { get; set; } = null!;

    public string? StliKey1 { get; set; }

    public string? StliKey2 { get; set; }

    public string? StliKey3 { get; set; }

    public DateTime? StliTimevalue { get; set; }

    public string? StliStringvalue { get; set; }

    public decimal? StliErpentityId { get; set; }

    public string StliScope { get; set; } = null!;

    public virtual JErpentity? StliErpentity { get; set; }

    public virtual JStockloc StliStockloc { get; set; } = null!;
}
