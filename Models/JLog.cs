using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLog
{
    public decimal LogId { get; set; }

    public decimal LogLogsetId { get; set; }

    public DateTime LogTcreation { get; set; }

    public DateTime LogTupdate { get; set; }

    public decimal? LogInvalidid { get; set; }

    public DateTime? LogTvalidfrom { get; set; }

    public DateTime? LogTvaliduntil { get; set; }

    public string LogKey { get; set; } = null!;

    public string? LogDescr { get; set; }

    public virtual ICollection<JLogentry> JLogentries { get; set; } = new List<JLogentry>();

    public virtual ICollection<JMessagecfg> JMessagecfgs { get; set; } = new List<JMessagecfg>();

    public virtual ICollection<JServer> JServers { get; set; } = new List<JServer>();

    public virtual ICollection<JStation> JStations { get; set; } = new List<JStation>();

    public virtual JLogset LogLogset { get; set; } = null!;
}
