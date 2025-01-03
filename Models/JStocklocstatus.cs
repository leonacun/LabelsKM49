using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStocklocstatus
{
    public decimal StlstId { get; set; }

    public DateTime StlstTcreation { get; set; }

    public DateTime StlstTupdate { get; set; }

    public string StlstCode { get; set; } = null!;

    public string StlstDescr { get; set; } = null!;

    public bool? StlstIseditable { get; set; }

    public bool StlstOpin { get; set; }

    public bool StlstOpout { get; set; }

    public bool StlstOpinventory { get; set; }

    public bool? StlstOpedit { get; set; }

    public virtual ICollection<JStockloc> JStocklocStlBeforeinvstocklocstatuses { get; set; } = new List<JStockloc>();

    public virtual ICollection<JStockloc> JStocklocStlStocklocstatuses { get; set; } = new List<JStockloc>();

    public virtual ICollection<JStocklocclassdefelem> JStocklocclassdefelems { get; set; } = new List<JStocklocclassdefelem>();
}
