using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPartbuffer
{
    public decimal PbId { get; set; }

    public decimal PbCompanyId { get; set; }

    public DateTime PbTcreation { get; set; }

    public DateTime PbTupdate { get; set; }

    public string PbKey { get; set; } = null!;

    public string PbDescr { get; set; } = null!;

    public int PbMaxentryageinminutes { get; set; }

    public short PbMaxentries { get; set; }

    public virtual ICollection<JPartbufferclassmember> JPartbufferclassmembers { get; set; } = new List<JPartbufferclassmember>();

    public virtual ICollection<JPartbufferentry> JPartbufferentries { get; set; } = new List<JPartbufferentry>();

    public virtual JCompany PbCompany { get; set; } = null!;
}
