using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogservicedefpropertyset
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public decimal? SvcdpsServicedefId { get; set; }

    public decimal? SvcdpsPropertysetId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
