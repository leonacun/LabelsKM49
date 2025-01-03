using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransfercpacket
{
    public decimal TcpId { get; set; }

    public decimal TcpConnectionId { get; set; }

    public DateTime TcpTcreation { get; set; }

    public int TcpCsize { get; set; }

    public int TcpSize { get; set; }

    public int TcpLines { get; set; }

    public byte[] TcpData { get; set; } = null!;

    public DateTime? TcpTimetransferred { get; set; }

    public string? TcpExternalname { get; set; }

    public string? TcpQualifier1 { get; set; }

    public string? TcpQualifier2 { get; set; }

    public string? TcpTransferrefno { get; set; }

    public virtual ICollection<JProdeventexport> JProdeventexports { get; set; } = new List<JProdeventexport>();

    public virtual ICollection<JTransfercpacketmessage> JTransfercpacketmessages { get; set; } = new List<JTransfercpacketmessage>();

    public virtual ICollection<JTransfercpacketref> JTransfercpacketrefs { get; set; } = new List<JTransfercpacketref>();

    public virtual JTransfercpacketstatus? JTransfercpacketstatus { get; set; }

    public virtual JTransferconnection TcpConnection { get; set; } = null!;
}
