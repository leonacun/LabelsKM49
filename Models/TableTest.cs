using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class TableTest
{
    public int Id { get; set; }

    public string? Sequence { get; set; }

    public string? Vin { get; set; }

    public DateTime? Creation { get; set; }

    public string? Color { get; set; }

    public string? Type { get; set; }
}
