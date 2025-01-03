using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerposname
{
    public decimal CtpnId { get; set; }

    public decimal CtpnContainerusageId { get; set; }

    public DateTime CtpnTcreation { get; set; }

    public DateTime CtpnTupdate { get; set; }

    public byte CtpnIndex { get; set; }

    public string CtpnName { get; set; } = null!;

    public virtual JContainerusage CtpnContainerusage { get; set; } = null!;
}
