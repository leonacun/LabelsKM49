using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerbufferentry
{
    public decimal CtbeId { get; set; }

    public decimal CtbeContainerbufferId { get; set; }

    public decimal CtbeContainerId { get; set; }

    public DateTime CtbeTcreation { get; set; }

    public DateTime CtbeTupdate { get; set; }

    public virtual JContainer CtbeContainer { get; set; } = null!;

    public virtual JContainerbuffer CtbeContainerbuffer { get; set; } = null!;
}
