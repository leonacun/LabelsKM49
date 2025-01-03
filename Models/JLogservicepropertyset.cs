using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogservicepropertyset
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public decimal? SvcpsServiceId { get; set; }

    public decimal? SvcpsPropertysetId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
