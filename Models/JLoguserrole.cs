using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLoguserrole
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string UrKey { get; set; } = null!;

    public string UrDescr { get; set; } = null!;

    public decimal? UrCompanyId { get; set; }

    public decimal? UrAccessrightsetId { get; set; }

    public decimal? UrMenuId { get; set; }

    public decimal? UrGroupId { get; set; }

    public bool? UrAllowfilterassignment { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
