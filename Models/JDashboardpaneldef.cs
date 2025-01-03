using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDashboardpaneldef
{
    public decimal DbopdId { get; set; }

    public decimal DbopdDashboardpaneldefsetId { get; set; }

    public decimal DbopdDataproviderId { get; set; }

    public DateTime DbopdTcreation { get; set; }

    public DateTime DbopdTupdate { get; set; }

    public string DbopdKey { get; set; } = null!;

    public string DbopdDescr { get; set; } = null!;

    public string DbopdDashboardpaneltype { get; set; } = null!;

    public byte[]? DbopdXmldata { get; set; }

    public int DbopdXmldatasize { get; set; }

    public virtual JDashboardpaneldefset DbopdDashboardpaneldefset { get; set; } = null!;

    public virtual JDashboarddataprovider DbopdDataprovider { get; set; } = null!;

    public virtual ICollection<JDashboardpanel> JDashboardpanels { get; set; } = new List<JDashboardpanel>();
}
