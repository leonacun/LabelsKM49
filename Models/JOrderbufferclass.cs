using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrderbufferclass
{
    public decimal ObcId { get; set; }

    public decimal ObcCompanyId { get; set; }

    public DateTime ObcTcreation { get; set; }

    public DateTime ObcTupdate { get; set; }

    public string ObcKey { get; set; } = null!;

    public string ObcDescr { get; set; } = null!;

    public bool ObcUniqueorders { get; set; }

    public virtual ICollection<JOrderbufferclassmember> JOrderbufferclassmembers { get; set; } = new List<JOrderbufferclassmember>();

    public virtual JCompany ObcCompany { get; set; } = null!;
}
