using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContractnoteentry
{
    public decimal CnoeId { get; set; }

    public decimal CnoeContractnoteId { get; set; }

    public decimal? CnoeOrderentryId { get; set; }

    public DateTime CnoeTcreation { get; set; }

    public DateTime CnoeTupdate { get; set; }

    public virtual JContractnote CnoeContractnote { get; set; } = null!;

    public virtual JOrderentry? CnoeOrderentry { get; set; }
}
