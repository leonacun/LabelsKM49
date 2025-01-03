using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCommjobContainer
{
    public decimal CommjobId { get; set; }

    public decimal ContainerId { get; set; }

    public DateTime Tcreation { get; set; }

    public virtual JCommjob Commjob { get; set; } = null!;

    public virtual JContainer Container { get; set; } = null!;
}
