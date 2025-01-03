using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMergerobjectinstr
{
    public decimal MoiId { get; set; }

    public DateTime MoiTcreation { get; set; }

    public decimal MoiObjectid { get; set; }

    public string MoiObjectclassname { get; set; } = null!;

    public string MoiType { get; set; } = null!;
}
