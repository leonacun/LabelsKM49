using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransfercpacketmessage
{
    public decimal TcpmId { get; set; }

    public decimal TcpmCpacketId { get; set; }

    public DateTime TcpmTcreation { get; set; }

    public string? TcpmText { get; set; }

    public int TcpmLine { get; set; }

    public virtual JTransfercpacket TcpmCpacket { get; set; } = null!;
}
