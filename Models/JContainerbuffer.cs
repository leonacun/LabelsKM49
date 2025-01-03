using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerbuffer
{
    public decimal CtbId { get; set; }

    public decimal CtbCompanyId { get; set; }

    public DateTime CtbTcreation { get; set; }

    public DateTime CtbTupdate { get; set; }

    public string CtbKey { get; set; } = null!;

    public string CtbDescr { get; set; } = null!;

    public int CtbMaxentryageinminutes { get; set; }

    public short CtbMaxentries { get; set; }

    public virtual JCompany CtbCompany { get; set; } = null!;

    public virtual ICollection<JContainerbufferclassm> JContainerbufferclassms { get; set; } = new List<JContainerbufferclassm>();

    public virtual ICollection<JContainerbufferentry> JContainerbufferentries { get; set; } = new List<JContainerbufferentry>();
}
