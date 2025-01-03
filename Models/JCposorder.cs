using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCposorder
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public byte CtpoIndex { get; set; }

    public byte CtpoOrderindex { get; set; }

    public decimal? CtpoContainerusageId { get; set; }

    public string CtpoType { get; set; } = null!;

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
