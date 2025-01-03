using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogprodjob
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string PjNo { get; set; } = null!;

    public string? PjDescr { get; set; }

    public string? PjGroup { get; set; }

    public string PjState { get; set; } = null!;

    public string PjStrategy { get; set; } = null!;

    public string? PjSeqno { get; set; }

    public string? PjAltseqno { get; set; }

    public decimal? PjStartseq { get; set; }

    public int PjRetries { get; set; }

    public string PjRetryreason { get; set; } = null!;

    public DateTime? PjScheduledtime { get; set; }

    public string? PjQualifier1 { get; set; }

    public string? PjQualifier2 { get; set; }

    public string? PjQualifier3 { get; set; }

    public decimal? PjProdjobsetId { get; set; }

    public decimal? PjParentId { get; set; }

    public decimal? PjOrderId { get; set; }

    public decimal? PjPaintplanentryId { get; set; }

    public decimal? PjProdstepId { get; set; }

    public decimal? PjProdunitId { get; set; }

    public decimal? PjCommcontrolId { get; set; }

    public decimal? PjContainerId { get; set; }

    public decimal? PjSourcestocklocId { get; set; }

    public decimal? PjDeststocklocId { get; set; }

    public decimal? PjDeststockId { get; set; }

    public decimal? PjProdreplenishmentcfgId { get; set; }

    public decimal? PjWorkflowjobId { get; set; }

    public decimal? PjWorkflowtaskId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
