using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JImageregionmap
{
    public decimal ImrmId { get; set; }

    public decimal ImrmImageId { get; set; }

    public DateTime ImrmTcreation { get; set; }

    public DateTime ImrmTupdate { get; set; }

    public string ImrmType { get; set; } = null!;

    public virtual JImage ImrmImage { get; set; } = null!;

    public virtual ICollection<JImageregion> JImageregions { get; set; } = new List<JImageregion>();
}
