using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JAlertset
{
    public decimal AlsId { get; set; }

    public DateTime AlsTcreation { get; set; }

    public DateTime AlsTupdate { get; set; }

    public string AlsKey { get; set; } = null!;

    public string AlsDescr { get; set; } = null!;

    public virtual ICollection<JAlert> JAlerts { get; set; } = new List<JAlert>();

    public virtual ICollection<JMessagecfg> JMessagecfgs { get; set; } = new List<JMessagecfg>();
}
