using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrderbufferentry
{
    public decimal ObeId { get; set; }

    public decimal ObeOrderbufferId { get; set; }

    public decimal ObeOrderId { get; set; }

    public DateTime ObeTcreation { get; set; }

    public DateTime ObeTupdate { get; set; }

    public virtual JOrder ObeOrder { get; set; } = null!;

    public virtual JOrderbuffer ObeOrderbuffer { get; set; } = null!;
}
