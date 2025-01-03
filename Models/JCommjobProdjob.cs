using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCommjobProdjob
{
    public decimal CommjobId { get; set; }

    public decimal ProdjobId { get; set; }

    public DateTime Tcreation { get; set; }

    public virtual JCommjob Commjob { get; set; } = null!;

    public virtual JProdjob Prodjob { get; set; } = null!;
}
