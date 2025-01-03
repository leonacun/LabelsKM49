using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDoccfgitem
{
    public decimal DcfiId { get; set; }

    public decimal DcfiDoccfgId { get; set; }

    public decimal DcfiDocdefId { get; set; }

    public decimal? DcfiPrintitemId { get; set; }

    public DateTime DcfiTcreation { get; set; }

    public DateTime DcfiTupdate { get; set; }

    public string? DcfiKey { get; set; }

    public string? DcfiRole { get; set; }

    public bool? DcfiEnabled { get; set; }

    public virtual JDoccfg DcfiDoccfg { get; set; } = null!;

    public virtual JDocdef DcfiDocdef { get; set; } = null!;

    public virtual JPrintitem? DcfiPrintitem { get; set; }
}
