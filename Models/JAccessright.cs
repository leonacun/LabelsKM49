using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JAccessright
{
    public decimal AcrId { get; set; }

    public decimal AcrAccessrightsetId { get; set; }

    public decimal AcrAccessobjecttypeId { get; set; }

    public decimal AcrAccesssettingsId { get; set; }

    public DateTime AcrTcreation { get; set; }

    public DateTime AcrTupdate { get; set; }

    public virtual JAccessobjecttype AcrAccessobjecttype { get; set; } = null!;

    public virtual JAccessrightset AcrAccessrightset { get; set; } = null!;

    public virtual JAccesssetting AcrAccesssettings { get; set; } = null!;
}
