using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdplanentryelem
{
    public decimal PpleeId { get; set; }

    public decimal? PpleeSubjectId { get; set; }

    public decimal PpleeProdplanentryId { get; set; }

    public DateTime PpleeTcreation { get; set; }

    public DateTime PpleeTupdate { get; set; }

    public decimal PpleeQuantity { get; set; }

    public decimal PpleeProducedquantity { get; set; }

    public decimal PpleeScrapquantity { get; set; }

    public decimal? PpleeOrderentryId { get; set; }

    public decimal? PpleeReforderentryId { get; set; }

    public string PpleePlannedqualityclass { get; set; } = null!;

    public decimal? PpleeProdtoolusageelemId { get; set; }

    public decimal? PpleeFailurereasonId { get; set; }

    public decimal? PpleeTolocationId { get; set; }

    public decimal? PpleeContractorderId { get; set; }

    public virtual JOrder? PpleeContractorder { get; set; }

    public virtual JFailurereason? PpleeFailurereason { get; set; }

    public virtual JOrderentry? PpleeOrderentry { get; set; }

    public virtual JProdplanentry PpleeProdplanentry { get; set; } = null!;

    public virtual JProdtoolusageelem? PpleeProdtoolusageelem { get; set; }

    public virtual JOrderentry? PpleeReforderentry { get; set; }

    public virtual JSubject? PpleeSubject { get; set; }

    public virtual JLocation? PpleeTolocation { get; set; }
}
