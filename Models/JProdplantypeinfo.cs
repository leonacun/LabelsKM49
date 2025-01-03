using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdplantypeinfo
{
    public decimal PpltiId { get; set; }

    public decimal PpltiProdplantypeId { get; set; }

    public DateTime PpltiTcreation { get; set; }

    public DateTime PpltiTupdate { get; set; }

    public string PpltiType { get; set; } = null!;

    public string? PpltiKey1 { get; set; }

    public string? PpltiKey2 { get; set; }

    public string? PpltiKey3 { get; set; }

    public DateTime? PpltiTimevalue { get; set; }

    public string? PpltiStringvalue { get; set; }

    public virtual JProdplantype PpltiProdplantype { get; set; } = null!;
}
