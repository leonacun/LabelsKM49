using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockclassmember
{
    public decimal StclmId { get; set; }

    public decimal StclmStockclassId { get; set; }

    public decimal StclmStockId { get; set; }

    public DateTime StclmTcreation { get; set; }

    public DateTime StclmTupdate { get; set; }

    public virtual JStock StclmStock { get; set; } = null!;

    public virtual JStockclass StclmStockclass { get; set; } = null!;
}
