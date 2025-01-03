using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProduniteventset
{
    public decimal PuesId { get; set; }

    public decimal PuesCompanyId { get; set; }

    public DateTime PuesTcreation { get; set; }

    public DateTime PuesTupdate { get; set; }

    public string PuesKey { get; set; } = null!;

    public string PuesDescr { get; set; } = null!;

    public virtual ICollection<JProdunitevent> JProdunitevents { get; set; } = new List<JProdunitevent>();

    public virtual JCompany PuesCompany { get; set; } = null!;
}
