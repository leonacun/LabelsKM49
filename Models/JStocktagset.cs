using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStocktagset
{
    public decimal SttsId { get; set; }

    public decimal SttsCompanyId { get; set; }

    public DateTime SttsTcreation { get; set; }

    public DateTime SttsTupdate { get; set; }

    public string SttsKey { get; set; } = null!;

    public string SttsDescr { get; set; } = null!;

    public int SttsMintagno { get; set; }

    public int SttsMaxtagno { get; set; }

    public decimal? SttsEdicfgId { get; set; }

    public decimal? SttsCounterId { get; set; }

    public decimal? SttsDoccfgId { get; set; }

    public virtual ICollection<JStockinv> JStockinvs { get; set; } = new List<JStockinv>();

    public virtual ICollection<JStocktag> JStocktags { get; set; } = new List<JStocktag>();

    public virtual JCompany SttsCompany { get; set; } = null!;

    public virtual JCounter? SttsCounter { get; set; }

    public virtual JDoccfg? SttsDoccfg { get; set; }

    public virtual JEdicfg? SttsEdicfg { get; set; }
}
