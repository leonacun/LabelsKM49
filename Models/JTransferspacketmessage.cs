using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransferspacketmessage
{
    public decimal TspmId { get; set; }

    public decimal TspmSpacketId { get; set; }

    public DateTime TspmTcreation { get; set; }

    public string? TspmText { get; set; }

    public virtual JTransferspacket TspmSpacket { get; set; } = null!;
}
