using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContractinfo
{
    public decimal CiId { get; set; }

    public decimal CiContractId { get; set; }

    public DateTime CiTcreation { get; set; }

    public DateTime CiTupdate { get; set; }

    public string CiType { get; set; } = null!;

    public string? CiKey1 { get; set; }

    public string? CiKey2 { get; set; }

    public string? CiKey3 { get; set; }

    public DateTime? CiTimevalue { get; set; }

    public string? CiStringvalue { get; set; }

    public decimal? CiAddressId { get; set; }

    public int? CiIntvalue { get; set; }

    public decimal? CiErpentityId { get; set; }

    public virtual JAddress? CiAddress { get; set; }

    public virtual JContract CiContract { get; set; } = null!;

    public virtual JErpentity? CiErpentity { get; set; }
}
