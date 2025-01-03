using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainersetclass
{
    public decimal CtscId { get; set; }

    public decimal CtscCompanyId { get; set; }

    public DateTime CtscTcreation { get; set; }

    public DateTime CtscTupdate { get; set; }

    public string CtscKey { get; set; } = null!;

    public string CtscDescr { get; set; } = null!;

    public virtual JCompany CtscCompany { get; set; } = null!;

    public virtual ICollection<JContainersetclassmember> JContainersetclassmembers { get; set; } = new List<JContainersetclassmember>();

    public virtual ICollection<JLoaderparam> JLoaderparams { get; set; } = new List<JLoaderparam>();

    public virtual ICollection<JSkidset> JSkidsets { get; set; } = new List<JSkidset>();

    public virtual ICollection<JStockchannel> JStockchannels { get; set; } = new List<JStockchannel>();

    public virtual ICollection<JStockinv> JStockinvs { get; set; } = new List<JStockinv>();
}
