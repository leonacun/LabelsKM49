using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JReportclass
{
    public decimal RclId { get; set; }

    public decimal RclCompanyId { get; set; }

    public DateTime RclTcreation { get; set; }

    public DateTime RclTupdate { get; set; }

    public string RclKey { get; set; } = null!;

    public string RclDescr { get; set; } = null!;

    public virtual ICollection<JReportclassmember> JReportclassmembers { get; set; } = new List<JReportclassmember>();

    public virtual JCompany RclCompany { get; set; } = null!;
}
