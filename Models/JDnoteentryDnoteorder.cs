using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDnoteentryDnoteorder
{
    public decimal EntryId { get; set; }

    public decimal OrderId { get; set; }

    public DateTime Tcreation { get; set; }

    public virtual JDeliverynoteentry Entry { get; set; } = null!;

    public virtual JDeliverynoteorder Order { get; set; } = null!;
}
