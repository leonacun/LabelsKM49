using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransferrecord
{
    public decimal TrId { get; set; }

    public decimal TrPacketId { get; set; }

    public DateTime TrTcreation { get; set; }

    public string TrStatus { get; set; } = null!;

    public string TrPrevstatus { get; set; } = null!;

    public string TrData { get; set; } = null!;

    public virtual ICollection<JTransfermessage> JTransfermessages { get; set; } = new List<JTransfermessage>();

    public virtual JTransferpacket TrPacket { get; set; } = null!;
}
