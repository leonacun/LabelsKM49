using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogprodstepinfo
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string PrsiType { get; set; } = null!;

    public string? PrsiKey1 { get; set; }

    public string? PrsiKey2 { get; set; }

    public string? PrsiKey3 { get; set; }

    public DateTime? PrsiTimevalue { get; set; }

    public string? PrsiStringvalue { get; set; }

    public decimal? PrsiProdstepId { get; set; }

    public decimal? PrsiErpentityId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
