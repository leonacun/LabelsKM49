using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockinvdiffitem
{
    public decimal StidiId { get; set; }

    public decimal StidiStockinvId { get; set; }

    public decimal? StidiStocklocId { get; set; }

    public decimal? StidiOldcontainerId { get; set; }

    public decimal? StidiOldsubjectId { get; set; }

    public decimal? StidiNewcontainerId { get; set; }

    public decimal? StidiNewsubjectId { get; set; }

    public DateTime StidiTcreation { get; set; }

    public DateTime StidiTupdate { get; set; }

    public string StidiType { get; set; } = null!;

    public decimal StidiOldamount { get; set; }

    public string? StidiOldcontainerentrypos { get; set; }

    public decimal StidiNewamount { get; set; }

    public string? StidiNewcontainerentrypos { get; set; }

    public decimal? StidiOldpartId { get; set; }

    public decimal? StidiNewpartId { get; set; }

    public virtual JContainer? StidiNewcontainer { get; set; }

    public virtual JPart? StidiNewpart { get; set; }

    public virtual JSubject? StidiNewsubject { get; set; }

    public virtual JContainer? StidiOldcontainer { get; set; }

    public virtual JPart? StidiOldpart { get; set; }

    public virtual JSubject? StidiOldsubject { get; set; }

    public virtual JStockinv StidiStockinv { get; set; } = null!;

    public virtual JStockloc? StidiStockloc { get; set; }
}
