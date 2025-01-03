using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkidbuffer
{
    public decimal SkbId { get; set; }

    public decimal SkbCompanyId { get; set; }

    public DateTime SkbTcreation { get; set; }

    public DateTime SkbTupdate { get; set; }

    public string SkbKey { get; set; } = null!;

    public string SkbDescr { get; set; } = null!;

    public int SkbMaxentryageinminutes { get; set; }

    public short SkbMaxentries { get; set; }

    public virtual ICollection<JSkidbufferclassmember> JSkidbufferclassmembers { get; set; } = new List<JSkidbufferclassmember>();

    public virtual ICollection<JSkidbufferentry> JSkidbufferentries { get; set; } = new List<JSkidbufferentry>();

    public virtual JCompany SkbCompany { get; set; } = null!;
}
