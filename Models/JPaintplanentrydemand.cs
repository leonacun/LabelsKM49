using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPaintplanentrydemand
{
    public decimal PpedId { get; set; }

    public decimal PpedPaintplanentryId { get; set; }

    public decimal PpedDemandId { get; set; }

    public DateTime PpedTcreation { get; set; }

    public byte PpedSkidindex { get; set; }

    public virtual JDemand PpedDemand { get; set; } = null!;

    public virtual JPaintplanentry PpedPaintplanentry { get; set; } = null!;
}
