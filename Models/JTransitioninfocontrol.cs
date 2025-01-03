using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransitioninfocontrol
{
    public decimal TrsicId { get; set; }

    public DateTime TrsicTcreation { get; set; }

    public DateTime TrsicTupdate { get; set; }

    public string TrsicKey { get; set; } = null!;

    public string? TrsicDescr { get; set; }

    public bool? TrsicEnabled { get; set; }

    public string TrsicObjectclassname { get; set; } = null!;

    public string TrsicInstruction { get; set; } = null!;

    public byte TrsicPriority { get; set; }

    public string? TrsicTransitiontypekeyrx { get; set; }

    public string? TrsicAssoc { get; set; }

    public byte[]? TrsicQuery { get; set; }
}
