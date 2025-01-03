using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerevent
{
    public decimal CtevId { get; set; }

    public decimal CtevContainerId { get; set; }

    public decimal? CtevTransitionId { get; set; }

    public decimal? CtevStockId { get; set; }

    public decimal? CtevProdunitId { get; set; }

    public DateTime CtevTcreation { get; set; }

    public string CtevStatus { get; set; } = null!;

    public string? CtevQualityclass { get; set; }

    public decimal? CtevOrderId { get; set; }

    public virtual JContainer CtevContainer { get; set; } = null!;

    public virtual JOrder? CtevOrder { get; set; }

    public virtual JProdunit? CtevProdunit { get; set; }

    public virtual JStock? CtevStock { get; set; }

    public virtual JTransition? CtevTransition { get; set; }

    public virtual ICollection<JContainerevententry> JContainerevententries { get; set; } = new List<JContainerevententry>();
}
