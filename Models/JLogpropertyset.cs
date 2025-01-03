using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogpropertyset
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string ProsType { get; set; } = null!;

    public string ProsKey { get; set; } = null!;

    public string ProsDescr { get; set; } = null!;

    public DateTime? ProsTimecheckout { get; set; }

    public string? ProsCheckoutdescr { get; set; }

    public string? ProsFilename { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
