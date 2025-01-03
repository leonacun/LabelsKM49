using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JComponentdefpropertyset
{
    public decimal CodpsId { get; set; }

    public decimal CodpsComponentdefId { get; set; }

    public decimal CodpsPropertysetId { get; set; }

    public DateTime CodpsTcreation { get; set; }

    public virtual JComponentdef CodpsComponentdef { get; set; } = null!;

    public virtual JPropertyset CodpsPropertyset { get; set; } = null!;
}
