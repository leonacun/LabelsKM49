using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdunittoolinfo
{
    public decimal PutiId { get; set; }

    public decimal PutiProdunittoolId { get; set; }

    public DateTime PutiTcreation { get; set; }

    public DateTime PutiTupdate { get; set; }

    public string PutiType { get; set; } = null!;

    public string? PutiKey1 { get; set; }

    public string? PutiKey2 { get; set; }

    public string? PutiKey3 { get; set; }

    public DateTime? PutiTimevalue { get; set; }

    public string? PutiStringvalue { get; set; }

    public int? PutiIntvalue { get; set; }

    public virtual JProdunittool PutiProdunittool { get; set; } = null!;
}
