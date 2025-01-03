using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JImagesetclassmember
{
    public decimal ImscmId { get; set; }

    public decimal ImscmImagesetclassId { get; set; }

    public decimal ImscmImagesetId { get; set; }

    public DateTime ImscmTcreation { get; set; }

    public DateTime ImscmTupdate { get; set; }

    public virtual JImageset ImscmImageset { get; set; } = null!;

    public virtual JImagesetclass ImscmImagesetclass { get; set; } = null!;
}
