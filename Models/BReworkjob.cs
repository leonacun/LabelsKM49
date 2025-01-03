using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class BReworkjob
{
    public decimal? PjId { get; set; }

    public decimal PjProdjobsetId { get; set; }

    public decimal? PjParentId { get; set; }

    public decimal? PjOrderId { get; set; }

    public decimal PjProdstepId { get; set; }

    public decimal? PjProdunitId { get; set; }

    public decimal? PjCommcontrolId { get; set; }

    public decimal? PjContainerId { get; set; }

    public decimal? PjSourcestocklocId { get; set; }

    public decimal? PjDeststocklocId { get; set; }

    public decimal? PjDeststockId { get; set; }

    public decimal? PjProdreplenishmentcfgId { get; set; }

    public DateTime PjTcreation { get; set; }

    public DateTime PjTupdate { get; set; }

    public decimal? PjDeletionid { get; set; }

    public DateTime? PjTdeletion { get; set; }

    public string PjNo { get; set; } = null!;

    public string? PjDescr { get; set; }

    public string PjState { get; set; } = null!;

    public string PjStrategy { get; set; } = null!;

    public string? PjSeqno { get; set; }

    public string? PjAltseqno { get; set; }

    public decimal? PjStartseq { get; set; }

    public int PjRetries { get; set; }

    public string PjRetryreason { get; set; } = null!;

    public DateTime? PjScheduledtime { get; set; }

    public decimal? PrsId { get; set; }

    public decimal PrsProdstepsetId { get; set; }

    public decimal? PrsFreasonsetId { get; set; }

    public decimal? PrsDoccfgId { get; set; }

    public DateTime PrsTcreation { get; set; }

    public string PrsCode { get; set; } = null!;

    public string PrsKey { get; set; } = null!;

    public string PrsDescr { get; set; } = null!;

    public string? PrsLabeltype { get; set; }

    public string? PrsAltlabeltype { get; set; }

    public string PrsKind { get; set; } = null!;

    public bool PrsDohandlestock { get; set; }
}
