using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkidusage
{
    public decimal SkuId { get; set; }

    public decimal SkuSkidtypeId { get; set; }

    public DateTime SkuTcreation { get; set; }

    public DateTime SkuTupdate { get; set; }

    public string SkuShortname { get; set; } = null!;

    public string? SkuDescr { get; set; }

    public decimal? SkuRawinchannelId { get; set; }

    public decimal? SkuPaintedoutchannelId { get; set; }

    public decimal? SkuContainerusageId { get; set; }

    public virtual ICollection<JSkidusageelem> JSkidusageelems { get; set; } = new List<JSkidusageelem>();

    public virtual JContainerusage? SkuContainerusage { get; set; }

    public virtual JPaintchannel? SkuPaintedoutchannel { get; set; }

    public virtual JPaintchannel? SkuRawinchannel { get; set; }

    public virtual JSkidtype SkuSkidtype { get; set; } = null!;
}
