using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockset
{
    public decimal SsId { get; set; }

    public decimal SsCompanyId { get; set; }

    public DateTime SsTcreation { get; set; }

    public DateTime SsTupdate { get; set; }

    public string SsKey { get; set; } = null!;

    public string SsDescr { get; set; } = null!;

    public virtual ICollection<JStock> JStocks { get; set; } = new List<JStock>();

    public virtual JCompany SsCompany { get; set; } = null!;
}
