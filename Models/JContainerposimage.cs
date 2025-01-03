using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerposimage
{
    public decimal CtpiId { get; set; }

    public decimal CtpiContainerusageId { get; set; }

    public decimal CtpiImageId { get; set; }

    public DateTime CtpiTcreation { get; set; }

    public DateTime CtpiTupdate { get; set; }

    public byte CtpiIndex { get; set; }

    public virtual JContainerusage CtpiContainerusage { get; set; } = null!;

    public virtual JImage CtpiImage { get; set; } = null!;
}
