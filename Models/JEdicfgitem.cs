using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JEdicfgitem
{
    public decimal EcfiId { get; set; }

    public decimal EcfiEdicfgId { get; set; }

    public decimal EcfiEdidefId { get; set; }

    public DateTime EcfiTcreation { get; set; }

    public DateTime EcfiTupdate { get; set; }

    public string? EcfiKey { get; set; }

    public string? EcfiRole { get; set; }

    public bool EcfiEnabled { get; set; }

    public decimal? EcfiConnectionId { get; set; }

    public virtual JTransferconnection? EcfiConnection { get; set; }

    public virtual JEdicfg EcfiEdicfg { get; set; } = null!;

    public virtual JEdidef EcfiEdidef { get; set; } = null!;
}
