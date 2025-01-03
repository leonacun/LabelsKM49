using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogprodunitinfo
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string PuiType { get; set; } = null!;

    public string? PuiKey1 { get; set; }

    public string? PuiKey2 { get; set; }

    public string? PuiKey3 { get; set; }

    public DateTime? PuiTimevalue { get; set; }

    public string? PuiStringvalue { get; set; }

    public int? PuiIntvalue { get; set; }

    public decimal? PuiProdunitId { get; set; }

    public decimal? PuiImageId { get; set; }

    public decimal? PuiErpentityId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
