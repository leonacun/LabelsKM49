using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCreditnoteentry
{
    public decimal CrneId { get; set; }

    public decimal CrneCreditnoteId { get; set; }

    public decimal? CrneOwnsubjectId { get; set; }

    public decimal? CrneDeliverynoteId { get; set; }

    public DateTime CrneTcreation { get; set; }

    public string CrnePurchaseorderno { get; set; } = null!;

    public string? CrneDeliverynoteno { get; set; }

    public DateTime CrneDocumentdate { get; set; }

    public string? CrneCustomersubjectno { get; set; }

    public decimal CrneQuantity { get; set; }

    public decimal CrnePartprice { get; set; }

    public decimal CrneAmount { get; set; }

    public string? CrneCurrency { get; set; }

    public virtual JCreditnote CrneCreditnote { get; set; } = null!;

    public virtual JDeliverynote? CrneDeliverynote { get; set; }

    public virtual JSubject? CrneOwnsubject { get; set; }
}
