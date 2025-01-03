using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStocksubstevent
{
    public decimal SseId { get; set; }

    public decimal SseStockentryId { get; set; }

    public decimal SseSubststockentryId { get; set; }

    public decimal? SseTransitionId { get; set; }

    public decimal? SseProdjobentryId { get; set; }

    public decimal? SseParentsubjectId { get; set; }

    public decimal? SseProdstepId { get; set; }

    public DateTime SseTcreation { get; set; }

    public decimal SseAmount { get; set; }

    public DateTime? SseExported { get; set; }

    public virtual JSubject? SseParentsubject { get; set; }

    public virtual JProdjobentry? SseProdjobentry { get; set; }

    public virtual JProdstep? SseProdstep { get; set; }

    public virtual JStockentrystat SseStockentry { get; set; } = null!;

    public virtual JStockentrystat SseSubststockentry { get; set; } = null!;

    public virtual JTransition? SseTransition { get; set; }
}
