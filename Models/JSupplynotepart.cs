using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSupplynotepart
{
    public decimal SunpId { get; set; }

    public decimal SunpSupplynoteId { get; set; }

    public decimal? SunpContainerentryId { get; set; }

    public DateTime SunpTcreation { get; set; }

    public string SunpNo { get; set; } = null!;

    public DateTime? SunpTimeunloaded { get; set; }

    public string SunpStatus { get; set; } = null!;

    public virtual JContainerentry? SunpContainerentry { get; set; }

    public virtual JSupplynote SunpSupplynote { get; set; } = null!;
}
