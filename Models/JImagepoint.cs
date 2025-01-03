using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JImagepoint
{
    public decimal ImpId { get; set; }

    public decimal ImpImageregionId { get; set; }

    public DateTime ImpTcreation { get; set; }

    public decimal ImpX { get; set; }

    public decimal ImpY { get; set; }

    public virtual JImageregion ImpImageregion { get; set; } = null!;
}
