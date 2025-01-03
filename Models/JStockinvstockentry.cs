using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockinvstockentry
{
    public decimal StiseId { get; set; }

    public decimal StiseStockinvId { get; set; }

    public decimal StiseStockentrystatId { get; set; }

    public DateTime StiseTcreation { get; set; }

    public DateTime StiseTupdate { get; set; }

    public decimal StiseOldamount { get; set; }

    public decimal StiseNewamount { get; set; }

    public virtual JStockentrystat StiseStockentrystat { get; set; } = null!;

    public virtual JStockinv StiseStockinv { get; set; } = null!;
}
