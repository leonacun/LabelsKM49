using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransferpacketdone
{
    public decimal TpdId { get; set; }

    public decimal TpdConnectionId { get; set; }

    public DateTime TpdTcreation { get; set; }

    public string TpdFilename { get; set; } = null!;

    public virtual JTransferconnection TpdConnection { get; set; } = null!;
}
