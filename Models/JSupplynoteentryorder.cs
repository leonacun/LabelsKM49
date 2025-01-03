using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSupplynoteentryorder
{
    public decimal SuneoId { get; set; }

    public decimal SuneoSupplynoteentryId { get; set; }

    public decimal SuneoSupplynoteorderId { get; set; }

    public DateTime SuneoTcreation { get; set; }

    public decimal SuneoAmount { get; set; }

    public decimal SuneoConfirmedamount { get; set; }

    public DateTime SuneoTupdate { get; set; }

    public virtual JSupplynoteentry SuneoSupplynoteentry { get; set; } = null!;

    public virtual JSupplynoteorder SuneoSupplynoteorder { get; set; } = null!;
}
