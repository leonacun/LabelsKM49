using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JAlerttype
{
    public decimal AltId { get; set; }

    public decimal AltAlerttypesetId { get; set; }

    public DateTime AltTcreation { get; set; }

    public DateTime AltTupdate { get; set; }

    public string AltKey { get; set; } = null!;

    public string? AltDescr { get; set; }

    public string AltCategory { get; set; } = null!;

    public string AltDefaultlevel { get; set; } = null!;

    public bool? AltHasautoescalation { get; set; }

    public string AltMinescalationlevel { get; set; } = null!;

    public string AltMaxescalationlevel { get; set; } = null!;

    public short AltEscalationminutes { get; set; }

    public bool? AltHasautoconfirmation { get; set; }

    public string AltMaxautoconfirmationlevel { get; set; } = null!;

    public short AltAutoconfirmationminutes { get; set; }

    public bool? AltHasmsg { get; set; }

    public string AltMinmsglevel { get; set; } = null!;

    public short AltMsgrepetitioninminutes { get; set; }

    public string AltDefaultmsgseverity { get; set; } = null!;

    public bool? AltHassuspension { get; set; }

    public short AltMaxsuspensioninminutes { get; set; }

    public short AltMaxnrofsuspensions { get; set; }

    public virtual JAlerttypeset AltAlerttypeset { get; set; } = null!;

    public virtual ICollection<JAlert> JAlerts { get; set; } = new List<JAlert>();

    public virtual ICollection<JAlertstate> JAlertstates { get; set; } = new List<JAlertstate>();

    public virtual ICollection<JMessagecfg> JMessagecfgs { get; set; } = new List<JMessagecfg>();

    public virtual ICollection<JTransfercontrol> JTransfercontrols { get; set; } = new List<JTransfercontrol>();
}
