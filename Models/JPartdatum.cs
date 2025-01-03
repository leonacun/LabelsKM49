using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPartdatum
{
    public decimal PadId { get; set; }

    public decimal PadPartId { get; set; }

    public DateTime PadTcreation { get; set; }

    public DateTime PadTupdate { get; set; }

    public string PadKey { get; set; } = null!;

    public string? PadValue { get; set; }

    public virtual JPart PadPart { get; set; } = null!;
}
