using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogattrsubject
{
    public decimal OlsaId { get; set; }

    public decimal OlsaLogsubjectId { get; set; }

    public string OlsaName { get; set; } = null!;

    public string? OlsaValue { get; set; }

    public virtual JLogsubject OlsaLogsubject { get; set; } = null!;
}
