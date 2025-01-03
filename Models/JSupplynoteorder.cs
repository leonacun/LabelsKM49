using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSupplynoteorder
{
    public decimal SunoId { get; set; }

    public decimal SunoSupplynoteId { get; set; }

    public DateTime SunoTcreation { get; set; }

    public string SunoOrderno { get; set; } = null!;

    public virtual ICollection<JSupplynoteentryorder> JSupplynoteentryorders { get; set; } = new List<JSupplynoteentryorder>();

    public virtual JSupplynote SunoSupplynote { get; set; } = null!;
}
