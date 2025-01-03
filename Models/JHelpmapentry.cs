using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JHelpmapentry
{
    public decimal HmeId { get; set; }

    public decimal HmeHelpmapId { get; set; }

    public decimal HmeHelpkeyId { get; set; }

    public decimal HmeHelpproviderId { get; set; }

    public DateTime HmeTcreation { get; set; }

    public DateTime HmeTupdate { get; set; }

    public string? HmeUrl { get; set; }

    public virtual JHelpkey HmeHelpkey { get; set; } = null!;

    public virtual JHelpmap HmeHelpmap { get; set; } = null!;

    public virtual JHelpprovider HmeHelpprovider { get; set; } = null!;
}
