using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainermapcfg
{
    public decimal CtmcId { get; set; }

    public decimal CtmcContainermaptypeId { get; set; }

    public decimal? CtmcSourcecontainersetId { get; set; }

    public decimal? CtmcSubjecttypeId { get; set; }

    public decimal? CtmcSubjectattrId { get; set; }

    public decimal? CtmcSubjectId { get; set; }

    public decimal? CtmcContractId { get; set; }

    public decimal? CtmcTolocationId { get; set; }

    public decimal? CtmcContainersetId { get; set; }

    public DateTime CtmcTcreation { get; set; }

    public DateTime CtmcTupdate { get; set; }

    public string? CtmcDescr { get; set; }

    public byte CtmcPriorityinscore { get; set; }

    public string? CtmcAttrvalues { get; set; }

    public decimal? CtmcStockId { get; set; }

    public virtual JContainermaptype CtmcContainermaptype { get; set; } = null!;

    public virtual JContainerset? CtmcContainerset { get; set; }

    public virtual JContract? CtmcContract { get; set; }

    public virtual JContainerset? CtmcSourcecontainerset { get; set; }

    public virtual JStock? CtmcStock { get; set; }

    public virtual JSubject? CtmcSubject { get; set; }

    public virtual JSubjectattr? CtmcSubjectattr { get; set; }

    public virtual JSubjecttype? CtmcSubjecttype { get; set; }

    public virtual JLocation? CtmcTolocation { get; set; }
}
