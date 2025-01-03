using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdunitinfo
{
    public decimal PuiId { get; set; }

    public decimal PuiProdunitId { get; set; }

    public decimal? PuiImageId { get; set; }

    public DateTime PuiTcreation { get; set; }

    public DateTime PuiTupdate { get; set; }

    public string PuiType { get; set; } = null!;

    public string? PuiKey1 { get; set; }

    public string? PuiKey2 { get; set; }

    public string? PuiKey3 { get; set; }

    public DateTime? PuiTimevalue { get; set; }

    public string? PuiStringvalue { get; set; }

    public int? PuiIntvalue { get; set; }

    public decimal? PuiErpentityId { get; set; }

    public virtual JErpentity? PuiErpentity { get; set; }

    public virtual JImage? PuiImage { get; set; }

    public virtual JProdunit PuiProdunit { get; set; } = null!;
}
