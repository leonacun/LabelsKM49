using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JVersioninfo
{
    public decimal VId { get; set; }

    public DateTime VTcreation { get; set; }

    public DateTime VTupdate { get; set; }

    public byte VMajorversion { get; set; }

    public byte VMinorversion { get; set; }

    public string? VLastupdateinfo { get; set; }

    public string? VCopyright { get; set; }

    public string VSchemaname { get; set; } = null!;
}
