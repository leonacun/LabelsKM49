using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCommjob
{
    public decimal CmjId { get; set; }

    public decimal CmjCommcontrolId { get; set; }

    public DateTime CmjTcreation { get; set; }

    public short CmjPos { get; set; }

    public string CmjState { get; set; } = null!;

    public virtual JCommcontrol CmjCommcontrol { get; set; } = null!;
}
