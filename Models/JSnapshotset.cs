using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSnapshotset
{
    public decimal SnssId { get; set; }

    public DateTime SnssTcreation { get; set; }

    public DateTime SnssTupdate { get; set; }

    public string SnssKey { get; set; } = null!;

    public string SnssDescr { get; set; } = null!;

    public virtual ICollection<JSnapshot> JSnapshots { get; set; } = new List<JSnapshot>();
}
