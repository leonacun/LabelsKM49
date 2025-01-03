using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JUserinfo
{
    public decimal UiId { get; set; }

    public decimal UiUserId { get; set; }

    public DateTime UiTcreation { get; set; }

    public DateTime UiTupdate { get; set; }

    public string UiType { get; set; } = null!;

    public string? UiKey1 { get; set; }

    public string? UiKey2 { get; set; }

    public string? UiKey3 { get; set; }

    public DateTime? UiTimevalue { get; set; }

    public string? UiStringvalue { get; set; }

    public virtual JUser UiUser { get; set; } = null!;
}
