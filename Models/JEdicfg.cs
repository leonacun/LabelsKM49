using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JEdicfg
{
    public decimal EcId { get; set; }

    public decimal EcCompanyId { get; set; }

    public DateTime EcTcreation { get; set; }

    public DateTime EcTupdate { get; set; }

    public string EcKey { get; set; } = null!;

    public string? EcDescr { get; set; }

    public bool EcDosendedi1 { get; set; }

    public string? EcEdiconfiguration1 { get; set; }

    public string? EcEdirole1 { get; set; }

    public bool EcDosendedi2 { get; set; }

    public string? EcEdiconfiguration2 { get; set; }

    public string? EcEdirole2 { get; set; }

    public bool EcDosendedi3 { get; set; }

    public string? EcEdiconfiguration3 { get; set; }

    public string? EcEdirole3 { get; set; }

    public bool EcDosendedi4 { get; set; }

    public string? EcEdiconfiguration4 { get; set; }

    public string? EcEdirole4 { get; set; }

    public virtual JCompany EcCompany { get; set; } = null!;

    public virtual ICollection<JContainerset> JContainersets { get; set; } = new List<JContainerset>();

    public virtual ICollection<JContract> JContracts { get; set; } = new List<JContract>();

    public virtual ICollection<JEdicfgitem> JEdicfgitems { get; set; } = new List<JEdicfgitem>();

    public virtual ICollection<JPartset> JPartsets { get; set; } = new List<JPartset>();

    public virtual ICollection<JProdstep> JProdsteps { get; set; } = new List<JProdstep>();

    public virtual ICollection<JPurchasecontract> JPurchasecontractPcPurchaseedis { get; set; } = new List<JPurchasecontract>();

    public virtual ICollection<JPurchasecontract> JPurchasecontractPcSupplyedis { get; set; } = new List<JPurchasecontract>();

    public virtual ICollection<JSalecontract> JSalecontracts { get; set; } = new List<JSalecontract>();

    public virtual ICollection<JSelfcontract> JSelfcontractSecDeliveryedis { get; set; } = new List<JSelfcontract>();

    public virtual ICollection<JSelfcontract> JSelfcontractSecSupplyedis { get; set; } = new List<JSelfcontract>();

    public virtual ICollection<JStockinvtype> JStockinvtypes { get; set; } = new List<JStockinvtype>();

    public virtual ICollection<JStocktagset> JStocktagsets { get; set; } = new List<JStocktagset>();

    public virtual ICollection<JUsedasedlcontract> JUsedasedlcontracts { get; set; } = new List<JUsedasedlcontract>();

    public virtual ICollection<JUsingedlcontract> JUsingedlcontracts { get; set; } = new List<JUsingedlcontract>();
}
