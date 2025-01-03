using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JReportclassmember
{
    public decimal RclmId { get; set; }

    public decimal RclmReportclassId { get; set; }

    public decimal RclmReportId { get; set; }

    public DateTime RclmTcreation { get; set; }

    public DateTime RclmTupdate { get; set; }

    public virtual JReport RclmReport { get; set; } = null!;

    public virtual JReportclass RclmReportclass { get; set; } = null!;
}
