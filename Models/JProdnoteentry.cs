using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdnoteentry
{
    public decimal PneId { get; set; }

    public decimal PneProdnoteId { get; set; }

    public decimal? PneProdjobId { get; set; }

    public DateTime PneTcreation { get; set; }

    public DateTime PneTupdate { get; set; }

    public virtual JProdjob? PneProdjob { get; set; }

    public virtual JProdnote PneProdnote { get; set; } = null!;
}
