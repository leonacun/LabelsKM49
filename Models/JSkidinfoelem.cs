using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkidinfoelem
{
    public decimal SkieId { get; set; }

    public decimal SkieSkidinfoId { get; set; }

    public decimal SkiePaintplanentryelemId { get; set; }

    public DateTime SkieTcreation { get; set; }

    public decimal SkieQuantity { get; set; }

    public decimal SkieReworkquantity { get; set; }

    public virtual JPaintplanentryelem SkiePaintplanentryelem { get; set; } = null!;

    public virtual JSkidinfo SkieSkidinfo { get; set; } = null!;
}
