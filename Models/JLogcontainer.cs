using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogcontainer
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string CtNo { get; set; } = null!;

    public string? CtAltno { get; set; }

    public string? CtOtherno { get; set; }

    public string? CtTempno { get; set; }

    public string CtStatus { get; set; } = null!;

    public DateTime? CtTimeverified { get; set; }

    public string? CtQualityclass { get; set; }

    public decimal? CtContainersetId { get; set; }

    public decimal? CtContractId { get; set; }

    public decimal? CtLocationId { get; set; }

    public decimal? CtProdunitId { get; set; }

    public decimal? CtStockId { get; set; }

    public decimal? CtContainerusageId { get; set; }

    public decimal? CtRootcontainerId { get; set; }

    public decimal? CtOrderId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
