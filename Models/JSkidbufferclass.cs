using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkidbufferclass
{
    public decimal SkbcId { get; set; }

    public decimal SkbcCompanyId { get; set; }

    public DateTime SkbcTcreation { get; set; }

    public DateTime SkbcTupdate { get; set; }

    public string SkbcKey { get; set; } = null!;

    public string SkbcDescr { get; set; } = null!;

    public bool SkbcUniqueskids { get; set; }

    public virtual ICollection<JSkidbufferclassmember> JSkidbufferclassmembers { get; set; } = new List<JSkidbufferclassmember>();

    public virtual JCompany SkbcCompany { get; set; } = null!;
}
