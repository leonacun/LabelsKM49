using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JEdidefpropertyset
{
    public decimal EdpsId { get; set; }

    public decimal EdpsEdidefId { get; set; }

    public decimal EdpsPropertysetId { get; set; }

    public DateTime EdpsTcreation { get; set; }

    public virtual JEdidef EdpsEdidef { get; set; } = null!;

    public virtual JPropertyset EdpsPropertyset { get; set; } = null!;
}
