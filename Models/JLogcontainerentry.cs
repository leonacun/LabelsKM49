using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogcontainerentry
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public short CteIndex { get; set; }

    public string? CtePos { get; set; }

    public decimal? CteContainerId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
