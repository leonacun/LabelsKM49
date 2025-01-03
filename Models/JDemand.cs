using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDemand
{
    public decimal DId { get; set; }

    public decimal DCategoryId { get; set; }

    public decimal? DOrderId { get; set; }

    public decimal DSubjectId { get; set; }

    public decimal? DOthersubjectId { get; set; }

    public decimal? DOrderentryId { get; set; }

    public DateTime DTcreation { get; set; }

    public DateTime DTimestamp { get; set; }

    public DateTime? DUntiltimestamp { get; set; }

    public long DAmount { get; set; }

    public virtual JDemandcategory DCategory { get; set; } = null!;

    public virtual JOrder? DOrder { get; set; }

    public virtual JOrderentry? DOrderentry { get; set; }

    public virtual JSubject? DOthersubject { get; set; }

    public virtual JSubject DSubject { get; set; } = null!;

    public virtual ICollection<JPaintplanentrydemand> JPaintplanentrydemands { get; set; } = new List<JPaintplanentrydemand>();

    public virtual ICollection<JTourcontainerdemand> JTourcontainerdemands { get; set; } = new List<JTourcontainerdemand>();
}
