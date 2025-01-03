using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockentrydyn
{
    public decimal SedId { get; set; }

    public decimal SedStatId { get; set; }

    public DateTime SedTcreation { get; set; }

    public decimal SedCurrentamount { get; set; }

    public decimal SedReservedamount { get; set; }

    public decimal SedLockedamount { get; set; }

    public DateTime SedTupdate { get; set; }

    public virtual JStockentrystat SedStat { get; set; } = null!;
}
