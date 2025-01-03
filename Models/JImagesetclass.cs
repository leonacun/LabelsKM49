using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JImagesetclass
{
    public decimal ImscId { get; set; }

    public DateTime ImscTcreation { get; set; }

    public DateTime ImscTupdate { get; set; }

    public string ImscKey { get; set; } = null!;

    public string ImscDescr { get; set; } = null!;

    public virtual ICollection<JImagesetclassmember> JImagesetclassmembers { get; set; } = new List<JImagesetclassmember>();
}
