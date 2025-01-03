using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JAlert
{
    public decimal AlId { get; set; }

    public decimal AlAlertsetId { get; set; }

    public decimal AlAlerttypeId { get; set; }

    public DateTime AlTcreation { get; set; }

    public DateTime AlTupdate { get; set; }

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

    public decimal? AlAlertstateId { get; set; }

    public string? AlDescr { get; set; }

    public string? AlInfo1 { get; set; }

    public string? AlInfo2 { get; set; }

    public string? AlInfo3 { get; set; }

    public virtual JAlertset AlAlertset { get; set; } = null!;

    public virtual JAlertstate? AlAlertstate { get; set; }

    public virtual JAlerttype AlAlerttype { get; set; } = null!;
}
