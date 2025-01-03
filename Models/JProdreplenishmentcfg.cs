using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdreplenishmentcfg
{
    public decimal PrcfId { get; set; }

    public decimal PrcfPrcfgsetId { get; set; }

    public decimal? PrcfProdunitId { get; set; }

    public decimal PrcfSubjectId { get; set; }

    public decimal? PrcfSourcestockId { get; set; }

    public decimal? PrcfDeststockId { get; set; }

    public DateTime PrcfTcreation { get; set; }

    public DateTime PrcfTupdate { get; set; }

    public decimal? PrcfDeletionid { get; set; }

    public DateTime? PrcfTdeletion { get; set; }

    public string PrcfCode { get; set; } = null!;

    public string? PrcfDescr { get; set; }

    public string? PrcfSourcedescr { get; set; }

    public string PrcfSourcereservation { get; set; } = null!;

    public string? PrcfDestinationdescr { get; set; }

    public string? PrcfQualifier { get; set; }

    public decimal PrcfQuantity { get; set; }

    public string PrcfStrategy { get; set; } = null!;

    public string? PrcfSheetdoccfgitemrole { get; set; }

    public string? PrcfDestcode { get; set; }

    public string? PrcfSourcecode { get; set; }

    public string? PrcfSensorcode { get; set; }

    public virtual ICollection<JProdjob> JProdjobs { get; set; } = new List<JProdjob>();

    public virtual JStock? PrcfDeststock { get; set; }

    public virtual JProdreplenishmentcfgset PrcfPrcfgset { get; set; } = null!;

    public virtual JProdunit? PrcfProdunit { get; set; }

    public virtual JStock? PrcfSourcestock { get; set; }

    public virtual JSubject PrcfSubject { get; set; } = null!;
}
