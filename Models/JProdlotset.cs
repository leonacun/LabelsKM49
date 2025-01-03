using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdlotset
{
    public decimal PltsId { get; set; }

    public decimal PltsCompanyId { get; set; }

    public decimal PltsCounterId { get; set; }

    public decimal? PltsDoccfgId { get; set; }

    public DateTime PltsTcreation { get; set; }

    public DateTime PltsTupdate { get; set; }

    public string PltsKey { get; set; } = null!;

    public string PltsDescr { get; set; } = null!;

    public string PltsType { get; set; } = null!;

    public string PltsEditor { get; set; } = null!;

    public virtual ICollection<JProdlot> JProdlots { get; set; } = new List<JProdlot>();

    public virtual JCompany PltsCompany { get; set; } = null!;

    public virtual JCounter PltsCounter { get; set; } = null!;

    public virtual JDoccfg? PltsDoccfg { get; set; }
}
