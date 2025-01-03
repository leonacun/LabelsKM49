using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JFreasongroupmember
{
    public decimal FrgmId { get; set; }

    public decimal FrgmFreasongroupId { get; set; }

    public decimal FrgmFailurereasonId { get; set; }

    public DateTime FrgmTcreation { get; set; }

    public DateTime FrgmTupdate { get; set; }

    public virtual JFailurereason FrgmFailurereason { get; set; } = null!;

    public virtual JFreasongroup FrgmFreasongroup { get; set; } = null!;
}
