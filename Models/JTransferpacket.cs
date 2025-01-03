using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransferpacket
{
    public decimal TpId { get; set; }

    public decimal TpConnectionId { get; set; }

    public DateTime TpTcreation { get; set; }

    public string? TpExternalname { get; set; }

    public string? TpQualifier1 { get; set; }

    public string? TpQualifier2 { get; set; }

    public int TpNewcount { get; set; }

    public int TpDonecount { get; set; }

    public int TpErrorcount { get; set; }

    public int TpPendingcount { get; set; }

    public int TpIgnoredcount { get; set; }

    public DateTime? TpTimetransferred { get; set; }

    public string? TpTransferrefno { get; set; }

    public virtual ICollection<JTransferrecord> JTransferrecords { get; set; } = new List<JTransferrecord>();

    public virtual JTransferconnection TpConnection { get; set; } = null!;
}
