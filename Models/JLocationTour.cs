using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLocationTour
{
    public decimal LocationId { get; set; }

    public decimal TourId { get; set; }

    public DateTime Tcreation { get; set; }

    public virtual JLocation Location { get; set; } = null!;

    public virtual JTour Tour { get; set; } = null!;
}
