using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContractentry
{
    public decimal CeId { get; set; }

    public decimal CeContractId { get; set; }

    public decimal CeOwnsubjectId { get; set; }

    public decimal CeOthersubjectId { get; set; }

    public decimal? CeContractorderId { get; set; }

    public decimal? CeTolocationId { get; set; }

    public decimal? CeUnitofmeasureId { get; set; }

    public DateTime CeTcreation { get; set; }

    public DateTime CeTupdate { get; set; }

    public decimal? CeHistoryid { get; set; }

    public decimal? CeHistoryrefid { get; set; }

    public string CeNo { get; set; } = null!;

    public bool CeIgnoreedi { get; set; }

    public string? CeInfo1 { get; set; }

    public string? CeInfo2 { get; set; }

    public string? CeInfo3 { get; set; }

    public virtual JContract CeContract { get; set; } = null!;

    public virtual JOrder? CeContractorder { get; set; }

    public virtual JSubject CeOthersubject { get; set; } = null!;

    public virtual JSubject CeOwnsubject { get; set; } = null!;

    public virtual JLocation? CeTolocation { get; set; }

    public virtual JUnitofmeasure? CeUnitofmeasure { get; set; }
}
