using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JUsingedlcontract
{
    public decimal UecId { get; set; }

    public decimal UecContractId { get; set; }

    public decimal UecSalecontractId { get; set; }

    public decimal? UecEdlstockId { get; set; }

    public decimal? UecEdllockedstockId { get; set; }

    public decimal? UecDeliveryaddressId { get; set; }

    public decimal? UecTransportstockId { get; set; }

    public decimal? UecDeliveryediId { get; set; }

    public DateTime UecTcreation { get; set; }

    public DateTime UecTupdate { get; set; }

    public virtual JContract UecContract { get; set; } = null!;

    public virtual JAddress? UecDeliveryaddress { get; set; }

    public virtual JEdicfg? UecDeliveryedi { get; set; }

    public virtual JStock? UecEdllockedstock { get; set; }

    public virtual JStock? UecEdlstock { get; set; }

    public virtual JContract UecSalecontract { get; set; } = null!;

    public virtual JStock? UecTransportstock { get; set; }
}
