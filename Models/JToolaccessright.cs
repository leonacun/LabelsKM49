using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JToolaccessright
{
    public decimal ToarId { get; set; }

    public decimal ToarAccessobjecttypeId { get; set; }

    public decimal ToarToolaccessrightsetId { get; set; }

    public DateTime ToarTcreation { get; set; }

    public DateTime ToarTupdate { get; set; }

    public string ToarKey { get; set; } = null!;

    public string ToarDescr { get; set; } = null!;

    public string ToarType { get; set; } = null!;

    public string ToarAccesscategory { get; set; } = null!;

    public bool ToarEnabled { get; set; }

    public virtual JAccessobjecttype ToarAccessobjecttype { get; set; } = null!;

    public virtual JToolaccessrightset ToarToolaccessrightset { get; set; } = null!;
}
