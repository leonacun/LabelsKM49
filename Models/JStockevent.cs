using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockevent
{
    public decimal SeId { get; set; }

    public decimal SeStockentryId { get; set; }

    public decimal? SeTransitionId { get; set; }

    public decimal? SeReasoncodeId { get; set; }

    public decimal? SeStocklocId { get; set; }

    public decimal? SeContainerentryId { get; set; }

    public decimal? SeRefstockeventId { get; set; }

    public DateTime SeTcreation { get; set; }

    public decimal SeOldamount { get; set; }

    public decimal SeNewamount { get; set; }

    public decimal? SeOldreservedamount { get; set; }

    public decimal? SeNewreservedamount { get; set; }

    public DateTime? SeExported { get; set; }

    public bool? SeIssubst { get; set; }

    public decimal? SeOldlockedamount { get; set; }

    public decimal? SeNewlockedamount { get; set; }

    public virtual ICollection<JStockevent> InverseSeRefstockevent { get; set; } = new List<JStockevent>();

    public virtual ICollection<JStockentrymark> JStockentrymarks { get; set; } = new List<JStockentrymark>();

    public virtual JContainerentry? SeContainerentry { get; set; }

    public virtual JCodetableentry? SeReasoncode { get; set; }

    public virtual JStockevent? SeRefstockevent { get; set; }

    public virtual JStockentrystat SeStockentry { get; set; } = null!;

    public virtual JStockloc? SeStockloc { get; set; }

    public virtual JTransition? SeTransition { get; set; }
}
