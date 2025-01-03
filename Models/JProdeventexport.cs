using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdeventexport
{
    public decimal PreeId { get; set; }

    public decimal PreeProdeventId { get; set; }

    public decimal? PreeTransfercpacketId { get; set; }

    public DateTime PreeTcreation { get; set; }

    public string? PreeInfo1 { get; set; }

    public string? PreeInfo2 { get; set; }

    public virtual JProdevent PreeProdevent { get; set; } = null!;

    public virtual JTransfercpacket? PreeTransfercpacket { get; set; }
}
