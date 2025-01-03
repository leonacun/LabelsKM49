using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogentry
{
    public decimal LogeId { get; set; }

    public decimal LogeLogId { get; set; }

    public decimal? LogeSessionId { get; set; }

    public DateTime LogeTcreation { get; set; }

    public string? LogeMessagecode { get; set; }

    public string? LogeMessage { get; set; }

    public string LogeMsgseverity { get; set; } = null!;

    public string? LogeContext { get; set; }

    public string? LogeApplication { get; set; }

    public decimal? LogeTransitionId { get; set; }

    public virtual ICollection<JLogentryinfo> JLogentryinfos { get; set; } = new List<JLogentryinfo>();

    public virtual JLog LogeLog { get; set; } = null!;

    public virtual JSession? LogeSession { get; set; }

    public virtual JTransition? LogeTransition { get; set; }
}
