using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSearchdef
{
    public decimal SdId { get; set; }

    public decimal SdTooldefId { get; set; }

    public decimal? SdToolId { get; set; }

    public decimal? SdUserId { get; set; }

    public DateTime SdTcreation { get; set; }

    public DateTime SdTupdate { get; set; }

    public string SdKey { get; set; } = null!;

    public string SdDescr { get; set; } = null!;

    public bool SdEnabled { get; set; }

    public string SdObjecttype { get; set; } = null!;

    public int SdDatasize { get; set; }

    public byte[]? SdData { get; set; }

    public virtual JTool? SdTool { get; set; }

    public virtual JTooldef SdTooldef { get; set; } = null!;

    public virtual JUser? SdUser { get; set; }
}
