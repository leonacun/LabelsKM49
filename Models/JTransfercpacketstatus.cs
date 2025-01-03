using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransfercpacketstatus
{
    public decimal TcpsId { get; set; }

    public decimal TcpsCpacketId { get; set; }

    public DateTime TcpsTcreation { get; set; }

    public DateTime TcpsTupdate { get; set; }

    public int TcpsNewcount { get; set; }

    public int TcpsDonecount { get; set; }

    public int TcpsErrorcount { get; set; }

    public int TcpsPendingcount { get; set; }

    public int TcpsIgnoredcount { get; set; }

    public int TcpsCsize { get; set; }

    public int TcpsSize { get; set; }

    public byte[] TcpsData { get; set; } = null!;

    public virtual JTransfercpacket TcpsCpacket { get; set; } = null!;
}
