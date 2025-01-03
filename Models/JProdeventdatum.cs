using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdeventdatum
{
    public decimal PredId { get; set; }

    public decimal PredProdeventId { get; set; }

    public decimal? PredFailurereasonId { get; set; }

    public decimal? PredFailuredetailId { get; set; }

    public decimal? PredImageId { get; set; }

    public DateTime PredTcreation { get; set; }

    public decimal PredLocx { get; set; }

    public decimal PredLocy { get; set; }

    public decimal PredLocz { get; set; }

    public string? PredImageregioncode { get; set; }

    public string? PredInfo1 { get; set; }

    public string? PredInfo2 { get; set; }

    public string? PredKey1 { get; set; }

    public string? PredKey2 { get; set; }

    public string? PredKey3 { get; set; }

    public virtual JFailuredetail? PredFailuredetail { get; set; }

    public virtual JFailurereason? PredFailurereason { get; set; }

    public virtual JImage? PredImage { get; set; }

    public virtual JProdevent PredProdevent { get; set; } = null!;
}
