using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrdercontrolresultitem
{
    public decimal OcriId { get; set; }

    public decimal OcriOcresultId { get; set; }

    public decimal OcriOrderId { get; set; }

    public DateTime OcriTcreation { get; set; }

    public virtual JOrdercontrolresult OcriOcresult { get; set; } = null!;

    public virtual JOrder OcriOrder { get; set; } = null!;
}
