using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContractclassdefelem
{
    public decimal CcldeId { get; set; }

    public decimal CcldeContractclassId { get; set; }

    public decimal? CcldeIncontractclassId { get; set; }

    public decimal? CcldeOthercompanyclassId { get; set; }

    public DateTime CcldeTcreation { get; set; }

    public DateTime CcldeTupdate { get; set; }

    public string? CcldeContractkind { get; set; }

    public byte[]? CcldeQuery { get; set; }

    public virtual JContractclass CcldeContractclass { get; set; } = null!;

    public virtual JContractclass? CcldeIncontractclass { get; set; }

    public virtual JCompanyclass? CcldeOthercompanyclass { get; set; }
}
