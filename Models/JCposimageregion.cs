using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCposimageregion
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public byte CtpirIndex { get; set; }

    public decimal? CtpirContainerusageId { get; set; }

    public decimal? CtpirImageregionId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
