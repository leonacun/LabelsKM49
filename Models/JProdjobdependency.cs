using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdjobdependency
{
    public decimal PjdeId { get; set; }

    public decimal PjdeProdjobId { get; set; }

    public DateTime PjdeTcreation { get; set; }

    public DateTime PjdeTupdate { get; set; }

    public virtual ICollection<JProdjobdependencyitem> JProdjobdependencyitems { get; set; } = new List<JProdjobdependencyitem>();

    public virtual JProdjob PjdeProdjob { get; set; } = null!;
}
