using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JUserqualificationevent
{
    public decimal UqeId { get; set; }

    public decimal UqeUserqualificationId { get; set; }

    public decimal? UqeTransitionId { get; set; }

    public DateTime UqeTcreation { get; set; }

    public string UqeType { get; set; } = null!;

    public virtual JTransition? UqeTransition { get; set; }

    public virtual JUserqualification UqeUserqualification { get; set; } = null!;
}
