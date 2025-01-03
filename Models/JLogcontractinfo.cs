using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogcontractinfo
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string CiType { get; set; } = null!;

    public string? CiKey1 { get; set; }

    public string? CiKey2 { get; set; }

    public string? CiKey3 { get; set; }

    public DateTime? CiTimevalue { get; set; }

    public string? CiStringvalue { get; set; }

    public int? CiIntvalue { get; set; }

    public decimal? CiContractId { get; set; }

    public decimal? CiAddressId { get; set; }

    public decimal? CiErpentityId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
