using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLocationTtemplate
{
    public decimal LocationId { get; set; }

    public decimal TourtemplateId { get; set; }

    public DateTime Tcreation { get; set; }

    public virtual JLocation Location { get; set; } = null!;

    public virtual JTourtemplate Tourtemplate { get; set; } = null!;
}
