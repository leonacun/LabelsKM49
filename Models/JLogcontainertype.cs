using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogcontainertype
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string CttKey { get; set; } = null!;

    public string CttDescr { get; set; } = null!;

    public string? CttShortdescr { get; set; }

    public string? CttIconfile { get; set; }

    public decimal CttWeight { get; set; }

    public decimal CttDimx { get; set; }

    public decimal CttDimy { get; set; }

    public decimal CttDimz { get; set; }

    public bool? CttExpendable { get; set; }

    public decimal? CttDimuomId { get; set; }

    public decimal? CttWeightuomId { get; set; }

    public decimal? CttContainertypesetId { get; set; }

    public decimal? CttSubjectId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
