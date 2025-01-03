using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPrintcfgset
{
    public decimal PricsId { get; set; }

    public DateTime PricsTcreation { get; set; }

    public DateTime PricsTupdate { get; set; }

    public string PricsKey { get; set; } = null!;

    public string PricsDescr { get; set; } = null!;

    public virtual ICollection<JPrintcfg> JPrintcfgs { get; set; } = new List<JPrintcfg>();
}
