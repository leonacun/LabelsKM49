using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdplanset
{
    public decimal PplsId { get; set; }

    public decimal PplsCompanyId { get; set; }

    public DateTime PplsTcreation { get; set; }

    public DateTime PplsTupdate { get; set; }

    public string PplsKey { get; set; } = null!;

    public string PplsDescr { get; set; } = null!;

    public virtual ICollection<JProdplan> JProdplans { get; set; } = new List<JProdplan>();

    public virtual JCompany PplsCompany { get; set; } = null!;
}
