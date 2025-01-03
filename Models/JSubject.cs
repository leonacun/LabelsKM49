using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSubject
{
    public decimal SId { get; set; }

    public decimal SCompanyId { get; set; }

    public decimal SSubjecttypeId { get; set; }

    public decimal SSubjectstatusId { get; set; }

    public decimal SUnitofmeasureId { get; set; }

    public DateTime STcreation { get; set; }

    public DateTime STupdate { get; set; }

    public decimal? SDeletionid { get; set; }

    public DateTime? STdeletion { get; set; }

    public string SNo { get; set; } = null!;

    public string SDescr { get; set; } = null!;

    public string? SEngineeringindex { get; set; }

    public virtual ICollection<JBmwcreditnotepo> JBmwcreditnotepos { get; set; } = new List<JBmwcreditnotepo>();

    public virtual ICollection<JContainerevententry> JContainerevententries { get; set; } = new List<JContainerevententry>();

    public virtual ICollection<JContainerinvsubject> JContainerinvsubjects { get; set; } = new List<JContainerinvsubject>();

    public virtual ICollection<JContainermapcfg> JContainermapcfgs { get; set; } = new List<JContainermapcfg>();

    public virtual ICollection<JContainersubject> JContainersubjects { get; set; } = new List<JContainersubject>();

    public virtual ICollection<JContainertype> JContainertypes { get; set; } = new List<JContainertype>();

    public virtual ICollection<JContainerusageelem> JContainerusageelems { get; set; } = new List<JContainerusageelem>();

    public virtual ICollection<JContractcumulative> JContractcumulativeCcOthersubjects { get; set; } = new List<JContractcumulative>();

    public virtual ICollection<JContractcumulative> JContractcumulativeCcOwnsubjects { get; set; } = new List<JContractcumulative>();

    public virtual ICollection<JContractentry> JContractentryCeOthersubjects { get; set; } = new List<JContractentry>();

    public virtual ICollection<JContractentry> JContractentryCeOwnsubjects { get; set; } = new List<JContractentry>();

    public virtual ICollection<JCreditnoteentry> JCreditnoteentries { get; set; } = new List<JCreditnoteentry>();

    public virtual ICollection<JDeliverynoteentry> JDeliverynoteentryDlneOthersubjects { get; set; } = new List<JDeliverynoteentry>();

    public virtual ICollection<JDeliverynoteentry> JDeliverynoteentryDlneSubjects { get; set; } = new List<JDeliverynoteentry>();

    public virtual ICollection<JDemand> JDemandDOthersubjects { get; set; } = new List<JDemand>();

    public virtual ICollection<JDemand> JDemandDSubjects { get; set; } = new List<JDemand>();

    public virtual ICollection<JLoadplanentry> JLoadplanentries { get; set; } = new List<JLoadplanentry>();

    public virtual ICollection<JMaintdefmaterial> JMaintdefmaterials { get; set; } = new List<JMaintdefmaterial>();

    public virtual ICollection<JMaintjobmaterial> JMaintjobmaterials { get; set; } = new List<JMaintjobmaterial>();

    public virtual ICollection<JMeasurement> JMeasurements { get; set; } = new List<JMeasurement>();

    public virtual ICollection<JMsignotification> JMsignotifications { get; set; } = new List<JMsignotification>();

    public virtual ICollection<JOrderentry> JOrderentryOeOthersubjects { get; set; } = new List<JOrderentry>();

    public virtual ICollection<JOrderentry> JOrderentryOeSubjects { get; set; } = new List<JOrderentry>();

    public virtual ICollection<JOrderevententry> JOrderevententryOeveOthersubjects { get; set; } = new List<JOrderevententry>();

    public virtual ICollection<JOrderevententry> JOrderevententryOeveSubjects { get; set; } = new List<JOrderevententry>();

    public virtual ICollection<JPackcfg> JPackcfgPcfPackingmaterials { get; set; } = new List<JPackcfg>();

    public virtual ICollection<JPackcfg> JPackcfgPcfSubjects { get; set; } = new List<JPackcfg>();

    public virtual ICollection<JPackingmaterial> JPackingmaterials { get; set; } = new List<JPackingmaterial>();

    public virtual ICollection<JPaintplanentryelem> JPaintplanentryelemPpeePaintedsubjects { get; set; } = new List<JPaintplanentryelem>();

    public virtual ICollection<JPaintplanentryelem> JPaintplanentryelemPpeeRawsubjects { get; set; } = new List<JPaintplanentryelem>();

    public virtual ICollection<JPartevent> JPartevents { get; set; } = new List<JPartevent>();

    public virtual ICollection<JPart> JParts { get; set; } = new List<JPart>();

    public virtual ICollection<JPolyconpaintevent> JPolyconpaintevents { get; set; } = new List<JPolyconpaintevent>();

    public virtual ICollection<JPptemplateentrydefelem> JPptemplateentrydefelems { get; set; } = new List<JPptemplateentrydefelem>();

    public virtual ICollection<JProdcounter> JProdcounters { get; set; } = new List<JProdcounter>();

    public virtual ICollection<JProdevent> JProdevents { get; set; } = new List<JProdevent>();

    public virtual ICollection<JProdflowusage> JProdflowusages { get; set; } = new List<JProdflowusage>();

    public virtual ICollection<JProdjobentry> JProdjobentries { get; set; } = new List<JProdjobentry>();

    public virtual ICollection<JProdplanentry> JProdplanentries { get; set; } = new List<JProdplanentry>();

    public virtual ICollection<JProdplanentryelem> JProdplanentryelems { get; set; } = new List<JProdplanentryelem>();

    public virtual ICollection<JProdplanentrytypeelem> JProdplanentrytypeelems { get; set; } = new List<JProdplanentrytypeelem>();

    public virtual ICollection<JProdreplenishmentcfg> JProdreplenishmentcfgs { get; set; } = new List<JProdreplenishmentcfg>();

    public virtual ICollection<JProdtoolusageelem> JProdtoolusageelems { get; set; } = new List<JProdtoolusageelem>();

    public virtual ICollection<JPvsssubject> JPvsssubjects { get; set; } = new List<JPvsssubject>();

    public virtual JSavalApp? JSavalApp { get; set; }

    public virtual JSavalBlockheater? JSavalBlockheater { get; set; }

    public virtual JSavalBrand? JSavalBrand { get; set; }

    public virtual JSavalBsd? JSavalBsd { get; set; }

    public virtual JSavalBuxhitch? JSavalBuxhitch { get; set; }

    public virtual JSavalCamera? JSavalCamera { get; set; }

    public virtual JSavalChryslerappliquecolor? JSavalChryslerappliquecolor { get; set; }

    public virtual JSavalChryslerbezeltrimcolor? JSavalChryslerbezeltrimcolor { get; set; }

    public virtual JSavalChryslereafoam? JSavalChryslereafoam { get; set; }

    public virtual JSavalChryslerengdevidate? JSavalChryslerengdevidate { get; set; }

    public virtual JSavalChryslerengdevidoc? JSavalChryslerengdevidoc { get; set; }

    public virtual JSavalChryslerengdevitype? JSavalChryslerengdevitype { get; set; }

    public virtual JSavalChryslerringcolor? JSavalChryslerringcolor { get; set; }

    public virtual JSavalColor? JSavalColor { get; set; }

    public virtual JSavalCuringtime? JSavalCuringtime { get; set; }

    public virtual JSavalCustPn? JSavalCustPn { get; set; }

    public virtual JSavalDasm? JSavalDasm { get; set; }

    public virtual JSavalDeposit? JSavalDeposit { get; set; }

    public virtual JSavalDiesel? JSavalDiesel { get; set; }

    public virtual JSavalDoor? JSavalDoor { get; set; }

    public virtual JSavalDrive? JSavalDrive { get; set; }

    public virtual JSavalDualexhaust? JSavalDualexhaust { get; set; }

    public virtual JSavalFoglamp? JSavalFoglamp { get; set; }

    public virtual JSavalGmcountry? JSavalGmcountry { get; set; }

    public virtual JSavalGmversion? JSavalGmversion { get; set; }

    public virtual JSavalHeadlampwasher? JSavalHeadlampwasher { get; set; }

    public virtual JSavalHorizposition? JSavalHorizposition { get; set; }

    public virtual JSavalImage? JSavalImage { get; set; }

    public virtual JSavalKicksensor? JSavalKicksensor { get; set; }

    public virtual JSavalKicksensort? JSavalKicksensort { get; set; }

    public virtual JSavalLighting? JSavalLighting { get; set; }

    public virtual JSavalMca? JSavalMca { get; set; }

    public virtual JSavalModelyear? JSavalModelyear { get; set; }

    public virtual JSavalOpengrill? JSavalOpengrill { get; set; }

    public virtual JSavalOption? JSavalOption { get; set; }

    public virtual JSavalParkingassistant? JSavalParkingassistant { get; set; }

    public virtual JSavalPartstyle? JSavalPartstyle { get; set; }

    public virtual JSavalPdc? JSavalPdc { get; set; }

    public virtual JSavalPed? JSavalPed { get; set; }

    public virtual JSavalPhantom? JSavalPhantom { get; set; }

    public virtual JSavalPicklocation? JSavalPicklocation { get; set; }

    public virtual JSavalPlate? JSavalPlate { get; set; }

    public virtual JSavalReflector? JSavalReflector { get; set; }

    public virtual JSavalReplacedbynew? JSavalReplacedbynew { get; set; }

    public virtual JSavalSbza? JSavalSbza { get; set; }

    public virtual JSavalSecondpartnum? JSavalSecondpartnum { get; set; }

    public virtual JSavalServiceorder? JSavalServiceorder { get; set; }

    public virtual JSavalSide? JSavalSide { get; set; }

    public virtual JSavalStandardprice? JSavalStandardprice { get; set; }

    public virtual JSavalStdpackqty? JSavalStdpackqty { get; set; }

    public virtual JSavalTirepressuremonitor? JSavalTirepressuremonitor { get; set; }

    public virtual JSavalTowhook? JSavalTowhook { get; set; }

    public virtual JSavalTrackmaterial? JSavalTrackmaterial { get; set; }

    public virtual JSavalTrailerhitch? JSavalTrailerhitch { get; set; }

    public virtual JSavalUnitprice? JSavalUnitprice { get; set; }

    public virtual JSavalUnitprice1? JSavalUnitprice1 { get; set; }

    public virtual JSavalUppergrillestyle? JSavalUppergrillestyle { get; set; }

    public virtual JSavalUseasordered? JSavalUseasordered { get; set; }

    public virtual JSavalValidation? JSavalValidation { get; set; }

    public virtual JSavalVertposition? JSavalVertposition { get; set; }

    public virtual JSavalWeight? JSavalWeight { get; set; }

    public virtual ICollection<JStockcfg> JStockcfgs { get; set; } = new List<JStockcfg>();

    public virtual ICollection<JStockcomponent> JStockcomponents { get; set; } = new List<JStockcomponent>();

    public virtual ICollection<JStockentrystat> JStockentrystats { get; set; } = new List<JStockentrystat>();

    public virtual ICollection<JStockinvdiffitem> JStockinvdiffitemStidiNewsubjects { get; set; } = new List<JStockinvdiffitem>();

    public virtual ICollection<JStockinvdiffitem> JStockinvdiffitemStidiOldsubjects { get; set; } = new List<JStockinvdiffitem>();

    public virtual ICollection<JStockinvitem> JStockinvitems { get; set; } = new List<JStockinvitem>();

    public virtual ICollection<JStockinvstocklocsubject> JStockinvstocklocsubjects { get; set; } = new List<JStockinvstocklocsubject>();

    public virtual ICollection<JStocklocpart> JStocklocparts { get; set; } = new List<JStocklocpart>();

    public virtual ICollection<JStockloc> JStocklocs { get; set; } = new List<JStockloc>();

    public virtual ICollection<JStocklocsubject> JStocklocsubjects { get; set; } = new List<JStocklocsubject>();

    public virtual ICollection<JStocksubstevent> JStocksubstevents { get; set; } = new List<JStocksubstevent>();

    public virtual ICollection<JStocktag> JStocktags { get; set; } = new List<JStocktag>();

    public virtual ICollection<JSubjectcompelem> JSubjectcompelems { get; set; } = new List<JSubjectcompelem>();

    public virtual ICollection<JSubjectcomp> JSubjectcomps { get; set; } = new List<JSubjectcomp>();

    public virtual ICollection<JSubjectinfo> JSubjectinfoSiRefsubjects { get; set; } = new List<JSubjectinfo>();

    public virtual ICollection<JSubjectinfo> JSubjectinfoSiSubjects { get; set; } = new List<JSubjectinfo>();

    public virtual ICollection<JSupplynoteentry> JSupplynoteentrySuneOthersubjects { get; set; } = new List<JSupplynoteentry>();

    public virtual ICollection<JSupplynoteentry> JSupplynoteentrySuneSubjects { get; set; } = new List<JSupplynoteentry>();

    public virtual ICollection<JWorkflowjobentry> JWorkflowjobentries { get; set; } = new List<JWorkflowjobentry>();

    public virtual JCompany SCompany { get; set; } = null!;

    public virtual JSubjectstatus SSubjectstatus { get; set; } = null!;

    public virtual JSubjecttype SSubjecttype { get; set; } = null!;

    public virtual JUnitofmeasure SUnitofmeasure { get; set; } = null!;
}
