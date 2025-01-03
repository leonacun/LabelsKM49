using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTicketworkflowset
{
    public decimal TwfsId { get; set; }

    public DateTime TwfsTcreation { get; set; }

    public DateTime TwfsTupdate { get; set; }

    public decimal? TwfsDeletionid { get; set; }

    public DateTime? TwfsTdeletion { get; set; }

    public string TwfsKey { get; set; } = null!;

    public string TwfsDescr { get; set; } = null!;

    public virtual ICollection<JTicketworkflow> JTicketworkflows { get; set; } = new List<JTicketworkflow>();
}
