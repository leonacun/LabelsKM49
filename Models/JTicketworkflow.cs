using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTicketworkflow
{
    public decimal TwfId { get; set; }

    public decimal TwfTicketworkflowsetId { get; set; }

    public DateTime TwfTcreation { get; set; }

    public DateTime TwfTupdate { get; set; }

    public decimal? TwfDeletionid { get; set; }

    public DateTime? TwfTdeletion { get; set; }

    public string TwfKey { get; set; } = null!;

    public string TwfDescr { get; set; } = null!;

    public bool? TwfEnabled { get; set; }

    public virtual ICollection<JTicketworkflowstate> JTicketworkflowstates { get; set; } = new List<JTicketworkflowstate>();

    public virtual JTicketworkflowset TwfTicketworkflowset { get; set; } = null!;
}
