using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogalert
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string AlKeyintype { get; set; } = null!;

    public string AlLevel { get; set; } = null!;

    public string AlMsgseverity { get; set; } = null!;

    public string? AlMessagecode { get; set; }

    public string? AlMessage { get; set; }

    public string? AlContext { get; set; }

    public string? AlApplication { get; set; }

    public DateTime? AlTimeset { get; set; }

    public DateTime? AlTimeconfirmed { get; set; }

    public DateTime? AlTimeescalated { get; set; }

    public DateTime? AlTimemsg { get; set; }

    public DateTime? AlTimesuspendeduntil { get; set; }

    public short AlNrofsuspensions { get; set; }

    public decimal? AlAlertsetId { get; set; }

    public decimal? AlAlerttypeId { get; set; }

    public decimal? AlAlertstateId { get; set; }

    public string? AlDescr { get; set; }

    public string? AlInfo1 { get; set; }

    public string? AlInfo2 { get; set; }

    public string? AlInfo3 { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
