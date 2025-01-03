using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockloccontainer
{
    public decimal StlcId { get; set; }

    public decimal StlcStocklocId { get; set; }

    public decimal StlcContainerId { get; set; }

    public DateTime StlcTcreation { get; set; }

    public DateTime StlcTupdate { get; set; }

    public bool StlcIsreserved { get; set; }

    public virtual ICollection<JStockre> JStockres { get; set; } = new List<JStockre>();

    public virtual JContainer StlcContainer { get; set; } = null!;

    public virtual JStockloc StlcStockloc { get; set; } = null!;
}
