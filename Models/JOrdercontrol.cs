using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrdercontrol
{
    public decimal OcId { get; set; }

    public decimal OcContractId { get; set; }

    public decimal? OcSubjectclassId { get; set; }

    public decimal? OcReqsubjectclassId { get; set; }

    public decimal? OcOffsetcalendarId { get; set; }

    public decimal? OcReqoffsetcalendarId { get; set; }

    public decimal? OcTolocationclassId { get; set; }

    public decimal? OcReqtolocationclassId { get; set; }

    public DateTime OcTcreation { get; set; }

    public DateTime OcTupdate { get; set; }

    public string OcKey { get; set; } = null!;

    public string OcDescr { get; set; } = null!;

    public string OcCalloffmode { get; set; } = null!;

    public int OcOffsetinmin { get; set; }

    public int OcRefordercount { get; set; }

    public DateTime? OcReftime { get; set; }

    public int OcOrdercount { get; set; }

    public string OcReqcalloffmode { get; set; } = null!;

    public int OcReqoffsetinmin { get; set; }

    public int OcReqrefordercount { get; set; }

    public int OcReqordercount { get; set; }

    public DateTime? OcReqreftime { get; set; }

    public int OcCycle { get; set; }

    public string? OcCyclecomment { get; set; }

    public int OcDoneordercount { get; set; }

    public bool? OcSimulation { get; set; }

    public bool? OcStoreresult { get; set; }

    public bool? OcReqsimulation { get; set; }

    public bool? OcReqstoreresult { get; set; }

    public virtual ICollection<JOrdercontrolresult> JOrdercontrolresults { get; set; } = new List<JOrdercontrolresult>();

    public virtual JContract OcContract { get; set; } = null!;

    public virtual JCalendar? OcOffsetcalendar { get; set; }

    public virtual JCalendar? OcReqoffsetcalendar { get; set; }

    public virtual JSubjectclass? OcReqsubjectclass { get; set; }

    public virtual JLocationclass? OcReqtolocationclass { get; set; }

    public virtual JSubjectclass? OcSubjectclass { get; set; }

    public virtual JLocationclass? OcTolocationclass { get; set; }
}
