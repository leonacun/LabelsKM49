using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogcontainerrule
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public byte CtrRowstart { get; set; }

    public byte CtrRowrange { get; set; }

    public byte CtrColumnstart { get; set; }

    public byte CtrColumnrange { get; set; }

    public bool CtrUnused { get; set; }

    public bool CtrSpan { get; set; }

    public string? CtrGroup { get; set; }

    public decimal? CtrContainerusageId { get; set; }

    public decimal? CtrSubjectclassId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
