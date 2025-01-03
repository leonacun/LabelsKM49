using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDashboardpanel
{
    public decimal DbopId { get; set; }

    public decimal DbopDashboardId { get; set; }

    public decimal DbopDashboardpaneldefId { get; set; }

    public DateTime DbopTcreation { get; set; }

    public DateTime DbopTupdate { get; set; }

    public short DbopLeft { get; set; }

    public short DbopTop { get; set; }

    public short DbopWidth { get; set; }

    public short DbopHeight { get; set; }

    public virtual JDashboard DbopDashboard { get; set; } = null!;

    public virtual JDashboardpaneldef DbopDashboardpaneldef { get; set; } = null!;
}
