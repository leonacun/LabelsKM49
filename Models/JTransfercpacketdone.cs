using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransfercpacketdone
{
    public decimal TcpdId { get; set; }

    public decimal TcpdConnectionId { get; set; }

    public DateTime TcpdTcreation { get; set; }

    public string TcpdFilename { get; set; } = null!;

    public virtual JTransferconnection TcpdConnection { get; set; } = null!;
}
