using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainersetinfo
{
    public decimal CtsiId { get; set; }

    public decimal CtsiContainersetId { get; set; }

    public DateTime CtsiTcreation { get; set; }

    public DateTime CtsiTupdate { get; set; }

    public string CtsiType { get; set; } = null!;

    public string? CtsiKey1 { get; set; }

    public string? CtsiKey2 { get; set; }

    public string? CtsiKey3 { get; set; }

    public DateTime? CtsiTimevalue { get; set; }

    public string? CtsiStringvalue { get; set; }

    public string? CtsiDescr { get; set; }

    public decimal? CtsiRefcontainersetId { get; set; }

    public virtual JContainerset CtsiContainerset { get; set; } = null!;

    public virtual JContainerset? CtsiRefcontainerset { get; set; }
}
