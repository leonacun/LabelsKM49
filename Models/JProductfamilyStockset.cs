using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProductfamilyStockset
{
    public decimal ProductfamilyId { get; set; }

    public decimal StocksetId { get; set; }

    public DateTime Tcreation { get; set; }

    public virtual JProductfamily Productfamily { get; set; } = null!;

    public virtual JStockset Stockset { get; set; } = null!;
}
