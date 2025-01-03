using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JErptranshist
{
    public decimal EthId { get; set; }

    public decimal EthCompanyId { get; set; }

    public DateTime EthTcreation { get; set; }

    public string? EthPart { get; set; }

    public DateTime? EthDate { get; set; }

    public string? EthType { get; set; }

    public string? EthLoc { get; set; }

    public string? EthNumber { get; set; }

    public string? EthRemarks { get; set; }

    public virtual JCompany EthCompany { get; set; } = null!;
}
