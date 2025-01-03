using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JAlertstate
{
    public decimal AltstId { get; set; }

    public decimal AltstAlerttypeId { get; set; }

    public decimal? AltstEscalertstateId { get; set; }

    public DateTime AltstTcreation { get; set; }

    public DateTime AltstTupdate { get; set; }

    public string AltstShortname { get; set; } = null!;

    public string? AltstDescr { get; set; }

    public string AltstAlertlevel { get; set; } = null!;

    public bool? AltstIsstartstate { get; set; }

    public bool? AltstHasautoescalation { get; set; }

    public short AltstEscalationminutes { get; set; }

    public bool? AltstHasautoconfirmation { get; set; }

    public short AltstAutoconfirmationminutes { get; set; }

    public bool? AltstHasmsg { get; set; }

    public short AltstMsgrepetitioninminutes { get; set; }

    public string AltstMsgseverity { get; set; } = null!;

    public string? AltstMsgcontext { get; set; }

    public string? AltstMsgapplication { get; set; }

    public bool? AltstHassuspension { get; set; }

    public short AltstMaxsuspensioninminutes { get; set; }

    public string? AltstMsginfo { get; set; }

    public virtual JAlerttype AltstAlerttype { get; set; } = null!;

    public virtual JAlertstate? AltstEscalertstate { get; set; }

    public virtual ICollection<JAlertstate> InverseAltstEscalertstate { get; set; } = new List<JAlertstate>();

    public virtual ICollection<JAlert> JAlerts { get; set; } = new List<JAlert>();
}
