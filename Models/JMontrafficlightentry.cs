using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMontrafficlightentry
{
    public decimal MtleId { get; set; }

    public decimal MtleMontrafficlightId { get; set; }

    public decimal MtleProdunitId { get; set; }

    public DateTime MtleTcreation { get; set; }

    public string MtleFunction { get; set; } = null!;

    public virtual JMontrafficlight MtleMontrafficlight { get; set; } = null!;

    public virtual JProdunit MtleProdunit { get; set; } = null!;
}
