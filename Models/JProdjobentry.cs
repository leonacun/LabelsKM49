using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdjobentry
{
    public decimal PjeId { get; set; }

    public decimal PjeProdjobId { get; set; }

    public decimal? PjeSubjectId { get; set; }

    public decimal? PjeOrderentryId { get; set; }

    public decimal? PjeContainerentryId { get; set; }

    public DateTime PjeTcreation { get; set; }

    public DateTime PjeTupdate { get; set; }

    public decimal? PjeDeletionid { get; set; }

    public DateTime? PjeTdeletion { get; set; }

    public string PjeState { get; set; } = null!;

    public DateTime? PjeTimerescheduled { get; set; }

    public decimal PjeAmount { get; set; }

    public decimal PjeProducedamount { get; set; }

    public string? PjeNo { get; set; }

    public virtual ICollection<JMsignotification> JMsignotifications { get; set; } = new List<JMsignotification>();

    public virtual ICollection<JProdevent> JProdevents { get; set; } = new List<JProdevent>();

    public virtual ICollection<JStocksubstevent> JStocksubstevents { get; set; } = new List<JStocksubstevent>();

    public virtual JContainerentry? PjeContainerentry { get; set; }

    public virtual JOrderentry? PjeOrderentry { get; set; }

    public virtual JProdjob PjeProdjob { get; set; } = null!;

    public virtual JSubject? PjeSubject { get; set; }
}
