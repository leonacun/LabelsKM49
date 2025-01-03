using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdlotdatum
{
    public decimal PltdId { get; set; }

    public decimal PltdProdlotId { get; set; }

    public DateTime PltdTcreation { get; set; }

    public DateTime PltdTupdate { get; set; }

    public string PltdType { get; set; } = null!;

    public string? PltdKey { get; set; }

    public string? PltdValue { get; set; }

    public virtual JProdlot PltdProdlot { get; set; } = null!;
}
