using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JServicepropertyset
{
    public decimal SvcpsId { get; set; }

    public decimal SvcpsServiceId { get; set; }

    public decimal SvcpsPropertysetId { get; set; }

    public DateTime SvcpsTcreation { get; set; }

    public virtual JPropertyset SvcpsPropertyset { get; set; } = null!;

    public virtual JService SvcpsService { get; set; } = null!;
}
