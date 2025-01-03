using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockre
{
    public decimal StrId { get; set; }

    public decimal? StrStockentryId { get; set; }

    public decimal? StrProdjobId { get; set; }

    public decimal? StrStocklocId { get; set; }

    public decimal? StrStockcomponentId { get; set; }

    public decimal? StrStockloccontainerId { get; set; }

    public DateTime StrTcreation { get; set; }

    public decimal StrAmount { get; set; }

    public string StrDescr { get; set; } = null!;

    public virtual JProdjob? StrProdjob { get; set; }

    public virtual JStockcomponent? StrStockcomponent { get; set; }

    public virtual JStockentrystat? StrStockentry { get; set; }

    public virtual JStockloc? StrStockloc { get; set; }

    public virtual JStockloccontainer? StrStockloccontainer { get; set; }
}
