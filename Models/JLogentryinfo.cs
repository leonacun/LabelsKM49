using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogentryinfo
{
    public decimal LogeiId { get; set; }

    public decimal LogeiLogentryId { get; set; }

    public DateTime LogeiTcreation { get; set; }

    public string LogeiType { get; set; } = null!;

    public string? LogeiKey1 { get; set; }

    public DateTime? LogeiTimevalue { get; set; }

    public string? LogeiStringvalue { get; set; }

    public virtual JLogentry LogeiLogentry { get; set; } = null!;
}
