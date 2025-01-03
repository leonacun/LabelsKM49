using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCsclassmember
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public decimal? CtscmContainersetclassId { get; set; }

    public decimal? CtscmContainersetId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
