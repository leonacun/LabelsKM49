using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPsprodeventdatum
{
    public decimal PspredId { get; set; }

    public decimal PspredPsprodeventId { get; set; }

    public DateTime PspredTcreation { get; set; }

    public string PspredKey { get; set; } = null!;

    public string? PspredValue { get; set; }

    public virtual JPsprodevent PspredPsprodevent { get; set; } = null!;
}
