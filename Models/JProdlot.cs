using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdlot
{
    public decimal PltId { get; set; }

    public decimal PltProdlotsetId { get; set; }

    public DateTime PltTcreation { get; set; }

    public DateTime PltTupdate { get; set; }

    public string PltNo { get; set; } = null!;

    public string? PltDescr { get; set; }

    public string PltQualityclass { get; set; } = null!;

    public DateTime? PltTimeclosed { get; set; }

    public string PltInspectionstate { get; set; } = null!;

    public decimal? PltDeletionid { get; set; }

    public DateTime? PltTdeletion { get; set; }

    public virtual ICollection<JProdlotcontainer> JProdlotcontainers { get; set; } = new List<JProdlotcontainer>();

    public virtual ICollection<JProdlotdatum> JProdlotdata { get; set; } = new List<JProdlotdatum>();

    public virtual ICollection<JProdlotpart> JProdlotparts { get; set; } = new List<JProdlotpart>();

    public virtual JProdlotset PltProdlotset { get; set; } = null!;
}
