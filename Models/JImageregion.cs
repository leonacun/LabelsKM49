using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JImageregion
{
    public decimal ImrId { get; set; }

    public decimal ImrImageregionmapId { get; set; }

    public DateTime ImrTcreation { get; set; }

    public string ImrCode { get; set; } = null!;

    public decimal? ImrImageId { get; set; }

    public string ImrType { get; set; } = null!;

    public string? ImrDescr { get; set; }

    public string? ImrBordercolor { get; set; }

    public virtual JImage? ImrImage { get; set; }

    public virtual JImageregionmap ImrImageregionmap { get; set; } = null!;

    public virtual ICollection<JContainerposimageregion> JContainerposimageregions { get; set; } = new List<JContainerposimageregion>();

    public virtual ICollection<JImagepoint> JImagepoints { get; set; } = new List<JImagepoint>();
}
