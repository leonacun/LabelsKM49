using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStocklocclassdefelem
{
    public decimal StlcldeId { get; set; }

    public decimal StlcldeStocklocclassId { get; set; }

    public decimal? StlcldeInstocklocclassId { get; set; }

    public decimal? StlcldeStockId { get; set; }

    public decimal? StlcldeStockloctypeId { get; set; }

    public decimal? StlcldeStocklocstatusId { get; set; }

    public DateTime StlcldeTcreation { get; set; }

    public DateTime StlcldeTupdate { get; set; }

    public string? StlcldeInfotype { get; set; }

    public string? StlcldeInfokey1 { get; set; }

    public string? StlcldeInfovalues { get; set; }

    public byte[]? StlcldeQuery { get; set; }

    public virtual JStocklocclass? StlcldeInstocklocclass { get; set; }

    public virtual JStock? StlcldeStock { get; set; }

    public virtual JStocklocclass StlcldeStocklocclass { get; set; } = null!;

    public virtual JStocklocstatus? StlcldeStocklocstatus { get; set; }

    public virtual JStockloctype? StlcldeStockloctype { get; set; }
}
