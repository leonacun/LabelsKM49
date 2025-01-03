using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSelfcontract
{
    public decimal SecId { get; set; }

    public decimal SecContractId { get; set; }

    public decimal? SecDeliveryaddressId { get; set; }

    public decimal? SecTransportstockId { get; set; }

    public decimal? SecTransportstocksupplyId { get; set; }

    public decimal? SecDeliveryediId { get; set; }

    public decimal? SecSupplyediId { get; set; }

    public DateTime SecTcreation { get; set; }

    public DateTime SecTupdate { get; set; }

    public virtual JContract SecContract { get; set; } = null!;

    public virtual JAddress? SecDeliveryaddress { get; set; }

    public virtual JEdicfg? SecDeliveryedi { get; set; }

    public virtual JEdicfg? SecSupplyedi { get; set; }

    public virtual JStock? SecTransportstock { get; set; }

    public virtual JStock? SecTransportstocksupply { get; set; }
}
