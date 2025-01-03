using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainersetclassmember
{
    public decimal CtscmId { get; set; }

    public decimal CtscmContainersetclassId { get; set; }

    public decimal CtscmContainersetId { get; set; }

    public DateTime CtscmTcreation { get; set; }

    public DateTime CtscmTupdate { get; set; }

    public virtual JContainerset CtscmContainerset { get; set; } = null!;

    public virtual JContainersetclass CtscmContainersetclass { get; set; } = null!;
}
