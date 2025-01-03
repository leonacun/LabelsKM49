using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPartbufferentry
{
    public decimal PbeId { get; set; }

    public decimal PbePartbufferId { get; set; }

    public decimal PbePartId { get; set; }

    public DateTime PbeTcreation { get; set; }

    public DateTime PbeTupdate { get; set; }

    public virtual JPart PbePart { get; set; } = null!;

    public virtual JPartbuffer PbePartbuffer { get; set; } = null!;
}
