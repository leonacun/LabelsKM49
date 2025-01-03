using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainersetcmaptype
{
    public decimal CtscmtId { get; set; }

    public decimal CtscmtContainersetId { get; set; }

    public decimal CtscmtContainermaptypeId { get; set; }

    public DateTime CtscmtTcreation { get; set; }

    public DateTime CtscmtTupdate { get; set; }

    public virtual JContainermaptype CtscmtContainermaptype { get; set; } = null!;

    public virtual JContainerset CtscmtContainerset { get; set; } = null!;
}
