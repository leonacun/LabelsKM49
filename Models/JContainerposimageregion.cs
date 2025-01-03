using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerposimageregion
{
    public decimal CtpirId { get; set; }

    public decimal CtpirContainerusageId { get; set; }

    public decimal CtpirImageregionId { get; set; }

    public DateTime CtpirTcreation { get; set; }

    public DateTime CtpirTupdate { get; set; }

    public byte CtpirIndex { get; set; }

    public virtual JContainerusage CtpirContainerusage { get; set; } = null!;

    public virtual JImageregion CtpirImageregion { get; set; } = null!;
}
