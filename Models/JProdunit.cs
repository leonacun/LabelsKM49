using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdunit
{
    public decimal PuId { get; set; }

    public decimal PuProdunitsetId { get; set; }

    public decimal? PuCalendarId { get; set; }

    public decimal? PuDowntimereasonsetId { get; set; }

    public decimal? PuInterruptreasonsetId { get; set; }

    public DateTime PuTcreation { get; set; }

    public DateTime PuTupdate { get; set; }

    public string PuKey { get; set; } = null!;

    public string? PuCode { get; set; }

    public string PuKind { get; set; } = null!;

    public string PuDescr { get; set; } = null!;

    public decimal? PuDoccfgId { get; set; }

    public string? PuShortdescr { get; set; }

    public bool? PuEnabled { get; set; }

    public decimal? PuConditionreasonsetId { get; set; }

    public virtual ICollection<JAdviceconfirmation> JAdviceconfirmations { get; set; } = new List<JAdviceconfirmation>();

    public virtual ICollection<JContainerevent> JContainerevents { get; set; } = new List<JContainerevent>();

    public virtual ICollection<JContainer> JContainers { get; set; } = new List<JContainer>();

    public virtual ICollection<JMaintdefprodunit> JMaintdefprodunits { get; set; } = new List<JMaintdefprodunit>();

    public virtual ICollection<JMaintjob> JMaintjobs { get; set; } = new List<JMaintjob>();

    public virtual ICollection<JMeasurement> JMeasurements { get; set; } = new List<JMeasurement>();

    public virtual ICollection<JMontrafficlightentry> JMontrafficlightentries { get; set; } = new List<JMontrafficlightentry>();

    public virtual ICollection<JPaintunit> JPaintunits { get; set; } = new List<JPaintunit>();

    public virtual ICollection<JPartevent> JPartevents { get; set; } = new List<JPartevent>();

    public virtual ICollection<JPart> JParts { get; set; } = new List<JPart>();

    public virtual ICollection<JProdcounter> JProdcounters { get; set; } = new List<JProdcounter>();

    public virtual ICollection<JProdevent> JProdevents { get; set; } = new List<JProdevent>();

    public virtual ICollection<JProdflowaction> JProdflowactions { get; set; } = new List<JProdflowaction>();

    public virtual ICollection<JProdflowusage> JProdflowusages { get; set; } = new List<JProdflowusage>();

    public virtual ICollection<JProdjob> JProdjobs { get; set; } = new List<JProdjob>();

    public virtual ICollection<JProdnote> JProdnotes { get; set; } = new List<JProdnote>();

    public virtual ICollection<JProdplan> JProdplans { get; set; } = new List<JProdplan>();

    public virtual ICollection<JProdreplenishmentcfg> JProdreplenishmentcfgs { get; set; } = new List<JProdreplenishmentcfg>();

    public virtual ICollection<JProdstat> JProdstats { get; set; } = new List<JProdstat>();

    public virtual ICollection<JProdunitadvice> JProdunitadvices { get; set; } = new List<JProdunitadvice>();

    public virtual ICollection<JProdunitcalendar> JProdunitcalendars { get; set; } = new List<JProdunitcalendar>();

    public virtual ICollection<JProdunitclassmember> JProdunitclassmembers { get; set; } = new List<JProdunitclassmember>();

    public virtual ICollection<JProdunitdatum> JProdunitdata { get; set; } = new List<JProdunitdatum>();

    public virtual ICollection<JProdunitevent> JProdunitevents { get; set; } = new List<JProdunitevent>();

    public virtual ICollection<JProdunitfreasongroup> JProdunitfreasongroups { get; set; } = new List<JProdunitfreasongroup>();

    public virtual ICollection<JProdunitinfo> JProdunitinfos { get; set; } = new List<JProdunitinfo>();

    public virtual ICollection<JProdunitinterval> JProdunitintervals { get; set; } = new List<JProdunitinterval>();

    public virtual ICollection<JProdunitparam> JProdunitparams { get; set; } = new List<JProdunitparam>();

    public virtual ICollection<JProdunittool> JProdunittools { get; set; } = new List<JProdunittool>();

    public virtual ICollection<JPvssareaprodunit> JPvssareaprodunits { get; set; } = new List<JPvssareaprodunit>();

    public virtual ICollection<JPvssboxdatum> JPvssboxdata { get; set; } = new List<JPvssboxdatum>();

    public virtual ICollection<JReportparam> JReportparams { get; set; } = new List<JReportparam>();

    public virtual ICollection<JStation> JStations { get; set; } = new List<JStation>();

    public virtual ICollection<JStockcfg> JStockcfgs { get; set; } = new List<JStockcfg>();

    public virtual ICollection<JSupplyentry> JSupplyentries { get; set; } = new List<JSupplyentry>();

    public virtual ICollection<JSupplynote> JSupplynotes { get; set; } = new List<JSupplynote>();

    public virtual ICollection<JTicket> JTickets { get; set; } = new List<JTicket>();

    public virtual ICollection<JWorktime> JWorktimes { get; set; } = new List<JWorktime>();

    public virtual JCalendar? PuCalendar { get; set; }

    public virtual JFailurereasonset? PuConditionreasonset { get; set; }

    public virtual JDoccfg? PuDoccfg { get; set; }

    public virtual JFailurereasonset? PuDowntimereasonset { get; set; }

    public virtual JFailurereasonset? PuInterruptreasonset { get; set; }

    public virtual JProdunitset PuProdunitset { get; set; } = null!;
}
