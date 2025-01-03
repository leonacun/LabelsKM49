using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCalendarentrytype
{
    public decimal CaetId { get; set; }

    public decimal CaetCalendarId { get; set; }

    public DateTime CaetTcreation { get; set; }

    public DateTime CaetTupdate { get; set; }

    public byte CaetPosno { get; set; }

    public string? CaetDescr { get; set; }

    public string CaetDatetype { get; set; } = null!;

    public string? CaetIconfile { get; set; }

    public string? CaetDisplaycolor { get; set; }

    public string? CaetKey { get; set; }

    public decimal CaetDefaultdurationinsec { get; set; }

    public virtual JCalendar CaetCalendar { get; set; } = null!;

    public virtual ICollection<JCalendarentry> JCalendarentries { get; set; } = new List<JCalendarentry>();
}
