using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerinfo
{
    public decimal CtiId { get; set; }

    public decimal CtiContainerId { get; set; }

    public DateTime CtiTcreation { get; set; }

    public DateTime CtiTupdate { get; set; }

    public string CtiType { get; set; } = null!;

    public string? CtiKey { get; set; }

    public DateTime? CtiTimevalue { get; set; }

    public string? CtiStringvalue { get; set; }

    public decimal? CtiDecimalvalue { get; set; }

    public virtual JContainer CtiContainer { get; set; } = null!;
}
