using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrderentry
{
    public decimal OeId { get; set; }

    public decimal OeOrderId { get; set; }

    public decimal? OeReforderentryId { get; set; }

    public decimal? OeTolocationId { get; set; }

    public decimal? OeContractorderId { get; set; }

    public decimal OeSubjectId { get; set; }

    public decimal? OeOthersubjectId { get; set; }

    public decimal? OeUnitofmeasureId { get; set; }

    public DateTime OeTcreation { get; set; }

    public DateTime OeTupdate { get; set; }

    public decimal? OeInvalidid { get; set; }

    public DateTime? OeTvalidfrom { get; set; }

    public DateTime? OeTvaliduntil { get; set; }

    public string? OeNo { get; set; }

    public string? OeVersion { get; set; }

    public string? OeGroup { get; set; }

    public string? OeGroupsequenceno { get; set; }

    public string OeState { get; set; } = null!;

    public string? OeOtherstate { get; set; }

    public bool OeIsinternal { get; set; }

    public decimal OeAmount { get; set; }

    public decimal OeTransformedamount { get; set; }

    public decimal OeAssignedamount { get; set; }

    public decimal OeDeliveredamount { get; set; }

    public decimal OeReceivedamount { get; set; }

    public decimal OePaidamount { get; set; }

    public DateTime? OeScheduledtime { get; set; }

    public DateTime? OeCallofftime { get; set; }

    public DateTime? OeOrderedtime { get; set; }

    public virtual ICollection<JOrderentry> InverseOeReforderentry { get; set; } = new List<JOrderentry>();

    public virtual ICollection<JContainersubject> JContainersubjects { get; set; } = new List<JContainersubject>();

    public virtual ICollection<JContractnoteentry> JContractnoteentries { get; set; } = new List<JContractnoteentry>();

    public virtual ICollection<JDeliverynoteentryorder> JDeliverynoteentryorders { get; set; } = new List<JDeliverynoteentryorder>();

    public virtual ICollection<JDemand> JDemands { get; set; } = new List<JDemand>();

    public virtual ICollection<JLoadplanentry> JLoadplanentries { get; set; } = new List<JLoadplanentry>();

    public virtual ICollection<JOrderentryinfo> JOrderentryinfos { get; set; } = new List<JOrderentryinfo>();

    public virtual ICollection<JPaintplanentryelem> JPaintplanentryelems { get; set; } = new List<JPaintplanentryelem>();

    public virtual ICollection<JPartevent> JPartevents { get; set; } = new List<JPartevent>();

    public virtual ICollection<JPart> JParts { get; set; } = new List<JPart>();

    public virtual ICollection<JProdjobentry> JProdjobentries { get; set; } = new List<JProdjobentry>();

    public virtual ICollection<JProdplanentry> JProdplanentries { get; set; } = new List<JProdplanentry>();

    public virtual ICollection<JProdplanentryelem> JProdplanentryelemPpleeOrderentries { get; set; } = new List<JProdplanentryelem>();

    public virtual ICollection<JProdplanentryelem> JProdplanentryelemPpleeReforderentries { get; set; } = new List<JProdplanentryelem>();

    public virtual ICollection<JSchedule> JSchedules { get; set; } = new List<JSchedule>();

    public virtual ICollection<JStocklocsubject> JStocklocsubjects { get; set; } = new List<JStocklocsubject>();

    public virtual ICollection<JWorkflowjobentry> JWorkflowjobentries { get; set; } = new List<JWorkflowjobentry>();

    public virtual JOrder? OeContractorder { get; set; }

    public virtual JOrder OeOrder { get; set; } = null!;

    public virtual JSubject? OeOthersubject { get; set; }

    public virtual JOrderentry? OeReforderentry { get; set; }

    public virtual JSubject OeSubject { get; set; } = null!;

    public virtual JLocation? OeTolocation { get; set; }

    public virtual JUnitofmeasure? OeUnitofmeasure { get; set; }
}
