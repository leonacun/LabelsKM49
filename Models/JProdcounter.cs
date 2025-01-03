using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdcounter
{
    public decimal PrcId { get; set; }

    public decimal PrcProdcountersetId { get; set; }

    public decimal? PrcProdstepId { get; set; }

    public decimal? PrcSubjectId { get; set; }

    public decimal? PrcProdunitId { get; set; }

    public DateTime PrcTcreation { get; set; }

    public DateTime PrcTupdate { get; set; }

    public decimal PrcAmount { get; set; }

    public string PrcQualityclass { get; set; } = null!;

    public virtual JProdcounterset PrcProdcounterset { get; set; } = null!;

    public virtual JProdstep? PrcProdstep { get; set; }

    public virtual JProdunit? PrcProdunit { get; set; }

    public virtual JSubject? PrcSubject { get; set; }
}
