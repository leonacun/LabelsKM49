using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogserver
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string SerKey { get; set; } = null!;

    public string SerDescr { get; set; } = null!;

    public bool? SerLogenabled { get; set; }

    public decimal? SerLogId { get; set; }

    public decimal? SerUseridentpolicyId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
