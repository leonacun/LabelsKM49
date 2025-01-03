using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JFailurereasonclassmember
{
    public decimal FrcmId { get; set; }

    public decimal FrcmFailurereasonclassId { get; set; }

    public decimal FrcmFailurereasonId { get; set; }

    public DateTime FrcmTcreation { get; set; }

    public DateTime FrcmTupdate { get; set; }

    public virtual JFailurereason FrcmFailurereason { get; set; } = null!;

    public virtual JFailurereasonclass FrcmFailurereasonclass { get; set; } = null!;
}
