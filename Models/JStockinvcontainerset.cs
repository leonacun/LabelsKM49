using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockinvcontainerset
{
    public decimal SticsId { get; set; }

    public decimal SticsStockinvId { get; set; }

    public decimal SticsContainersetId { get; set; }

    public DateTime SticsTcreation { get; set; }

    public DateTime SticsTupdate { get; set; }

    public DateTime? SticsTimecountingended { get; set; }

    public virtual JContainerset SticsContainerset { get; set; } = null!;

    public virtual JStockinv SticsStockinv { get; set; } = null!;
}
