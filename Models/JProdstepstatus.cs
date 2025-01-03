using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdstepstatus
{
    public decimal PrssId { get; set; }

    public decimal PrssProdstepId { get; set; }

    public decimal? PrssLastcontainerId { get; set; }

    public DateTime PrssTcreation { get; set; }

    public virtual JContainer? PrssLastcontainer { get; set; }

    public virtual JProdstep PrssProdstep { get; set; } = null!;
}
