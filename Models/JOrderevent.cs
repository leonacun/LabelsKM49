using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrderevent
{
    public decimal OevId { get; set; }

    public decimal OevOrderId { get; set; }

    public DateTime OevTcreation { get; set; }

    public string OevEvent { get; set; } = null!;

    public string OevReason { get; set; } = null!;

    public string? OevComment { get; set; }

    public string? OevSequenceno { get; set; }

    public string? OevProdsequenceno { get; set; }

    public decimal? OevTransitionId { get; set; }

    public virtual ICollection<JOrderevententry> JOrderevententries { get; set; } = new List<JOrderevententry>();

    public virtual JOrder OevOrder { get; set; } = null!;

    public virtual JTransition? OevTransition { get; set; }
}
