using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPaintchannel
{
    public decimal PachId { get; set; }

    public decimal PachPaintunitId { get; set; }

    public DateTime PachTcreation { get; set; }

    public DateTime PachTupdate { get; set; }

    public string PachType { get; set; } = null!;

    public string PachDescr { get; set; } = null!;

    public string PachCode { get; set; } = null!;

    public virtual ICollection<JPaintplanentryelem> JPaintplanentryelemPpeePaintedoutchannels { get; set; } = new List<JPaintplanentryelem>();

    public virtual ICollection<JPaintplanentryelem> JPaintplanentryelemPpeeRawinchannels { get; set; } = new List<JPaintplanentryelem>();

    public virtual ICollection<JSkidusage> JSkidusageSkuPaintedoutchannels { get; set; } = new List<JSkidusage>();

    public virtual ICollection<JSkidusage> JSkidusageSkuRawinchannels { get; set; } = new List<JSkidusage>();

    public virtual JPaintunit PachPaintunit { get; set; } = null!;
}
