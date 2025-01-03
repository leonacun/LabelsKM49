using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogservice
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public bool? SvcEnabled { get; set; }

    public decimal? SvcServicedefId { get; set; }

    public decimal? SvcStationId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
