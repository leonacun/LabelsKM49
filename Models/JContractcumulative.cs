using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContractcumulative
{
    public decimal CcId { get; set; }

    public decimal CcContractId { get; set; }

    public decimal CcOwnsubjectId { get; set; }

    public decimal? CcOthersubjectId { get; set; }

    public decimal? CcContractorderId { get; set; }

    public decimal? CcTolocationId { get; set; }

    public decimal? CcUnitofmeasureId { get; set; }

    public decimal? CcTransitionId { get; set; }

    public DateTime CcTcreation { get; set; }

    public DateTime CcTupdate { get; set; }

    public decimal? CcHistoryid { get; set; }

    public decimal? CcHistoryrefid { get; set; }

    public string CcType { get; set; } = null!;

    public string? CcQualifier { get; set; }

    public decimal CcQuantity { get; set; }

    public DateTime? CcQuantityresettime { get; set; }

    public decimal CcAltquantity { get; set; }

    public DateTime? CcAltquantityresettime { get; set; }

    public string? CcLastnoteno { get; set; }

    public DateTime? CcLastnotetime { get; set; }

    public decimal CcLastnotequantity { get; set; }

    public decimal CcAltquantityoffset { get; set; }

    public virtual JContract CcContract { get; set; } = null!;

    public virtual JOrder? CcContractorder { get; set; }

    public virtual JSubject? CcOthersubject { get; set; }

    public virtual JSubject CcOwnsubject { get; set; } = null!;

    public virtual JLocation? CcTolocation { get; set; }

    public virtual JTransition? CcTransition { get; set; }

    public virtual JUnitofmeasure? CcUnitofmeasure { get; set; }
}
