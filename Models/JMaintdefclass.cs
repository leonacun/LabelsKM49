using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMaintdefclass
{
    public decimal MadclId { get; set; }

    public decimal MadclCompanyId { get; set; }

    public DateTime MadclTcreation { get; set; }

    public DateTime MadclTupdate { get; set; }

    public string MadclKey { get; set; } = null!;

    public string MadclDescr { get; set; } = null!;

    public virtual ICollection<JMaintdefclassmember> JMaintdefclassmembers { get; set; } = new List<JMaintdefclassmember>();

    public virtual JCompany MadclCompany { get; set; } = null!;
}
