using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCalendarentry
{
    public decimal CaeId { get; set; }

    public decimal CaeEntrytypeId { get; set; }

    public decimal? CaeAuthorId { get; set; }

    public decimal? CaeUserId { get; set; }

    public decimal? CaeCodetableentryId { get; set; }

    public DateTime CaeTcreation { get; set; }

    public DateTime CaeTupdate { get; set; }

    public DateTime CaeFrom { get; set; }

    public DateTime CaeTo { get; set; }

    public string? CaeComment { get; set; }

    public DateTime? CaeTimeissued { get; set; }

    public string? CaeInfo1 { get; set; }

    public string? CaeInfo2 { get; set; }

    public string? CaeInfo3 { get; set; }

    public virtual JUser? CaeAuthor { get; set; }

    public virtual JCodetableentry? CaeCodetableentry { get; set; }

    public virtual JCalendarentrytype CaeEntrytype { get; set; } = null!;

    public virtual JUser? CaeUser { get; set; }

    public virtual ICollection<JWorktime> JWorktimes { get; set; } = new List<JWorktime>();
}
