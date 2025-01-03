using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockcfg
{
    public decimal StcfId { get; set; }

    public decimal StcfTransitiontypeId { get; set; }

    public decimal StcfStockId { get; set; }

    public decimal? StcfProdstepId { get; set; }

    public decimal? StcfProdunitId { get; set; }

    public decimal? StcfSubjecttypeId { get; set; }

    public decimal? StcfSubjectId { get; set; }

    public decimal? StcfContractId { get; set; }

    public decimal? StcfSubjectcomptypeId { get; set; }

    public DateTime StcfTcreation { get; set; }

    public DateTime StcfTupdate { get; set; }

    public string? StcfDescr { get; set; }

    public string? StcfRole { get; set; }

    public string? StcfQualityclass { get; set; }

    public byte StcfPriorityinscore { get; set; }

    public decimal? StcfSubjectattrId { get; set; }

    public string? StcfAttrvalues { get; set; }

    public decimal? StcfTolocationId { get; set; }

    public string? StcfInfo1 { get; set; }

    public string? StcfInfo2 { get; set; }

    public decimal? StcfSubjectclassId { get; set; }

    public decimal? StcfStocklocId { get; set; }

    public string StcfStocklocstrategy { get; set; } = null!;

    public decimal? StcfStocklocclassId { get; set; }

    public virtual JContract? StcfContract { get; set; }

    public virtual JProdstep? StcfProdstep { get; set; }

    public virtual JProdunit? StcfProdunit { get; set; }

    public virtual JStock StcfStock { get; set; } = null!;

    public virtual JStockloc? StcfStockloc { get; set; }

    public virtual JStocklocclass? StcfStocklocclass { get; set; }

    public virtual JSubject? StcfSubject { get; set; }

    public virtual JSubjectattr? StcfSubjectattr { get; set; }

    public virtual JSubjectclass? StcfSubjectclass { get; set; }

    public virtual JSubjectcomptype? StcfSubjectcomptype { get; set; }

    public virtual JSubjecttype? StcfSubjecttype { get; set; }

    public virtual JLocation? StcfTolocation { get; set; }

    public virtual JTransitiontype StcfTransitiontype { get; set; } = null!;
}
