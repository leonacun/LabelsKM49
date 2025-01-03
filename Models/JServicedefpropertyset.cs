using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JServicedefpropertyset
{
    public decimal SvcdpsId { get; set; }

    public decimal SvcdpsServicedefId { get; set; }

    public decimal SvcdpsPropertysetId { get; set; }

    public DateTime SvcdpsTcreation { get; set; }

    public virtual JPropertyset SvcdpsPropertyset { get; set; } = null!;

    public virtual JServicedef SvcdpsServicedef { get; set; } = null!;
}
