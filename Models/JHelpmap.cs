using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JHelpmap
{
    public decimal HmId { get; set; }

    public DateTime HmTcreation { get; set; }

    public DateTime HmTupdate { get; set; }

    public string HmKey { get; set; } = null!;

    public string HmDescr { get; set; } = null!;

    public virtual ICollection<JHelpmapentry> JHelpmapentries { get; set; } = new List<JHelpmapentry>();
}
