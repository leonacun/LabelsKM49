using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdlotcontainer
{
    public decimal PltcId { get; set; }

    public decimal PltcProdlotId { get; set; }

    public decimal PltcContainerId { get; set; }

    public DateTime PltcTcreation { get; set; }

    public DateTime PltcTupdate { get; set; }

    public virtual JContainer PltcContainer { get; set; } = null!;

    public virtual JProdlot PltcProdlot { get; set; } = null!;
}
