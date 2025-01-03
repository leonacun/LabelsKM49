using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMaintdefcond
{
    public decimal MadcId { get; set; }

    public decimal MadcMaintdefId { get; set; }

    public DateTime MadcTcreation { get; set; }

    public DateTime MadcTupdate { get; set; }

    public string MadcType { get; set; } = null!;

    public string? MadcDescr { get; set; }

    public short MadcNrofcycles { get; set; }

    public int MadcMinutes { get; set; }

    public virtual JMaintdef MadcMaintdef { get; set; } = null!;
}
