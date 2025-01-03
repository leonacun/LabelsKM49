using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdunitdatum
{
    public decimal PudId { get; set; }

    public decimal PudProdunitId { get; set; }

    public DateTime PudTcreation { get; set; }

    public DateTime PudTupdate { get; set; }

    public string PudKey { get; set; } = null!;

    public string? PudValue { get; set; }

    public virtual JProdunit PudProdunit { get; set; } = null!;
}
