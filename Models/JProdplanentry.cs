using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdplanentry
{
    public decimal PpleId { get; set; }

    public decimal PpleProdplanId { get; set; }

    public decimal? PpleSubjectId { get; set; }

    public decimal? PpleProdtoolusageId { get; set; }

    public decimal? PpleOrderentryId { get; set; }

    public decimal? PpleOrderId { get; set; }

    public decimal? PpleProdplanentrytypeId { get; set; }

    public DateTime PpleTcreation { get; set; }

    public DateTime PpleTupdate { get; set; }

    public short PplePos { get; set; }

    public decimal PpleQuantity { get; set; }

    public DateTime? PpleTimestarted { get; set; }

    public DateTime? PpleTimecompleted { get; set; }

    public string PpleState { get; set; } = null!;

    public string? PpleInfo1 { get; set; }

    public string? PpleInfo2 { get; set; }

    public DateTime? PplePlannedstarttime { get; set; }

    public decimal? PplePlanneddurationinsec { get; set; }

    public decimal? PplePlannedbreakinsec { get; set; }

    public decimal? PpleContractId { get; set; }

    public decimal? PplePlannedsetuptimeinsec { get; set; }

    public decimal? PplePlannedteardowntimeinsec { get; set; }

    public virtual ICollection<JProdplanentryelem> JProdplanentryelems { get; set; } = new List<JProdplanentryelem>();

    public virtual JContract? PpleContract { get; set; }

    public virtual JOrder? PpleOrder { get; set; }

    public virtual JOrderentry? PpleOrderentry { get; set; }

    public virtual JProdplan PpleProdplan { get; set; } = null!;

    public virtual JProdplanentrytype? PpleProdplanentrytype { get; set; }

    public virtual JProdtoolusage? PpleProdtoolusage { get; set; }

    public virtual JSubject? PpleSubject { get; set; }
}
