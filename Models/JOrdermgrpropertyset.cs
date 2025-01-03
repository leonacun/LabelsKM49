using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrdermgrpropertyset
{
    public decimal OmpsId { get; set; }

    public decimal OmpsOrdermgrId { get; set; }

    public decimal OmpsPropertysetId { get; set; }

    public DateTime OmpsTcreation { get; set; }

    public virtual JOrdermgr OmpsOrdermgr { get; set; } = null!;

    public virtual JPropertyset OmpsPropertyset { get; set; } = null!;
}
