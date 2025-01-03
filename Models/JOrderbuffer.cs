using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrderbuffer
{
    public decimal ObId { get; set; }

    public decimal ObCompanyId { get; set; }

    public DateTime ObTcreation { get; set; }

    public DateTime ObTupdate { get; set; }

    public string ObKey { get; set; } = null!;

    public string ObDescr { get; set; } = null!;

    public int ObMaxentryageinminutes { get; set; }

    public short ObMaxentries { get; set; }

    public virtual ICollection<JOrderbufferclassmember> JOrderbufferclassmembers { get; set; } = new List<JOrderbufferclassmember>();

    public virtual ICollection<JOrderbufferentry> JOrderbufferentries { get; set; } = new List<JOrderbufferentry>();

    public virtual JCompany ObCompany { get; set; } = null!;
}
