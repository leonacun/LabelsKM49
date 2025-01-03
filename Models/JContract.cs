using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContract
{
    public decimal CId { get; set; }

    public decimal COwncompanyId { get; set; }

    public decimal COthercompanyId { get; set; }

    public decimal? CNotenocounterId { get; set; }

    public decimal? CEntrynocounterId { get; set; }

    public decimal? CDoccfgId { get; set; }

    public decimal? CEdicfgId { get; set; }

    public DateTime CTcreation { get; set; }

    public DateTime CTupdate { get; set; }

    public string CKey { get; set; } = null!;

    public string CNo { get; set; } = null!;

    public string CDescr { get; set; } = null!;

    public string CKind { get; set; } = null!;

    public string CEntrymaptype { get; set; } = null!;

    public string? COwnnoinother { get; set; }

    public string? COthernoinother { get; set; }

    public bool CPartialorders { get; set; }

    public string CNotestrategy { get; set; } = null!;

    public string CEntrystrategy { get; set; } = null!;

    public bool CUsetransportstockcfg { get; set; }

    public decimal? CAutosubjectclassId { get; set; }

    public virtual JSubjectclass? CAutosubjectclass { get; set; }

    public virtual JDoccfg? CDoccfg { get; set; }

    public virtual JEdicfg? CEdicfg { get; set; }

    public virtual JCounter? CEntrynocounter { get; set; }

    public virtual JCounter? CNotenocounter { get; set; }

    public virtual JCompany COthercompany { get; set; } = null!;

    public virtual JCompany COwncompany { get; set; } = null!;

    public virtual ICollection<JBmwcreditnote> JBmwcreditnotes { get; set; } = new List<JBmwcreditnote>();

    public virtual ICollection<JBmwordererror> JBmwordererrors { get; set; } = new List<JBmwordererror>();

    public virtual ICollection<JContainermapcfg> JContainermapcfgs { get; set; } = new List<JContainermapcfg>();

    public virtual ICollection<JContainer> JContainers { get; set; } = new List<JContainer>();

    public virtual ICollection<JContainersetloc> JContainersetlocs { get; set; } = new List<JContainersetloc>();

    public virtual ICollection<JContractclassmember> JContractclassmembers { get; set; } = new List<JContractclassmember>();

    public virtual ICollection<JContractcounter> JContractcounters { get; set; } = new List<JContractcounter>();

    public virtual ICollection<JContractcumulative> JContractcumulatives { get; set; } = new List<JContractcumulative>();

    public virtual ICollection<JContractentry> JContractentries { get; set; } = new List<JContractentry>();

    public virtual ICollection<JContractinfo> JContractinfos { get; set; } = new List<JContractinfo>();

    public virtual ICollection<JContractnote> JContractnotes { get; set; } = new List<JContractnote>();

    public virtual ICollection<JDeliveryentry> JDeliveryentries { get; set; } = new List<JDeliveryentry>();

    public virtual ICollection<JOrdercontrol> JOrdercontrols { get; set; } = new List<JOrdercontrol>();

    public virtual ICollection<JOrdereventcfg> JOrdereventcfgs { get; set; } = new List<JOrdereventcfg>();

    public virtual ICollection<JOrdermgr> JOrdermgrs { get; set; } = new List<JOrdermgr>();

    public virtual ICollection<JOrderproclog> JOrderproclogs { get; set; } = new List<JOrderproclog>();

    public virtual ICollection<JOrder> JOrders { get; set; } = new List<JOrder>();

    public virtual ICollection<JProdplanentry> JProdplanentries { get; set; } = new List<JProdplanentry>();

    public virtual ICollection<JProdplan> JProdplans { get; set; } = new List<JProdplan>();

    public virtual JPurchasecontract? JPurchasecontract { get; set; }

    public virtual ICollection<JReportparam> JReportparams { get; set; } = new List<JReportparam>();

    public virtual JSalecontract? JSalecontract { get; set; }

    public virtual JSelfcontract? JSelfcontract { get; set; }

    public virtual ICollection<JStockcfg> JStockcfgs { get; set; } = new List<JStockcfg>();

    public virtual ICollection<JSupplyentry> JSupplyentries { get; set; } = new List<JSupplyentry>();

    public virtual ICollection<JTourcontainer> JTourcontainers { get; set; } = new List<JTourcontainer>();

    public virtual ICollection<JToureventcfgcontract> JToureventcfgcontracts { get; set; } = new List<JToureventcfgcontract>();

    public virtual JUsedasedlcontract? JUsedasedlcontractUaecContract { get; set; }

    public virtual ICollection<JUsedasedlcontract> JUsedasedlcontractUaecSalecontracts { get; set; } = new List<JUsedasedlcontract>();

    public virtual JUsingedlcontract? JUsingedlcontractUecContract { get; set; }

    public virtual ICollection<JUsingedlcontract> JUsingedlcontractUecSalecontracts { get; set; } = new List<JUsingedlcontract>();
}
