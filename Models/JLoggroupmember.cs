using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLoggroupmember
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public decimal? GmGroupId { get; set; }

    public decimal? GmUserId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
