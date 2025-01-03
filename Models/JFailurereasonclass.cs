using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JFailurereasonclass
{
    public decimal FrcId { get; set; }

    public decimal FrcCompanyId { get; set; }

    public DateTime FrcTcreation { get; set; }

    public DateTime FrcTupdate { get; set; }

    public string FrcKey { get; set; } = null!;

    public string FrcDescr { get; set; } = null!;

    public virtual JCompany FrcCompany { get; set; } = null!;

    public virtual ICollection<JFailurereasonclassmember> JFailurereasonclassmembers { get; set; } = new List<JFailurereasonclassmember>();
}
