using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCalendar
{
    public decimal CaId { get; set; }

    public decimal CaCompanyId { get; set; }

    public DateTime CaTcreation { get; set; }

    public DateTime CaTupdate { get; set; }

    public string CaKey { get; set; } = null!;

    public string? CaDescr { get; set; }

    public virtual JCompany CaCompany { get; set; } = null!;

    public virtual ICollection<JCalendarentrytype> JCalendarentrytypes { get; set; } = new List<JCalendarentrytype>();

    public virtual ICollection<JLoaderparam> JLoaderparams { get; set; } = new List<JLoaderparam>();

    public virtual ICollection<JOrdercontrol> JOrdercontrolOcOffsetcalendars { get; set; } = new List<JOrdercontrol>();

    public virtual ICollection<JOrdercontrol> JOrdercontrolOcReqoffsetcalendars { get; set; } = new List<JOrdercontrol>();

    public virtual ICollection<JProdunitcalendar> JProdunitcalendars { get; set; } = new List<JProdunitcalendar>();

    public virtual ICollection<JProdunit> JProdunits { get; set; } = new List<JProdunit>();

    public virtual ICollection<JReportparam> JReportparams { get; set; } = new List<JReportparam>();

    public virtual ICollection<JTransfercontrol> JTransfercontrols { get; set; } = new List<JTransfercontrol>();
}
