using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockinvstockloccnrpart
{
    public decimal StislcpId { get; set; }

    public decimal StislcpSinvstockloccnrId { get; set; }

    public decimal StislcpContainerentryId { get; set; }

    public decimal StislcpPartId { get; set; }

    public DateTime StislcpTcreation { get; set; }

    public DateTime StislcpTupdate { get; set; }

    public virtual JContainerentry StislcpContainerentry { get; set; } = null!;

    public virtual JPart StislcpPart { get; set; } = null!;

    public virtual JStockinvstockloccnr StislcpSinvstockloccnr { get; set; } = null!;
}
