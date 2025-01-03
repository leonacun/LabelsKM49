using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdunitevent
{
    public decimal PueId { get; set; }

    public decimal PueProduniteventsetId { get; set; }

    public decimal? PueTransitionId { get; set; }

    public decimal? PueProdunitId { get; set; }

    public DateTime PueTcreation { get; set; }

    public string PueEventkind { get; set; } = null!;

    public DateTime? PueTimeedited { get; set; }

    public string? PueInfo1 { get; set; }

    public string? PueInfo2 { get; set; }

    public string? PueInfo3 { get; set; }

    public decimal? PueDuration { get; set; }

    public decimal? PueProdtoolusageId { get; set; }

    public virtual ICollection<JProduniteventdatum> JProduniteventdata { get; set; } = new List<JProduniteventdatum>();

    public virtual JProdtoolusage? PueProdtoolusage { get; set; }

    public virtual JProdunit? PueProdunit { get; set; }

    public virtual JProduniteventset PueProduniteventset { get; set; } = null!;

    public virtual JTransition? PueTransition { get; set; }
}
