using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMaintdefprodunit
{
    public decimal MadpuId { get; set; }

    public decimal MadpuMaintdefId { get; set; }

    public decimal MadpuProdunitId { get; set; }

    public DateTime MadpuTcreation { get; set; }

    public DateTime MadpuTupdate { get; set; }

    public virtual JMaintdef MadpuMaintdef { get; set; } = null!;

    public virtual JProdunit MadpuProdunit { get; set; } = null!;
}
