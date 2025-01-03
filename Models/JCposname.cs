using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCposname
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public byte CtpnIndex { get; set; }

    public string CtpnName { get; set; } = null!;

    public decimal? CtpnContainerusageId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
