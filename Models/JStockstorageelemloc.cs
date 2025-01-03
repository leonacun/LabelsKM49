using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockstorageelemloc
{
    public decimal StselId { get; set; }

    public decimal StselStockstorageelemId { get; set; }

    public decimal StselStocklocId { get; set; }

    public DateTime StselTcreation { get; set; }

    public DateTime StselTupdate { get; set; }

    public int StselRowidx { get; set; }

    public int StselColumnidx { get; set; }

    public virtual JStockloc StselStockloc { get; set; } = null!;

    public virtual JStockstorageelem StselStockstorageelem { get; set; } = null!;
}
