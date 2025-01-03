using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class CorOutboxHeader
{
    public decimal CId { get; set; }

    public decimal COutboxId { get; set; }

    public string CHeaderKey { get; set; } = null!;

    public string CHeaderValue { get; set; } = null!;

    public virtual CorOutboxEntry COutbox { get; set; } = null!;
}
