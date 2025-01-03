using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JWorktime
{
    public decimal WtId { get; set; }

    public decimal WtWorktimesetId { get; set; }

    public decimal? WtUserId { get; set; }

    public decimal? WtProdunitId { get; set; }

    public decimal? WtOrderId { get; set; }

    public DateTime WtTcreation { get; set; }

    public string WtType { get; set; } = null!;

    public DateTime WtTimestarted { get; set; }

    public DateTime? WtTimeended { get; set; }

    public decimal? WtCalendarentryId { get; set; }

    public decimal? WtProdjobId { get; set; }

    public decimal? WtMaintjobId { get; set; }

    public virtual ICollection<JWorktimeinfo> JWorktimeinfos { get; set; } = new List<JWorktimeinfo>();

    public virtual JCalendarentry? WtCalendarentry { get; set; }

    public virtual JMaintjob? WtMaintjob { get; set; }

    public virtual JOrder? WtOrder { get; set; }

    public virtual JProdjob? WtProdjob { get; set; }

    public virtual JProdunit? WtProdunit { get; set; }

    public virtual JUser? WtUser { get; set; }

    public virtual JWorktimeset WtWorktimeset { get; set; } = null!;
}
