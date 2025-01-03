using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkidevent
{
    public decimal SkeId { get; set; }

    public decimal SkeSkideventsetId { get; set; }

    public decimal? SkeTransitionId { get; set; }

    public decimal? SkeSkidId { get; set; }

    public DateTime SkeTcreation { get; set; }

    public string SkeEventkind { get; set; } = null!;

    public string? SkeInfo1 { get; set; }

    public string? SkeInfo2 { get; set; }

    public string? SkeInfo3 { get; set; }

    public virtual ICollection<JSkideventdatum> JSkideventdata { get; set; } = new List<JSkideventdatum>();

    public virtual JSkid? SkeSkid { get; set; }

    public virtual JSkideventset SkeSkideventset { get; set; } = null!;

    public virtual JTransition? SkeTransition { get; set; }
}
