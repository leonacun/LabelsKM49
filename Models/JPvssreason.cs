using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPvssreason
{
    public decimal PvrId { get; set; }

    public decimal PvrPvsstypeId { get; set; }

    public decimal PvrFailurereasonId { get; set; }

    public DateTime PvrTcreation { get; set; }

    public DateTime PvrTupdate { get; set; }

    public virtual JFailurereason PvrFailurereason { get; set; } = null!;

    public virtual JPvsstype PvrPvsstype { get; set; } = null!;
}
