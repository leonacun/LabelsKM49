using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDocdefpropertyset
{
    public decimal DdpsId { get; set; }

    public decimal DdpsDocdefId { get; set; }

    public decimal DdpsPropertysetId { get; set; }

    public DateTime DdpsTcreation { get; set; }

    public virtual JDocdef DdpsDocdef { get; set; } = null!;

    public virtual JPropertyset DdpsPropertyset { get; set; } = null!;
}
