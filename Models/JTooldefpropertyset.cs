using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTooldefpropertyset
{
    public decimal TodpsId { get; set; }

    public decimal TodpsTooldefId { get; set; }

    public decimal TodpsPropertysetId { get; set; }

    public DateTime TodpsTcreation { get; set; }

    public virtual JPropertyset TodpsPropertyset { get; set; } = null!;

    public virtual JTooldef TodpsTooldef { get; set; } = null!;
}
