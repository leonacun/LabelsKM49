using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTicketworkflowstate
{
    public decimal TwfstId { get; set; }

    public decimal TwfstTicketworkflowId { get; set; }

    public DateTime TwfstTcreation { get; set; }

    public DateTime TwfstTupdate { get; set; }

    public decimal? TwfstDeletionid { get; set; }

    public DateTime? TwfstTdeletion { get; set; }

    public string TwfstShortname { get; set; } = null!;

    public string TwfstType { get; set; } = null!;

    public string TwfstDescr { get; set; } = null!;

    public virtual ICollection<JTicket> JTickets { get; set; } = new List<JTicket>();

    public virtual JTicketworkflow TwfstTicketworkflow { get; set; } = null!;
}
