using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCreditnote
{
    public decimal CrnId { get; set; }

    public decimal CrnCreditnotesetId { get; set; }

    public decimal CrnCustomercompanyId { get; set; }

    public DateTime CrnTcreation { get; set; }

    public DateTime CrnTupdate { get; set; }

    public string CrnNo { get; set; } = null!;

    public decimal CrnTotalamount { get; set; }

    public string? CrnCurrency { get; set; }

    public virtual JCreditnoteset CrnCreditnoteset { get; set; } = null!;

    public virtual JCompany CrnCustomercompany { get; set; } = null!;

    public virtual ICollection<JCreditnoteentry> JCreditnoteentries { get; set; } = new List<JCreditnoteentry>();
}
