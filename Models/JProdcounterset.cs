using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdcounterset
{
    public decimal PrcsId { get; set; }

    public decimal PrcsCompanyId { get; set; }

    public DateTime PrcsTcreation { get; set; }

    public DateTime PrcsTupdate { get; set; }

    public string PrcsKey { get; set; } = null!;

    public string PrcsDescr { get; set; } = null!;

    public virtual ICollection<JProdcounter> JProdcounters { get; set; } = new List<JProdcounter>();

    public virtual JCompany PrcsCompany { get; set; } = null!;
}
