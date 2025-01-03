using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockinvstockloccnr
{
    public decimal StislcId { get; set; }

    public decimal StislcStockinvstocklocId { get; set; }

    public decimal StislcContainerId { get; set; }

    public DateTime StislcTcreation { get; set; }

    public DateTime StislcTupdate { get; set; }

    public decimal? StislcUsedcontainerId { get; set; }

    public decimal? StislcSelectedcontainerId { get; set; }

    public decimal? StislcSelectedcontainersetId { get; set; }

    public string? StislcLastcommitresult { get; set; }

    public string StislcLastcnrcounttype { get; set; } = null!;

    public string StislcReqcnrcounttype { get; set; } = null!;

    public string StislcStatus { get; set; } = null!;

    public int StislcCountidx { get; set; }

    public virtual ICollection<JStockinvstockloccnrpart> JStockinvstockloccnrparts { get; set; } = new List<JStockinvstockloccnrpart>();

    public virtual JContainer StislcContainer { get; set; } = null!;

    public virtual JContainer? StislcSelectedcontainer { get; set; }

    public virtual JContainerset? StislcSelectedcontainerset { get; set; }

    public virtual JStockinvstockloc StislcStockinvstockloc { get; set; } = null!;

    public virtual JContainer? StislcUsedcontainer { get; set; }
}
