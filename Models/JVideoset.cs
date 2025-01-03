using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JVideoset
{
    public decimal VisId { get; set; }

    public DateTime VisTcreation { get; set; }

    public DateTime VisTupdate { get; set; }

    public string VisKey { get; set; } = null!;

    public string VisDescr { get; set; } = null!;

    public virtual ICollection<JVideo> JVideos { get; set; } = new List<JVideo>();
}
