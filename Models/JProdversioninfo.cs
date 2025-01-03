using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdversioninfo
{
    public decimal PviId { get; set; }

    public decimal PviProdversionId { get; set; }

    public decimal? PviErpentityId { get; set; }

    public DateTime PviTcreation { get; set; }

    public DateTime PviTupdate { get; set; }

    public string PviType { get; set; } = null!;

    public string? PviKey1 { get; set; }

    public string? PviKey2 { get; set; }

    public string? PviKey3 { get; set; }

    public DateTime? PviTimevalue { get; set; }

    public string? PviStringvalue { get; set; }

    public int? PviIntvalue { get; set; }

    public virtual JErpentity? PviErpentity { get; set; }

    public virtual JProdflowusage PviProdversion { get; set; } = null!;
}
