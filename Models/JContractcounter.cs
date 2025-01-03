using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContractcounter
{
    public decimal CcnId { get; set; }

    public decimal CcnContractId { get; set; }

    public decimal CcnCounterId { get; set; }

    public DateTime CcnTcreation { get; set; }

    public DateTime CcnTupdate { get; set; }

    public string? CcnDescr { get; set; }

    public string CcnType { get; set; } = null!;

    public string? CcnKey1 { get; set; }

    public string? CcnKey2 { get; set; }

    public string? CcnKey3 { get; set; }

    public virtual JContract CcnContract { get; set; } = null!;

    public virtual JCounter CcnCounter { get; set; } = null!;
}
