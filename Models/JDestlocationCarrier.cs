using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDestlocationCarrier
{
    public decimal DestlocationId { get; set; }

    public decimal CarrierId { get; set; }

    public DateTime Tcreation { get; set; }

    public virtual JCompany Carrier { get; set; } = null!;

    public virtual JLocation Destlocation { get; set; } = null!;
}
