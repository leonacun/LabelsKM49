using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JParttransfer
{
    public decimal PatId { get; set; }

    public DateTime PatTcreation { get; set; }

    public string PatPartno { get; set; } = null!;

    public string PatSubjectno { get; set; } = null!;

    public string? PatUnitcode { get; set; }
}
