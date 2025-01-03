using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCompanyclassmember
{
    public decimal CoclmId { get; set; }

    public decimal CoclmCompanyclassId { get; set; }

    public decimal CoclmCompanyId { get; set; }

    public DateTime CoclmTcreation { get; set; }

    public DateTime CoclmTupdate { get; set; }

    public virtual JCompany CoclmCompany { get; set; } = null!;

    public virtual JCompanyclass CoclmCompanyclass { get; set; } = null!;
}
