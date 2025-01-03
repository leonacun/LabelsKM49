using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCsclass
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string CtscKey { get; set; } = null!;

    public string CtscDescr { get; set; } = null!;

    public decimal? CtscCompanyId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
