using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdplantypeset
{
    public decimal PpltsId { get; set; }

    public decimal PpltsCompanyId { get; set; }

    public DateTime PpltsTcreation { get; set; }

    public DateTime PpltsTupdate { get; set; }

    public string PpltsKey { get; set; } = null!;

    public string PpltsDescr { get; set; } = null!;

    public virtual ICollection<JProdplantype> JProdplantypes { get; set; } = new List<JProdplantype>();

    public virtual JCompany PpltsCompany { get; set; } = null!;
}
