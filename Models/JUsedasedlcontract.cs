using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JUsedasedlcontract
{
    public decimal UaecId { get; set; }

    public decimal UaecContractId { get; set; }

    public decimal UaecSalecontractId { get; set; }

    public decimal? UaecTransportstockdelivId { get; set; }

    public decimal? UaecTransportstocksupplyId { get; set; }

    public decimal? UaecDeliveryaddressId { get; set; }

    public decimal? UaecSupplyediId { get; set; }

    public DateTime UaecTcreation { get; set; }

    public DateTime UaecTupdate { get; set; }

    public virtual JContract UaecContract { get; set; } = null!;

    public virtual JAddress? UaecDeliveryaddress { get; set; }

    public virtual JContract UaecSalecontract { get; set; } = null!;

    public virtual JEdicfg? UaecSupplyedi { get; set; }

    public virtual JStock? UaecTransportstockdeliv { get; set; }

    public virtual JStock? UaecTransportstocksupply { get; set; }
}
