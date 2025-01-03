using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdplanentrytypeinfo
{
    public decimal PpletiId { get; set; }

    public decimal PpletiProdplanentrytypeId { get; set; }

    public DateTime PpletiTcreation { get; set; }

    public DateTime PpletiTupdate { get; set; }

    public string PpletiType { get; set; } = null!;

    public string? PpletiKey1 { get; set; }

    public string? PpletiKey2 { get; set; }

    public string? PpletiKey3 { get; set; }

    public DateTime? PpletiTimevalue { get; set; }

    public string? PpletiStringvalue { get; set; }

    public virtual JProdplanentrytype PpletiProdplanentrytype { get; set; } = null!;
}
