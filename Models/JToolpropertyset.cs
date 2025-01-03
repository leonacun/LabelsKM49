using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JToolpropertyset
{
    public decimal TopsId { get; set; }

    public decimal TopsToolId { get; set; }

    public decimal TopsPropertysetId { get; set; }

    public DateTime TopsTcreation { get; set; }

    public virtual JPropertyset TopsPropertyset { get; set; } = null!;

    public virtual JTool TopsTool { get; set; } = null!;
}
