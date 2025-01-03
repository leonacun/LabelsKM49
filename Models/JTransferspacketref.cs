using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransferspacketref
{
    public decimal TsprId { get; set; }

    public decimal TsprSpacketId { get; set; }

    public DateTime TsprTcreation { get; set; }

    public decimal TsprObjectid { get; set; }

    public string TsprObjectclassname { get; set; } = null!;

    public string? TsprObjectinfo1 { get; set; }

    public string? TsprObjectinfo2 { get; set; }

    public string? TsprRoleinfo1 { get; set; }

    public string? TsprRoleinfo2 { get; set; }

    public virtual JTransferspacket TsprSpacket { get; set; } = null!;
}
