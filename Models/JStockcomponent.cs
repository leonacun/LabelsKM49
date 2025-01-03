using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockcomponent
{
    public decimal StcId { get; set; }

    public decimal StcStockId { get; set; }

    public decimal StcSubjectId { get; set; }

    public decimal? StcOrderId { get; set; }

    public DateTime StcTcreation { get; set; }

    public DateTime StcTupdate { get; set; }

    public decimal StcCurrentamount { get; set; }

    public decimal StcReservedamount { get; set; }

    public decimal StcLockedamount { get; set; }

    public virtual ICollection<JStockre> JStockres { get; set; } = new List<JStockre>();

    public virtual JOrder? StcOrder { get; set; }

    public virtual JStock StcStock { get; set; } = null!;

    public virtual JSubject StcSubject { get; set; } = null!;
}
