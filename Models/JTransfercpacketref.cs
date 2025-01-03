using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransfercpacketref
{
    public decimal TcprId { get; set; }

    public decimal TcprCpacketId { get; set; }

    public DateTime TcprTcreation { get; set; }

    public decimal TcprObjectid { get; set; }

    public string TcprObjectclassname { get; set; } = null!;

    public string? TcprObjectinfo1 { get; set; }

    public string? TcprObjectinfo2 { get; set; }

    public string? TcprRoleinfo1 { get; set; }

    public string? TcprRoleinfo2 { get; set; }

    public virtual JTransfercpacket TcprCpacket { get; set; } = null!;
}
