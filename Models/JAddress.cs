using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JAddress
{
    public decimal AdId { get; set; }

    public decimal AdCompanyId { get; set; }

    public DateTime AdTcreation { get; set; }

    public DateTime AdTupdate { get; set; }

    public string? AdKey { get; set; }

    public string AdType { get; set; } = null!;

    public string AdName { get; set; } = null!;

    public bool AdIsmainname { get; set; }

    public string? AdNameext1 { get; set; }

    public bool AdIsmainnameext1 { get; set; }

    public string? AdNameext2 { get; set; }

    public bool AdIsmainnameext2 { get; set; }

    public string? AdCountrycode { get; set; }

    public bool AdIsmaincountrycode { get; set; }

    public string? AdPostcode { get; set; }

    public bool AdIsmainpostcode { get; set; }

    public string? AdCity { get; set; }

    public bool AdIsmaincity { get; set; }

    public string? AdStreet { get; set; }

    public bool AdIsmainstreet { get; set; }

    public string? AdPostofficebox { get; set; }

    public bool AdIsmainpostofficebox { get; set; }

    public string? AdPhone1 { get; set; }

    public bool AdIsmainphone1 { get; set; }

    public string? AdPhone2 { get; set; }

    public bool AdIsmainphone2 { get; set; }

    public string? AdFax { get; set; }

    public bool AdIsmainfax { get; set; }

    public string? AdEmail { get; set; }

    public bool AdIsmainemail { get; set; }

    public virtual JCompany AdCompany { get; set; } = null!;

    public virtual ICollection<JContractinfo> JContractinfos { get; set; } = new List<JContractinfo>();

    public virtual ICollection<JLocation> JLocations { get; set; } = new List<JLocation>();

    public virtual ICollection<JSalecontract> JSalecontractScDeliveryaddresses { get; set; } = new List<JSalecontract>();

    public virtual ICollection<JSalecontract> JSalecontractScSaleaddresses { get; set; } = new List<JSalecontract>();

    public virtual ICollection<JSelfcontract> JSelfcontracts { get; set; } = new List<JSelfcontract>();

    public virtual ICollection<JUsedasedlcontract> JUsedasedlcontracts { get; set; } = new List<JUsedasedlcontract>();

    public virtual ICollection<JUsingedlcontract> JUsingedlcontracts { get; set; } = new List<JUsingedlcontract>();
}
