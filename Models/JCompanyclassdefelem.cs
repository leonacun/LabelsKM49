using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCompanyclassdefelem
{
    public decimal CocldeId { get; set; }

    public decimal CocldeCompanyclassId { get; set; }

    public decimal? CocldeIncompanyclassId { get; set; }

    public DateTime CocldeTcreation { get; set; }

    public DateTime CocldeTupdate { get; set; }

    public bool? CocldeIscarrier { get; set; }

    public bool? CocldeIscustomer { get; set; }

    public bool? CocldeIssupplier { get; set; }

    public byte[]? CocldeQuery { get; set; }

    public virtual JCompanyclass CocldeCompanyclass { get; set; } = null!;

    public virtual JCompanyclass? CocldeIncompanyclass { get; set; }
}
