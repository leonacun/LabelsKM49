using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogcontainersetloc
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public bool CtslIsdefault { get; set; }

    public decimal? CtslContainersetId { get; set; }

    public decimal? CtslContractId { get; set; }

    public decimal? CtslLocationId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
