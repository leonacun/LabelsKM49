using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSalecontract
{
    public decimal ScId { get; set; }

    public decimal ScContractId { get; set; }

    public decimal? ScDeliveryaddressId { get; set; }

    public decimal? ScSaleaddressId { get; set; }

    public decimal? ScTransportstockId { get; set; }

    public decimal? ScDeliveryediId { get; set; }

    public DateTime ScTcreation { get; set; }

    public DateTime ScTupdate { get; set; }

    public virtual JContract ScContract { get; set; } = null!;

    public virtual JAddress? ScDeliveryaddress { get; set; }

    public virtual JEdicfg? ScDeliveryedi { get; set; }

    public virtual JAddress? ScSaleaddress { get; set; }

    public virtual JStock? ScTransportstock { get; set; }
}
