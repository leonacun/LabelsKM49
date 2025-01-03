using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdtoolinfo
{
    public decimal PtiId { get; set; }

    public decimal PtiProdtoolId { get; set; }

    public DateTime PtiTcreation { get; set; }

    public DateTime PtiTupdate { get; set; }

    public string PtiType { get; set; } = null!;

    public string? PtiKey1 { get; set; }

    public string? PtiKey2 { get; set; }

    public string? PtiKey3 { get; set; }

    public DateTime? PtiTimevalue { get; set; }

    public string? PtiStringvalue { get; set; }

    public int? PtiIntvalue { get; set; }

    public virtual JProdtool PtiProdtool { get; set; } = null!;
}
