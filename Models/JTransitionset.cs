using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransitionset
{
    public decimal TrssId { get; set; }

    public decimal TrssCompanyId { get; set; }

    public DateTime TrssTcreation { get; set; }

    public DateTime TrssTupdate { get; set; }

    public string TrssKey { get; set; } = null!;

    public string TrssDescr { get; set; } = null!;

    public virtual ICollection<JTransition> JTransitions { get; set; } = new List<JTransition>();

    public virtual JCompany TrssCompany { get; set; } = null!;
}
