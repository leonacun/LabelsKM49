using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JWorktimeinfo
{
    public decimal WtiId { get; set; }

    public decimal WtiWorktimeId { get; set; }

    public DateTime WtiTcreation { get; set; }

    public DateTime WtiTupdate { get; set; }

    public string WtiType { get; set; } = null!;

    public string? WtiKey1 { get; set; }

    public string? WtiKey2 { get; set; }

    public string? WtiKey3 { get; set; }

    public DateTime? WtiTimevalue { get; set; }

    public string? WtiStringvalue { get; set; }

    public int? WtiIntvalue { get; set; }

    public virtual JWorktime WtiWorktime { get; set; } = null!;
}
