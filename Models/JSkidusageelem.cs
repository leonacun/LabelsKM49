using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkidusageelem
{
    public decimal SkueId { get; set; }

    public decimal SkueSkidusageId { get; set; }

    public DateTime SkueTcreation { get; set; }

    public DateTime SkueTupdate { get; set; }

    public byte SkueIndex { get; set; }

    public decimal SkueQuantity { get; set; }

    public virtual JSkidusage SkueSkidusage { get; set; } = null!;
}
