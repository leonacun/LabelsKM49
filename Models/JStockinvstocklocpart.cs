using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockinvstocklocpart
{
    public decimal StislpId { get; set; }

    public decimal StislpStockinvstocklocId { get; set; }

    public decimal StislpPartId { get; set; }

    public DateTime StislpTcreation { get; set; }

    public DateTime StislpTupdate { get; set; }

    public int StislpCountidx { get; set; }

    public virtual JPart StislpPart { get; set; } = null!;

    public virtual JStockinvstockloc StislpStockinvstockloc { get; set; } = null!;
}
