using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMaintdefprodtool
{
    public decimal MadptId { get; set; }

    public decimal MadptMaintdefId { get; set; }

    public decimal MadptProdtoolId { get; set; }

    public DateTime MadptTcreation { get; set; }

    public DateTime MadptTupdate { get; set; }

    public virtual JMaintdef MadptMaintdef { get; set; } = null!;
}
