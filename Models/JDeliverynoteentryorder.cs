using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDeliverynoteentryorder
{
    public decimal DlneoId { get; set; }

    public decimal DlneoDeliverynoteentryId { get; set; }

    public decimal DlneoDeliverynoteorderId { get; set; }

    public decimal? DlneoOrderentryId { get; set; }

    public DateTime DlneoTcreation { get; set; }

    public decimal DlneoAmount { get; set; }

    public virtual JDeliverynoteentry DlneoDeliverynoteentry { get; set; } = null!;

    public virtual JDeliverynoteorder DlneoDeliverynoteorder { get; set; } = null!;

    public virtual JOrderentry? DlneoOrderentry { get; set; }
}
