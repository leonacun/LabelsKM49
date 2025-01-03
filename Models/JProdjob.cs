using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdjob
{
    public decimal PjId { get; set; }

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

    public decimal? PjWorkflowjobId { get; set; }

    public decimal? PjWorkflowtaskId { get; set; }

    public string? PjGroup { get; set; }

    public decimal? PjPaintplanentryId { get; set; }

    public string? PjQualifier1 { get; set; }

    public string? PjQualifier2 { get; set; }

    public string? PjQualifier3 { get; set; }

    public virtual ICollection<JProdjob> InversePjParent { get; set; } = new List<JProdjob>();

    public virtual ICollection<JProdjobbufferentry> JProdjobbufferentries { get; set; } = new List<JProdjobbufferentry>();

    public virtual ICollection<JProdjobdatum> JProdjobdata { get; set; } = new List<JProdjobdatum>();

    public virtual ICollection<JProdjobdependency> JProdjobdependencies { get; set; } = new List<JProdjobdependency>();

    public virtual ICollection<JProdjobdependencyitem> JProdjobdependencyitems { get; set; } = new List<JProdjobdependencyitem>();

    public virtual ICollection<JProdjobentry> JProdjobentries { get; set; } = new List<JProdjobentry>();

    public virtual ICollection<JProdjobinfo> JProdjobinfos { get; set; } = new List<JProdjobinfo>();

    public virtual ICollection<JProdnoteentry> JProdnoteentries { get; set; } = new List<JProdnoteentry>();

    public virtual ICollection<JProdnote> JProdnotes { get; set; } = new List<JProdnote>();

    public virtual ICollection<JStockre> JStockres { get; set; } = new List<JStockre>();

    public virtual ICollection<JWorktime> JWorktimes { get; set; } = new List<JWorktime>();

    public virtual JCommcontrol? PjCommcontrol { get; set; }

    public virtual JContainer? PjContainer { get; set; }

    public virtual JStock? PjDeststock { get; set; }

    public virtual JStockloc? PjDeststockloc { get; set; }

    public virtual JOrder? PjOrder { get; set; }

    public virtual JPaintplanentry? PjPaintplanentry { get; set; }

    public virtual JProdjob? PjParent { get; set; }

    public virtual JProdjobset PjProdjobset { get; set; } = null!;

    public virtual JProdreplenishmentcfg? PjProdreplenishmentcfg { get; set; }

    public virtual JProdstep PjProdstep { get; set; } = null!;

    public virtual JProdunit? PjProdunit { get; set; }

    public virtual JStockloc? PjSourcestockloc { get; set; }

    public virtual JWorkflowjob? PjWorkflowjob { get; set; }

    public virtual JWorkflowtask? PjWorkflowtask { get; set; }
}
