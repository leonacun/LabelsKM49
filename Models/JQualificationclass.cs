using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JQualificationclass
{
    public decimal QcId { get; set; }

    public decimal QcCompanyId { get; set; }

    public DateTime QcTcreation { get; set; }

    public DateTime QcTupdate { get; set; }

    public string QcKey { get; set; } = null!;

    public string QcDescr { get; set; } = null!;

    public virtual ICollection<JQualificationclassmember> JQualificationclassmembers { get; set; } = new List<JQualificationclassmember>();

    public virtual ICollection<JStation> JStations { get; set; } = new List<JStation>();

    public virtual JCompany QcCompany { get; set; } = null!;
}
