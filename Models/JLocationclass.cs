using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLocationclass
{
    public decimal LcId { get; set; }

    public decimal LcCompanyId { get; set; }

    public DateTime LcTcreation { get; set; }

    public DateTime LcTupdate { get; set; }

    public string LcKey { get; set; } = null!;

    public string LcDescr { get; set; } = null!;

    public virtual ICollection<JLocationclassmember> JLocationclassmembers { get; set; } = new List<JLocationclassmember>();

    public virtual ICollection<JOrdercontrol> JOrdercontrolOcReqtolocationclasses { get; set; } = new List<JOrdercontrol>();

    public virtual ICollection<JOrdercontrol> JOrdercontrolOcTolocationclasses { get; set; } = new List<JOrdercontrol>();

    public virtual ICollection<JOrdereventcfg> JOrdereventcfgs { get; set; } = new List<JOrdereventcfg>();

    public virtual JCompany LcCompany { get; set; } = null!;
}
