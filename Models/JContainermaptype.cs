using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainermaptype
{
    public decimal CtmtId { get; set; }

    public decimal CtmtContainermaptypesetId { get; set; }

    public DateTime CtmtTcreation { get; set; }

    public DateTime CtmtTupdate { get; set; }

    public string CtmtKey { get; set; } = null!;

    public string CtmtDescr { get; set; } = null!;

    public bool CtmtKeepsourcestructure { get; set; }

    public string CtmtDomain { get; set; } = null!;

    public virtual JContainermaptypeset CtmtContainermaptypeset { get; set; } = null!;

    public virtual ICollection<JContainermapcfg> JContainermapcfgs { get; set; } = new List<JContainermapcfg>();

    public virtual ICollection<JContainersetcmaptype> JContainersetcmaptypes { get; set; } = new List<JContainersetcmaptype>();

    public virtual ICollection<JStockchannel> JStockchannels { get; set; } = new List<JStockchannel>();
}
