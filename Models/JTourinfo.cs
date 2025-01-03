using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTourinfo
{
    public decimal TiId { get; set; }

    public decimal TiTourId { get; set; }

    public DateTime TiTcreation { get; set; }

    public DateTime TiTupdate { get; set; }

    public string TiType { get; set; } = null!;

    public string? TiKey { get; set; }

    public DateTime? TiTimevalue { get; set; }

    public string? TiStringvalue { get; set; }

    public virtual JTour TiTour { get; set; } = null!;
}
