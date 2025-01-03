using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContractclassmember
{
    public decimal CclmId { get; set; }

    public decimal CclmContractclassId { get; set; }

    public decimal CclmContractId { get; set; }

    public DateTime CclmTcreation { get; set; }

    public DateTime CclmTupdate { get; set; }

    public virtual JContract CclmContract { get; set; } = null!;

    public virtual JContractclass CclmContractclass { get; set; } = null!;
}
