using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTourcontainerdemand
{
    public decimal TcndId { get; set; }

    public decimal TcndTourcontainerId { get; set; }

    public decimal TcndDemandId { get; set; }

    public DateTime TcndTcreation { get; set; }

    public virtual JDemand TcndDemand { get; set; } = null!;

    public virtual JTourcontainer TcndTourcontainer { get; set; } = null!;
}
