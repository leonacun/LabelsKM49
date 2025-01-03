using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockstoragepoint
{
    public decimal StspId { get; set; }

    public decimal StspStockstorageId { get; set; }

    public DateTime StspTcreation { get; set; }

    public DateTime StspTupdate { get; set; }

    public int StspIdx { get; set; }

    public int StspPosx { get; set; }

    public int StspPosy { get; set; }

    public virtual JStockstorage StspStockstorage { get; set; } = null!;
}
