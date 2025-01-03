using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdlotpart
{
    public decimal PltpId { get; set; }

    public decimal PltpProdlotId { get; set; }

    public decimal PltpPartId { get; set; }

    public DateTime PltpTcreation { get; set; }

    public DateTime PltpTupdate { get; set; }

    public virtual JPart PltpPart { get; set; } = null!;

    public virtual JProdlot PltpProdlot { get; set; } = null!;
}
