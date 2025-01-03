using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdjobbuffer
{
    public decimal PjbId { get; set; }

    public decimal PjbCompanyId { get; set; }

    public decimal? PjbCounterId { get; set; }

    public DateTime PjbTcreation { get; set; }

    public DateTime PjbTupdate { get; set; }

    public string PjbKey { get; set; } = null!;

    public string PjbDescr { get; set; } = null!;

    public int PjbMaxentryageinminutes { get; set; }

    public short PjbMaxentries { get; set; }

    public virtual ICollection<JProdjobbufferclassm> JProdjobbufferclassms { get; set; } = new List<JProdjobbufferclassm>();

    public virtual ICollection<JProdjobbufferentry> JProdjobbufferentries { get; set; } = new List<JProdjobbufferentry>();

    public virtual JCompany PjbCompany { get; set; } = null!;

    public virtual JCounter? PjbCounter { get; set; }
}
