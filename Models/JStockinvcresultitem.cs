using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockinvcresultitem
{
    public decimal SticriId { get; set; }

    public decimal SticriStockinvcommitresultId { get; set; }

    public decimal? SticriStocklocId { get; set; }

    public decimal? SticriOtherstocklocId { get; set; }

    public decimal? SticriOtherstockId { get; set; }

    public decimal? SticriContainerId { get; set; }

    public DateTime SticriTcreation { get; set; }

    public DateTime SticriTupdate { get; set; }

    public string SticriDescr { get; set; } = null!;

    public virtual JContainer? SticriContainer { get; set; }

    public virtual JStock? SticriOtherstock { get; set; }

    public virtual JStockloc? SticriOtherstockloc { get; set; }

    public virtual JStockinvcresult SticriStockinvcommitresult { get; set; } = null!;

    public virtual JStockloc? SticriStockloc { get; set; }
}
