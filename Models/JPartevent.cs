using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPartevent
{
    public decimal PeId { get; set; }

    public decimal PePartId { get; set; }

    public decimal? PeSubjectId { get; set; }

    public decimal? PeStockId { get; set; }

    public decimal? PeContainerentryId { get; set; }

    public decimal? PeOrderentryId { get; set; }

    public decimal? PeTransitionId { get; set; }

    public decimal? PeProdunitId { get; set; }

    public decimal? PeParentpartId { get; set; }

    public DateTime PeTcreation { get; set; }

    public string? PeQualityclass { get; set; }

    public virtual JContainerentry? PeContainerentry { get; set; }

    public virtual JOrderentry? PeOrderentry { get; set; }

    public virtual JPart? PeParentpart { get; set; }

    public virtual JPart PePart { get; set; } = null!;

    public virtual JProdunit? PeProdunit { get; set; }

    public virtual JStock? PeStock { get; set; }

    public virtual JSubject? PeSubject { get; set; }

    public virtual JTransition? PeTransition { get; set; }
}
