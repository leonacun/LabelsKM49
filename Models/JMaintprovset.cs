using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMaintprovset
{
    public decimal MapsId { get; set; }

    public decimal MapsCompanyId { get; set; }

    public DateTime MapsTcreation { get; set; }

    public DateTime MapsTupdate { get; set; }

    public string MapsKey { get; set; } = null!;

    public string MapsDescr { get; set; } = null!;

    public virtual ICollection<JMaintprov> JMaintprovs { get; set; } = new List<JMaintprov>();

    public virtual JCompany MapsCompany { get; set; } = null!;
}
