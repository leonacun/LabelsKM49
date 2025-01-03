using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JHelpproviderset
{
    public decimal HpsId { get; set; }

    public DateTime HpsTcreation { get; set; }

    public DateTime HpsTupdate { get; set; }

    public string HpsKey { get; set; } = null!;

    public string HpsDescr { get; set; } = null!;

    public virtual ICollection<JHelpprovider> JHelpproviders { get; set; } = new List<JHelpprovider>();
}
