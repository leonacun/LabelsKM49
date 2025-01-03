using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JImageset
{
    public decimal ImsId { get; set; }

    public DateTime ImsTcreation { get; set; }

    public DateTime ImsTupdate { get; set; }

    public string ImsKey { get; set; } = null!;

    public string ImsDescr { get; set; } = null!;

    public virtual ICollection<JImage> JImages { get; set; } = new List<JImage>();

    public virtual ICollection<JImagesetclassmember> JImagesetclassmembers { get; set; } = new List<JImagesetclassmember>();
}
