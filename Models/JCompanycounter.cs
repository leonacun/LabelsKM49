using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCompanycounter
{
    public decimal CocId { get; set; }

    public decimal CocCompanyId { get; set; }

    public decimal CocCounterId { get; set; }

    public DateTime CocTcreation { get; set; }

    public virtual JCompany CocCompany { get; set; } = null!;

    public virtual JCounter CocCounter { get; set; } = null!;
}
