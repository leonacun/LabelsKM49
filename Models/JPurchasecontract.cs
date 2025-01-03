using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPurchasecontract
{
    public decimal PcId { get; set; }

    public decimal PcContractId { get; set; }

    public decimal? PcTransportstockId { get; set; }

    public decimal? PcSupplyediId { get; set; }

    public decimal? PcPurchaseediId { get; set; }

    public DateTime PcTcreation { get; set; }

    public DateTime PcTupdate { get; set; }

    public virtual JContract PcContract { get; set; } = null!;

    public virtual JEdicfg? PcPurchaseedi { get; set; }

    public virtual JEdicfg? PcSupplyedi { get; set; }

    public virtual JStock? PcTransportstock { get; set; }
}
