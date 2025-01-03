using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockinvitem
{
    public decimal StiiId { get; set; }

    public decimal StiiStockinvId { get; set; }

    public decimal StiiStocklocId { get; set; }

    public decimal? StiiContainerId { get; set; }

    public decimal? StiiSubjectId { get; set; }

    public DateTime StiiTcreation { get; set; }

    public DateTime StiiTupdate { get; set; }

    public decimal StiiAmount { get; set; }

    public string? StiiContainerentrypos { get; set; }

    public decimal? StiiPartId { get; set; }

    public virtual JContainer? StiiContainer { get; set; }

    public virtual JPart? StiiPart { get; set; }

    public virtual JStockinv StiiStockinv { get; set; } = null!;

    public virtual JStockloc StiiStockloc { get; set; } = null!;

    public virtual JSubject? StiiSubject { get; set; }
}
