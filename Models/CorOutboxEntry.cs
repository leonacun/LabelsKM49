using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class CorOutboxEntry
{
    public decimal CId { get; set; }

    public byte[]? CXml { get; set; }

    public string CTenantId { get; set; } = null!;

    public byte CMessagePriority { get; set; }

    public DateTime CCreatedDateTime { get; set; }

    public bool CWasProcessed { get; set; }

    public virtual ICollection<CorOutboxHeader> CorOutboxHeaders { get; set; } = new List<CorOutboxHeader>();
}
