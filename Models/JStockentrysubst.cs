using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockentrysubst
{
    public decimal SesuId { get; set; }

    public decimal SesuStatId { get; set; }

    public decimal SesuSubststatId { get; set; }

    public DateTime SesuTcreation { get; set; }

    public virtual JStockentrystat SesuStat { get; set; } = null!;

    public virtual JStockentrystat SesuSubststat { get; set; } = null!;
}
