using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDeliverynoteorder
{
    public decimal DlnoId { get; set; }

    public decimal DlnoDeliverynoteId { get; set; }

    public decimal? DlnoOrderId { get; set; }

    public DateTime DlnoTcreation { get; set; }

    public string DlnoOrderno { get; set; } = null!;

    public virtual JDeliverynote DlnoDeliverynote { get; set; } = null!;

    public virtual JOrder? DlnoOrder { get; set; }

    public virtual ICollection<JDeliverynoteentryorder> JDeliverynoteentryorders { get; set; } = new List<JDeliverynoteentryorder>();
}
