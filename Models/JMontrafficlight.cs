using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMontrafficlight
{
    public decimal MtlId { get; set; }

    public DateTime MtlTcreation { get; set; }

    public string MtlKey { get; set; } = null!;

    public string MtlDescr { get; set; } = null!;

    public short MtlIndex { get; set; }

    public virtual ICollection<JMontrafficlightentry> JMontrafficlightentries { get; set; } = new List<JMontrafficlightentry>();
}
