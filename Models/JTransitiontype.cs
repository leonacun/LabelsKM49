using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransitiontype
{
    public decimal TrtId { get; set; }

    public decimal TrtTranstypesetId { get; set; }

    public DateTime TrtTcreation { get; set; }

    public string TrtKey { get; set; } = null!;

    public string TrtDescr { get; set; } = null!;

    public virtual ICollection<JStockcfg> JStockcfgs { get; set; } = new List<JStockcfg>();

    public virtual ICollection<JTransition> JTransitions { get; set; } = new List<JTransition>();

    public virtual JTransitiontypeset TrtTranstypeset { get; set; } = null!;
}
