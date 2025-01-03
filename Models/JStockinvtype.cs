using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockinvtype
{
    public decimal StitId { get; set; }

    public decimal StitStockId { get; set; }

    public DateTime StitTcreation { get; set; }

    public DateTime StitTupdate { get; set; }

    public string StitStrategy { get; set; } = null!;

    public string StitDescr { get; set; } = null!;

    public bool? StitEnabled { get; set; }

    public string StitLocktype { get; set; } = null!;

    public decimal? StitEdicfgId { get; set; }

    public virtual ICollection<JStockinv> JStockinvs { get; set; } = new List<JStockinv>();

    public virtual JEdicfg? StitEdicfg { get; set; }

    public virtual JStock StitStock { get; set; } = null!;
}
