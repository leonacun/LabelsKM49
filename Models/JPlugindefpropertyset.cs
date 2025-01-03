using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPlugindefpropertyset
{
    public decimal PldpsId { get; set; }

    public decimal PldpsPlugindefId { get; set; }

    public decimal PldpsPropertysetId { get; set; }

    public DateTime PldpsTcreation { get; set; }

    public virtual JPlugindef PldpsPlugindef { get; set; } = null!;

    public virtual JPropertyset PldpsPropertyset { get; set; } = null!;
}
