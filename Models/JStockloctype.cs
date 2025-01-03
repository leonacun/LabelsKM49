using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockloctype
{
    public decimal StltId { get; set; }

    public decimal StltCompanyId { get; set; }

    public DateTime StltTcreation { get; set; }

    public DateTime StltTupdate { get; set; }

    public string StltKey { get; set; } = null!;

    public string StltDescr { get; set; } = null!;

    public string? StltDisplaycolor { get; set; }

    public virtual ICollection<JStocklocclassdefelem> JStocklocclassdefelems { get; set; } = new List<JStocklocclassdefelem>();

    public virtual ICollection<JStockloc> JStocklocs { get; set; } = new List<JStockloc>();

    public virtual JCompany StltCompany { get; set; } = null!;
}
