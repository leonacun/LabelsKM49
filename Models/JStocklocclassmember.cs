using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStocklocclassmember
{
    public decimal StlclmId { get; set; }

    public decimal StlclmStocklocclassId { get; set; }

    public decimal StlclmStocklocId { get; set; }

    public DateTime StlclmTcreation { get; set; }

    public DateTime StlclmTupdate { get; set; }

    public virtual JStockloc StlclmStockloc { get; set; } = null!;

    public virtual JStocklocclass StlclmStocklocclass { get; set; } = null!;
}
