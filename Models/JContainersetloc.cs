using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainersetloc
{
    public decimal CtslId { get; set; }

    public decimal CtslContainersetId { get; set; }

    public decimal? CtslContractId { get; set; }

    public decimal? CtslLocationId { get; set; }

    public DateTime CtslTcreation { get; set; }

    public DateTime CtslTupdate { get; set; }

    public bool CtslIsdefault { get; set; }

    public virtual JContainerset CtslContainerset { get; set; } = null!;

    public virtual JContract? CtslContract { get; set; }

    public virtual JLocation? CtslLocation { get; set; }
}
