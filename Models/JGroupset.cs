using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JGroupset
{
    public decimal GsId { get; set; }

    public decimal GsCompanyId { get; set; }

    public DateTime GsTcreation { get; set; }

    public DateTime GsTupdate { get; set; }

    public string GsKey { get; set; } = null!;

    public string GsDescr { get; set; } = null!;

    public virtual JCompany GsCompany { get; set; } = null!;

    public virtual ICollection<JGroup> JGroups { get; set; } = new List<JGroup>();
}
