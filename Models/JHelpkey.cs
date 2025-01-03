using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JHelpkey
{
    public decimal HkId { get; set; }

    public decimal HkHelpkeysetId { get; set; }

    public DateTime HkTcreation { get; set; }

    public DateTime HkTupdate { get; set; }

    public string HkKey { get; set; } = null!;

    public string? HkDescr { get; set; }

    public bool? HkEnabled { get; set; }

    public virtual JHelpkeyset HkHelpkeyset { get; set; } = null!;

    public virtual ICollection<JHelpmapentry> JHelpmapentries { get; set; } = new List<JHelpmapentry>();
}
