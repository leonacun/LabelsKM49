using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JHelpprovider
{
    public decimal HpId { get; set; }

    public decimal HpHelpprovidersetId { get; set; }

    public DateTime HpTcreation { get; set; }

    public DateTime HpTupdate { get; set; }

    public string HpKey { get; set; } = null!;

    public string HpDescr { get; set; } = null!;

    public string? HpUrl { get; set; }

    public virtual JHelpproviderset HpHelpproviderset { get; set; } = null!;

    public virtual ICollection<JHelpmapentry> JHelpmapentries { get; set; } = new List<JHelpmapentry>();
}
