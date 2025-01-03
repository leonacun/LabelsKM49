using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCompany
{
    public decimal CoId { get; set; }

    public decimal? CoMastercompanyId { get; set; }

    public decimal? CoPropertysetId { get; set; }

    public DateTime CoTcreation { get; set; }

    public DateTime CoTupdate { get; set; }

    public string CoKey { get; set; } = null!;

    public string CoNo { get; set; } = null!;

    public string? CoDunsno { get; set; }

    public string? CoIconfile { get; set; }

    public bool CoIscarrier { get; set; }

    public bool CoIscustomer { get; set; }

    public bool CoIssupplier { get; set; }

    public decimal? CoLogoimageId { get; set; }

    public virtual JImage? CoLogoimage { get; set; }

    public virtual JCompany? CoMastercompany { get; set; }

    public virtual JPropertyset? CoPropertyset { get; set; }

    public virtual ICollection<JCompany> InverseCoMastercompany { get; set; } = new List<JCompany>();

    public virtual ICollection<JAddress> JAddresses { get; set; } = new List<JAddress>();

    public virtual ICollection<JAdviceset> JAdvicesets { get; set; } = new List<JAdviceset>();

    public virtual ICollection<JCalendar> JCalendars { get; set; } = new List<JCalendar>();

    public virtual ICollection<JChoice> JChoices { get; set; } = new List<JChoice>();

    public virtual ICollection<JCodetable> JCodetables { get; set; } = new List<JCodetable>();

    public virtual ICollection<JColorclass> JColorclasses { get; set; } = new List<JColorclass>();

    public virtual ICollection<JColor> JColors { get; set; } = new List<JColor>();

    public virtual ICollection<JCommcontrol> JCommcontrols { get; set; } = new List<JCommcontrol>();

    public virtual ICollection<JCompanyclass> JCompanyclasses { get; set; } = new List<JCompanyclass>();

    public virtual ICollection<JCompanyclassmember> JCompanyclassmembers { get; set; } = new List<JCompanyclassmember>();

    public virtual ICollection<JCompanycounter> JCompanycounters { get; set; } = new List<JCompanycounter>();

    public virtual ICollection<JContainerbufferclass> JContainerbufferclasses { get; set; } = new List<JContainerbufferclass>();

    public virtual ICollection<JContainerbuffer> JContainerbuffers { get; set; } = new List<JContainerbuffer>();

    public virtual ICollection<JContainermaptypeset> JContainermaptypesets { get; set; } = new List<JContainermaptypeset>();

    public virtual ICollection<JContainersetclass> JContainersetclasses { get; set; } = new List<JContainersetclass>();

    public virtual ICollection<JContainerset> JContainersets { get; set; } = new List<JContainerset>();

    public virtual ICollection<JContainertypeclass> JContainertypeclasses { get; set; } = new List<JContainertypeclass>();

    public virtual ICollection<JContainertypeset> JContainertypesets { get; set; } = new List<JContainertypeset>();

    public virtual ICollection<JContract> JContractCOthercompanies { get; set; } = new List<JContract>();

    public virtual ICollection<JContract> JContractCOwncompanies { get; set; } = new List<JContract>();

    public virtual ICollection<JContractclass> JContractclasses { get; set; } = new List<JContractclass>();

    public virtual ICollection<JCounterset> JCountersets { get; set; } = new List<JCounterset>();

    public virtual ICollection<JCreditnote> JCreditnotes { get; set; } = new List<JCreditnote>();

    public virtual ICollection<JCreditnoteset> JCreditnotesets { get; set; } = new List<JCreditnoteset>();

    public virtual ICollection<JDelivery> JDeliveryDlCarriers { get; set; } = new List<JDelivery>();

    public virtual ICollection<JDelivery> JDeliveryDlCompanies { get; set; } = new List<JDelivery>();

    public virtual ICollection<JDemandcategory> JDemandcategories { get; set; } = new List<JDemandcategory>();

    public virtual ICollection<JDoccfg> JDoccfgs { get; set; } = new List<JDoccfg>();

    public virtual ICollection<JDocdef> JDocdefs { get; set; } = new List<JDocdef>();

    public virtual ICollection<JEdicfg> JEdicfgs { get; set; } = new List<JEdicfg>();

    public virtual ICollection<JEdidef> JEdidefs { get; set; } = new List<JEdidef>();

    public virtual ICollection<JErptranshist> JErptranshists { get; set; } = new List<JErptranshist>();

    public virtual ICollection<JFailuredetailset> JFailuredetailsets { get; set; } = new List<JFailuredetailset>();

    public virtual ICollection<JFailurereasonclass> JFailurereasonclasses { get; set; } = new List<JFailurereasonclass>();

    public virtual ICollection<JFailurereasonset> JFailurereasonsets { get; set; } = new List<JFailurereasonset>();

    public virtual ICollection<JFreasongroup> JFreasongroups { get; set; } = new List<JFreasongroup>();

    public virtual ICollection<JGroupset> JGroupsets { get; set; } = new List<JGroupset>();

    public virtual ICollection<JLocationclass> JLocationclasses { get; set; } = new List<JLocationclass>();

    public virtual ICollection<JLocation> JLocations { get; set; } = new List<JLocation>();

    public virtual ICollection<JLock> JLocks { get; set; } = new List<JLock>();

    public virtual ICollection<JLoginpolicy> JLoginpolicies { get; set; } = new List<JLoginpolicy>();

    public virtual ICollection<JMaintdefclass> JMaintdefclasses { get; set; } = new List<JMaintdefclass>();

    public virtual ICollection<JMaintdefset> JMaintdefsets { get; set; } = new List<JMaintdefset>();

    public virtual ICollection<JMaintjobset> JMaintjobsets { get; set; } = new List<JMaintjobset>();

    public virtual ICollection<JMaintprovset> JMaintprovsets { get; set; } = new List<JMaintprovset>();

    public virtual ICollection<JMeasurementset> JMeasurementsets { get; set; } = new List<JMeasurementset>();

    public virtual ICollection<JMenu> JMenus { get; set; } = new List<JMenu>();

    public virtual ICollection<JOrderbufferclass> JOrderbufferclasses { get; set; } = new List<JOrderbufferclass>();

    public virtual ICollection<JOrderbuffer> JOrderbuffers { get; set; } = new List<JOrderbuffer>();

    public virtual ICollection<JPackcfgset> JPackcfgsets { get; set; } = new List<JPackcfgset>();

    public virtual ICollection<JPartbufferclass> JPartbufferclasses { get; set; } = new List<JPartbufferclass>();

    public virtual ICollection<JPartbuffer> JPartbuffers { get; set; } = new List<JPartbuffer>();

    public virtual ICollection<JPartset> JPartsets { get; set; } = new List<JPartset>();

    public virtual ICollection<JProdcounterset> JProdcountersets { get; set; } = new List<JProdcounterset>();

    public virtual ICollection<JProdeventset> JProdeventsets { get; set; } = new List<JProdeventset>();

    public virtual ICollection<JProdflowset> JProdflowsets { get; set; } = new List<JProdflowset>();

    public virtual ICollection<JProdjobbufferclass> JProdjobbufferclasses { get; set; } = new List<JProdjobbufferclass>();

    public virtual ICollection<JProdjobbuffer> JProdjobbuffers { get; set; } = new List<JProdjobbuffer>();

    public virtual ICollection<JProdjobset> JProdjobsets { get; set; } = new List<JProdjobset>();

    public virtual ICollection<JProdlotset> JProdlotsets { get; set; } = new List<JProdlotset>();

    public virtual ICollection<JProdnoteset> JProdnotesets { get; set; } = new List<JProdnoteset>();

    public virtual ICollection<JProdplanset> JProdplansets { get; set; } = new List<JProdplanset>();

    public virtual ICollection<JProdplantypeset> JProdplantypesets { get; set; } = new List<JProdplantypeset>();

    public virtual ICollection<JProdreplenishmentcfgset> JProdreplenishmentcfgsets { get; set; } = new List<JProdreplenishmentcfgset>();

    public virtual ICollection<JProdstatset> JProdstatsets { get; set; } = new List<JProdstatset>();

    public virtual ICollection<JProdstepclass> JProdstepclasses { get; set; } = new List<JProdstepclass>();

    public virtual ICollection<JProdstepset> JProdstepsets { get; set; } = new List<JProdstepset>();

    public virtual ICollection<JProdtoolclass> JProdtoolclasses { get; set; } = new List<JProdtoolclass>();

    public virtual ICollection<JProdtoolset> JProdtoolsets { get; set; } = new List<JProdtoolset>();

    public virtual ICollection<JProductfamily> JProductfamilies { get; set; } = new List<JProductfamily>();

    public virtual ICollection<JProdunitclass> JProdunitclasses { get; set; } = new List<JProdunitclass>();

    public virtual ICollection<JProduniteventset> JProduniteventsets { get; set; } = new List<JProduniteventset>();

    public virtual ICollection<JProdunitset> JProdunitsets { get; set; } = new List<JProdunitset>();

    public virtual ICollection<JProdversionclass> JProdversionclasses { get; set; } = new List<JProdversionclass>();

    public virtual ICollection<JQualificationclass> JQualificationclasses { get; set; } = new List<JQualificationclass>();

    public virtual ICollection<JQualificationset> JQualificationsets { get; set; } = new List<JQualificationset>();

    public virtual ICollection<JReportclass> JReportclasses { get; set; } = new List<JReportclass>();

    public virtual ICollection<JReportset> JReportsets { get; set; } = new List<JReportset>();

    public virtual ICollection<JReporttypeset> JReporttypesets { get; set; } = new List<JReporttypeset>();

    public virtual ICollection<JSession> JSessions { get; set; } = new List<JSession>();

    public virtual ICollection<JSkidbufferclass> JSkidbufferclasses { get; set; } = new List<JSkidbufferclass>();

    public virtual ICollection<JSkidbuffer> JSkidbuffers { get; set; } = new List<JSkidbuffer>();

    public virtual ICollection<JSkideventset> JSkideventsets { get; set; } = new List<JSkideventset>();

    public virtual ICollection<JSkidset> JSkidsets { get; set; } = new List<JSkidset>();

    public virtual ICollection<JSkidtypeset> JSkidtypesets { get; set; } = new List<JSkidtypeset>();

    public virtual ICollection<JStockclass> JStockclasses { get; set; } = new List<JStockclass>();

    public virtual ICollection<JStocklocclass> JStocklocclasses { get; set; } = new List<JStocklocclass>();

    public virtual ICollection<JStockloctype> JStockloctypes { get; set; } = new List<JStockloctype>();

    public virtual ICollection<JStockset> JStocksets { get; set; } = new List<JStockset>();

    public virtual ICollection<JStocktagset> JStocktagsets { get; set; } = new List<JStocktagset>();

    public virtual ICollection<JSubjectattr> JSubjectattrs { get; set; } = new List<JSubjectattr>();

    public virtual ICollection<JSubjectcomptype> JSubjectcomptypes { get; set; } = new List<JSubjectcomptype>();

    public virtual ICollection<JSubject> JSubjects { get; set; } = new List<JSubject>();

    public virtual ICollection<JSubjecttype> JSubjecttypes { get; set; } = new List<JSubjecttype>();

    public virtual ICollection<JSupply> JSupplies { get; set; } = new List<JSupply>();

    public virtual ICollection<JTokenset> JTokensets { get; set; } = new List<JTokenset>();

    public virtual ICollection<JToolgroup> JToolgroups { get; set; } = new List<JToolgroup>();

    public virtual ICollection<JTour> JTours { get; set; } = new List<JTour>();

    public virtual ICollection<JTourset> JToursets { get; set; } = new List<JTourset>();

    public virtual ICollection<JTourtemplate> JTourtemplates { get; set; } = new List<JTourtemplate>();

    public virtual ICollection<JTransferconnclass> JTransferconnclasses { get; set; } = new List<JTransferconnclass>();

    public virtual ICollection<JTransferconnection> JTransferconnectionTcCompanies { get; set; } = new List<JTransferconnection>();

    public virtual ICollection<JTransferconnection> JTransferconnectionTcOthercompanies { get; set; } = new List<JTransferconnection>();

    public virtual ICollection<JTransitionset> JTransitionsets { get; set; } = new List<JTransitionset>();

    public virtual ICollection<JTransitiontypeset> JTransitiontypesets { get; set; } = new List<JTransitiontypeset>();

    public virtual ICollection<JTrucktype> JTrucktypes { get; set; } = new List<JTrucktype>();

    public virtual ICollection<JUseridentpolicy> JUseridentpolicies { get; set; } = new List<JUseridentpolicy>();

    public virtual ICollection<JUserrole> JUserroles { get; set; } = new List<JUserrole>();

    public virtual ICollection<JUserset> JUsersets { get; set; } = new List<JUserset>();

    public virtual ICollection<JWorkflowjobset> JWorkflowjobsets { get; set; } = new List<JWorkflowjobset>();

    public virtual ICollection<JWorkflowset> JWorkflowsets { get; set; } = new List<JWorkflowset>();

    public virtual ICollection<JWorktimeset> JWorktimesets { get; set; } = new List<JWorktimeset>();
}
