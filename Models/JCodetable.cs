using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCodetable
{
    public decimal CotId { get; set; }

    public decimal CotCompanyId { get; set; }

    public DateTime CotTcreation { get; set; }

    public DateTime CotTupdate { get; set; }

    public string CotKey { get; set; } = null!;

    public string CotDescr { get; set; } = null!;

    public virtual JCompany CotCompany { get; set; } = null!;

    public virtual ICollection<JCodetableentry> JCodetableentries { get; set; } = new List<JCodetableentry>();

    public virtual ICollection<JLoginpolicyitem> JLoginpolicyitems { get; set; } = new List<JLoginpolicyitem>();
}
