using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogservicedef
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string SvcdKey { get; set; } = null!;

    public string SvcdName { get; set; } = null!;

    public string? SvcdDescr { get; set; }

    public decimal? SvcdServerId { get; set; }

    public decimal? SvcdConfigdefId { get; set; }

    public string? SvcdDriver { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
