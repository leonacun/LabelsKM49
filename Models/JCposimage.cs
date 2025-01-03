using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCposimage
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public byte CtpiIndex { get; set; }

    public decimal? CtpiContainerusageId { get; set; }

    public decimal? CtpiImageId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
