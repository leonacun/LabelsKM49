using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMaintprov
{
    public decimal MapId { get; set; }

    public decimal MapMaintprovsetId { get; set; }

    public decimal MapUserId { get; set; }

    public DateTime MapTcreation { get; set; }

    public DateTime MapTupdate { get; set; }

    public string MapKey { get; set; } = null!;

    public string MapDescr { get; set; } = null!;

    public virtual ICollection<JMaintjob> JMaintjobs { get; set; } = new List<JMaintjob>();

    public virtual JMaintprovset MapMaintprovset { get; set; } = null!;

    public virtual JUser MapUser { get; set; } = null!;
}
