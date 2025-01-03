using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JBmwordererror
{
    public decimal BoeId { get; set; }

    public decimal BoeContractId { get; set; }

    public DateTime BoeTcreation { get; set; }

    public DateTime BoeTupdate { get; set; }

    public string BoeOrderno { get; set; } = null!;

    public string BoeType { get; set; } = null!;

    public string BoeFiletype { get; set; } = null!;

    public string? BoePartfamily { get; set; }

    public string? BoeSupplygroup { get; set; }

    public DateTime? BoeFiledate { get; set; }

    public DateTime? BoeToddate { get; set; }

    public DateTime? BoeSidate { get; set; }

    public string? BoeComment { get; set; }

    public virtual JContract BoeContract { get; set; } = null!;
}
