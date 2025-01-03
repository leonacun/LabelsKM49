using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockclass
{
    public decimal StclId { get; set; }

    public decimal StclCompanyId { get; set; }

    public DateTime StclTcreation { get; set; }

    public DateTime StclTupdate { get; set; }

    public string StclKey { get; set; } = null!;

    public string StclDescr { get; set; } = null!;

    public virtual ICollection<JStockchannel> JStockchannels { get; set; } = new List<JStockchannel>();

    public virtual ICollection<JStockclassmember> JStockclassmembers { get; set; } = new List<JStockclassmember>();

    public virtual ICollection<JStockinv> JStockinvs { get; set; } = new List<JStockinv>();

    public virtual JCompany StclCompany { get; set; } = null!;
}
