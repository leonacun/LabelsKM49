using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStocklocclass
{
    public decimal StlclId { get; set; }

    public decimal StlclCompanyId { get; set; }

    public DateTime StlclTcreation { get; set; }

    public DateTime StlclTupdate { get; set; }

    public string StlclKey { get; set; } = null!;

    public string StlclDescr { get; set; } = null!;

    public string StlclDeftype { get; set; } = null!;

    public virtual ICollection<JStockcfg> JStockcfgs { get; set; } = new List<JStockcfg>();

    public virtual ICollection<JStocklocclassdefelem> JStocklocclassdefelemStlcldeInstocklocclasses { get; set; } = new List<JStocklocclassdefelem>();

    public virtual ICollection<JStocklocclassdefelem> JStocklocclassdefelemStlcldeStocklocclasses { get; set; } = new List<JStocklocclassdefelem>();

    public virtual ICollection<JStocklocclassmember> JStocklocclassmembers { get; set; } = new List<JStocklocclassmember>();

    public virtual JCompany StlclCompany { get; set; } = null!;
}
