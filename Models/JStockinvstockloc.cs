using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockinvstockloc
{
    public decimal StislId { get; set; }

    public decimal StislStockinvId { get; set; }

    public decimal StislStocklocId { get; set; }

    public DateTime StislTcreation { get; set; }

    public DateTime StislTupdate { get; set; }

    public bool? StislComputed { get; set; }

    public DateTime? StislTimecompleted { get; set; }

    public decimal? StislTransitionId { get; set; }

    public int StislCountidx { get; set; }

    public virtual ICollection<JStockinvstockloccnr> JStockinvstockloccnrs { get; set; } = new List<JStockinvstockloccnr>();

    public virtual ICollection<JStockinvstocklocpart> JStockinvstocklocparts { get; set; } = new List<JStockinvstocklocpart>();

    public virtual ICollection<JStockinvstocklocsubject> JStockinvstocklocsubjects { get; set; } = new List<JStockinvstocklocsubject>();

    public virtual JStockinv StislStockinv { get; set; } = null!;

    public virtual JStockloc StislStockloc { get; set; } = null!;

    public virtual JTransition? StislTransition { get; set; }
}
