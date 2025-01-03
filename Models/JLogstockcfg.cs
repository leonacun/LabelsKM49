using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogstockcfg
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string? StcfDescr { get; set; }

    public string? StcfRole { get; set; }

    public string? StcfQualityclass { get; set; }

    public byte StcfPriorityinscore { get; set; }

    public string? StcfAttrvalues { get; set; }

    public string? StcfInfo1 { get; set; }

    public string? StcfInfo2 { get; set; }

    public decimal? StcfTransitiontypeId { get; set; }

    public decimal? StcfStockId { get; set; }

    public decimal? StcfProdstepId { get; set; }

    public decimal? StcfProdunitId { get; set; }

    public decimal? StcfSubjecttypeId { get; set; }

    public decimal? StcfSubjectattrId { get; set; }

    public decimal? StcfSubjectId { get; set; }

    public decimal? StcfContractId { get; set; }

    public decimal? StcfTolocationId { get; set; }

    public decimal? StcfSubjectcomptypeId { get; set; }

    public decimal? StcfSubjectclassId { get; set; }

    public decimal? StcfStocklocId { get; set; }

    public string StcfStocklocstrategy { get; set; } = null!;

    public decimal? StcfStocklocclassId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
