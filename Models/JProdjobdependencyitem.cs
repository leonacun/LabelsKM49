using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdjobdependencyitem
{
    public decimal PjdeiId { get; set; }

    public decimal PjdeiProdjobdependencyId { get; set; }

    public decimal PjdeiFromprodjobId { get; set; }

    public DateTime PjdeiTcreation { get; set; }

    public DateTime PjdeiTupdate { get; set; }

    public virtual JProdjob PjdeiFromprodjob { get; set; } = null!;

    public virtual JProdjobdependency PjdeiProdjobdependency { get; set; } = null!;
}
