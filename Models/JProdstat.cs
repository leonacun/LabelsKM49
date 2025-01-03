using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdstat
{
    public decimal PstId { get; set; }

    public decimal PstProdstatsetId { get; set; }

    public decimal? PstProdunitId { get; set; }

    public decimal? PstSubjectclassId { get; set; }

    public DateTime PstTcreation { get; set; }

    public DateTime PstTupdate { get; set; }

    public DateTime PstFromtime { get; set; }

    public DateTime? PstUntiltime { get; set; }

    public decimal PstMaxquantity { get; set; }

    public decimal PstProducedquantity { get; set; }

    public decimal PstGoodquantity { get; set; }

    public decimal PstDowntimeinsec { get; set; }

    public decimal PstPlannedtimeinsec { get; set; }

    public virtual JProdstatset PstProdstatset { get; set; } = null!;

    public virtual JProdunit? PstProdunit { get; set; }

    public virtual JSubjectclass? PstSubjectclass { get; set; }
}
