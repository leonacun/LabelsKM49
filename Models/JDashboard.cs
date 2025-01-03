using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDashboard
{
    public decimal DboId { get; set; }

    public decimal DboDashboardsetId { get; set; }

    public DateTime DboTcreation { get; set; }

    public DateTime DboTupdate { get; set; }

    public string DboKey { get; set; } = null!;

    public string DboDescr { get; set; } = null!;

    public string DboTitle { get; set; } = null!;

    public short DboWidth { get; set; }

    public short DboHeight { get; set; }

    public byte[]? DboXmldata { get; set; }

    public int DboXmldatasize { get; set; }

    public virtual JDashboardset DboDashboardset { get; set; } = null!;

    public virtual ICollection<JDashboardinfo> JDashboardinfos { get; set; } = new List<JDashboardinfo>();

    public virtual ICollection<JDashboardpanel> JDashboardpanels { get; set; } = new List<JDashboardpanel>();
}
