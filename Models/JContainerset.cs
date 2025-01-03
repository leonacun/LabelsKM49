using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerset
{
    public decimal CtsId { get; set; }

    public decimal? CtsParentId { get; set; }

    public decimal? CtsCounterId { get; set; }

    public decimal? CtsOthercounterId { get; set; }

    public decimal? CtsContainerusageId { get; set; }

    public decimal? CtsContainertypeId { get; set; }

    public decimal CtsCompanyId { get; set; }

    public decimal? CtsProdplanId { get; set; }

    public decimal? CtsDoccfgId { get; set; }

    public decimal? CtsStockId { get; set; }

    public DateTime CtsTcreation { get; set; }

    public DateTime CtsTupdate { get; set; }

    public string CtsKey { get; set; } = null!;

    public string CtsDescr { get; set; } = null!;

    public string? CtsShortdescr { get; set; }

    public string? CtsSheettype { get; set; }

    public string? CtsAltsheettype { get; set; }

    public string? CtsLabeltype { get; set; }

    public string CtsDeliverymode { get; set; } = null!;

    public string CtsLoadingmode { get; set; } = null!;

    public string? CtsLoadingparams { get; set; }

    public string CtsVerificationmode { get; set; } = null!;

    public bool CtsHasevents { get; set; }

    public bool? CtsUniquenos { get; set; }

    public bool? CtsInventory { get; set; }

    public decimal? CtsAltcounterId { get; set; }

    public decimal? CtsScriptdefId { get; set; }

    public decimal? CtsEdicfgId { get; set; }

    public bool? CtsHassnapshots { get; set; }

    public decimal? CtsContainertypeclassId { get; set; }

    public virtual JCounter? CtsAltcounter { get; set; }

    public virtual JCompany CtsCompany { get; set; } = null!;

    public virtual JContainertype? CtsContainertype { get; set; }

    public virtual JContainertypeclass? CtsContainertypeclass { get; set; }

    public virtual JContainerusage? CtsContainerusage { get; set; }

    public virtual JCounter? CtsCounter { get; set; }

    public virtual JDoccfg? CtsDoccfg { get; set; }

    public virtual JEdicfg? CtsEdicfg { get; set; }

    public virtual JCounter? CtsOthercounter { get; set; }

    public virtual JContainerset? CtsParent { get; set; }

    public virtual JProdplan? CtsProdplan { get; set; }

    public virtual JScriptdef? CtsScriptdef { get; set; }

    public virtual JStock? CtsStock { get; set; }

    public virtual ICollection<JContainerset> InverseCtsParent { get; set; } = new List<JContainerset>();

    public virtual ICollection<JContainerinvcontainerset> JContainerinvcontainersetCtictsContainersets { get; set; } = new List<JContainerinvcontainerset>();

    public virtual ICollection<JContainerinvcontainerset> JContainerinvcontainersetCtictsInvcontainersets { get; set; } = new List<JContainerinvcontainerset>();

    public virtual ICollection<JContainermapcfg> JContainermapcfgCtmcContainersets { get; set; } = new List<JContainermapcfg>();

    public virtual ICollection<JContainermapcfg> JContainermapcfgCtmcSourcecontainersets { get; set; } = new List<JContainermapcfg>();

    public virtual ICollection<JContainer> JContainers { get; set; } = new List<JContainer>();

    public virtual ICollection<JContainersetclassmember> JContainersetclassmembers { get; set; } = new List<JContainersetclassmember>();

    public virtual ICollection<JContainersetcmaptype> JContainersetcmaptypes { get; set; } = new List<JContainersetcmaptype>();

    public virtual ICollection<JContainersetinfo> JContainersetinfoCtsiContainersets { get; set; } = new List<JContainersetinfo>();

    public virtual ICollection<JContainersetinfo> JContainersetinfoCtsiRefcontainersets { get; set; } = new List<JContainersetinfo>();

    public virtual ICollection<JContainersetloc> JContainersetlocs { get; set; } = new List<JContainersetloc>();

    public virtual ICollection<JPaintunit> JPaintunits { get; set; } = new List<JPaintunit>();

    public virtual ICollection<JSkidtype> JSkidtypes { get; set; } = new List<JSkidtype>();

    public virtual ICollection<JStockinvcontainerset> JStockinvcontainersets { get; set; } = new List<JStockinvcontainerset>();

    public virtual ICollection<JStockinvstockloccnr> JStockinvstockloccnrs { get; set; } = new List<JStockinvstockloccnr>();
}
