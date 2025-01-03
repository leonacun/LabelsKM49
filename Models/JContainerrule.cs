using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerrule
{
    public decimal CtrId { get; set; }

    public decimal CtrContainerusageId { get; set; }

    public decimal? CtrSubjectclassId { get; set; }

    public DateTime CtrTcreation { get; set; }

    public DateTime CtrTupdate { get; set; }

    public byte CtrRowstart { get; set; }

    public byte CtrRowrange { get; set; }

    public byte CtrColumnstart { get; set; }

    public byte CtrColumnrange { get; set; }

    public bool CtrUnused { get; set; }

    public bool CtrSpan { get; set; }

    public string? CtrGroup { get; set; }

    public virtual JContainerusage CtrContainerusage { get; set; } = null!;

    public virtual JSubjectclass? CtrSubjectclass { get; set; }
}
