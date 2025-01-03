using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockentrymark
{
    public decimal SemId { get; set; }

    public decimal SemStockentryId { get; set; }

    public decimal? SemStockeventId { get; set; }

    public DateTime SemTcreation { get; set; }

    public virtual JStockentrystat SemStockentry { get; set; } = null!;

    public virtual JStockevent? SemStockevent { get; set; }
}
