using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStock
{
    public decimal StId { get; set; }

    public decimal StStocksetId { get; set; }

    public decimal? StDoccfgId { get; set; }

    public decimal? StReconciliationstockId { get; set; }

    public DateTime StTcreation { get; set; }

    public DateTime StTupdate { get; set; }

    public string StKey { get; set; } = null!;

    public string? StDescr { get; set; }

    public string? StCode { get; set; }

    public bool StAutodef { get; set; }

    public short StMaxageindays { get; set; }

    public bool StLocked { get; set; }

    public bool StHasparts { get; set; }

    public bool StHaslocs { get; set; }

    public bool StPrivate { get; set; }

    public decimal StDefminamount { get; set; }

    public decimal StDefmaxamount { get; set; }

    public string StDefupdatestrategy { get; set; } = null!;

    public bool StOpdamage { get; set; }

    public bool StOploss { get; set; }

    public bool StOpinventory { get; set; }

    public bool StOpwarnpercentage { get; set; }

    public decimal StWarnpercentage { get; set; }

    public string? StLocnameformat { get; set; }

    public string StContainernopolicy { get; set; } = null!;

    public virtual ICollection<JStock> InverseStReconciliationstock { get; set; } = new List<JStock>();

    public virtual ICollection<JContainerevent> JContainerevents { get; set; } = new List<JContainerevent>();

    public virtual ICollection<JContainermapcfg> JContainermapcfgs { get; set; } = new List<JContainermapcfg>();

    public virtual ICollection<JContainer> JContainers { get; set; } = new List<JContainer>();

    public virtual ICollection<JContainerset> JContainersets { get; set; } = new List<JContainerset>();

    public virtual ICollection<JMsignotification> JMsignotificationMsignCompstocks { get; set; } = new List<JMsignotification>();

    public virtual ICollection<JMsignotification> JMsignotificationMsignTransitstocks { get; set; } = new List<JMsignotification>();

    public virtual ICollection<JPartevent> JPartevents { get; set; } = new List<JPartevent>();

    public virtual ICollection<JPart> JParts { get; set; } = new List<JPart>();

    public virtual ICollection<JProdjob> JProdjobs { get; set; } = new List<JProdjob>();

    public virtual ICollection<JProdreplenishmentcfg> JProdreplenishmentcfgPrcfDeststocks { get; set; } = new List<JProdreplenishmentcfg>();

    public virtual ICollection<JProdreplenishmentcfg> JProdreplenishmentcfgPrcfSourcestocks { get; set; } = new List<JProdreplenishmentcfg>();

    public virtual ICollection<JPurchasecontract> JPurchasecontracts { get; set; } = new List<JPurchasecontract>();

    public virtual ICollection<JPvssarea> JPvssareas { get; set; } = new List<JPvssarea>();

    public virtual ICollection<JReportparam> JReportparams { get; set; } = new List<JReportparam>();

    public virtual ICollection<JSalecontract> JSalecontracts { get; set; } = new List<JSalecontract>();

    public virtual ICollection<JSelfcontract> JSelfcontractSecTransportstocks { get; set; } = new List<JSelfcontract>();

    public virtual ICollection<JSelfcontract> JSelfcontractSecTransportstocksupplies { get; set; } = new List<JSelfcontract>();

    public virtual ICollection<JStockcfg> JStockcfgs { get; set; } = new List<JStockcfg>();

    public virtual ICollection<JStockchannel> JStockchannelStchOtherstocks { get; set; } = new List<JStockchannel>();

    public virtual ICollection<JStockchannel> JStockchannelStchStocks { get; set; } = new List<JStockchannel>();

    public virtual ICollection<JStockclassmember> JStockclassmembers { get; set; } = new List<JStockclassmember>();

    public virtual ICollection<JStockcomponent> JStockcomponents { get; set; } = new List<JStockcomponent>();

    public virtual ICollection<JStockentrystat> JStockentrystats { get; set; } = new List<JStockentrystat>();

    public virtual ICollection<JStockinfo> JStockinfos { get; set; } = new List<JStockinfo>();

    public virtual ICollection<JStockinvcresultitem> JStockinvcresultitems { get; set; } = new List<JStockinvcresultitem>();

    public virtual ICollection<JStockinv> JStockinvs { get; set; } = new List<JStockinv>();

    public virtual ICollection<JStockinvtype> JStockinvtypes { get; set; } = new List<JStockinvtype>();

    public virtual ICollection<JStocklocclassdefelem> JStocklocclassdefelems { get; set; } = new List<JStocklocclassdefelem>();

    public virtual ICollection<JStockloc> JStocklocs { get; set; } = new List<JStockloc>();

    public virtual ICollection<JStockstorage> JStockstorages { get; set; } = new List<JStockstorage>();

    public virtual ICollection<JStocktag> JStocktags { get; set; } = new List<JStocktag>();

    public virtual ICollection<JUsedasedlcontract> JUsedasedlcontractUaecTransportstockdelivs { get; set; } = new List<JUsedasedlcontract>();

    public virtual ICollection<JUsedasedlcontract> JUsedasedlcontractUaecTransportstocksupplies { get; set; } = new List<JUsedasedlcontract>();

    public virtual ICollection<JUsingedlcontract> JUsingedlcontractUecEdllockedstocks { get; set; } = new List<JUsingedlcontract>();

    public virtual ICollection<JUsingedlcontract> JUsingedlcontractUecEdlstocks { get; set; } = new List<JUsingedlcontract>();

    public virtual ICollection<JUsingedlcontract> JUsingedlcontractUecTransportstocks { get; set; } = new List<JUsingedlcontract>();

    public virtual JDoccfg? StDoccfg { get; set; }

    public virtual JStock? StReconciliationstock { get; set; }

    public virtual JStockset StStockset { get; set; } = null!;
}
