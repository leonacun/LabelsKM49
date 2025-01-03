using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class BReworkpart
{
    public decimal? PId { get; set; }

    public decimal PPartsetId { get; set; }

    public decimal? PSubjectId { get; set; }

    public decimal? PStockId { get; set; }

    public decimal? PContainerentryId { get; set; }

    public decimal? POrderentryId { get; set; }

    public decimal? PRefpartId { get; set; }

    public decimal? PDoccfgId { get; set; }

    public decimal? PProdunitId { get; set; }

    public decimal? PParentpartId { get; set; }

    public DateTime PTcreation { get; set; }

    public DateTime PTupdate { get; set; }

    public string PNo { get; set; } = null!;

    public string? PQualityclass { get; set; }
}
