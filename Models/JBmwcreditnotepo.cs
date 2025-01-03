using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JBmwcreditnotepo
{
    public decimal BcnpId { get; set; }

    public decimal BcnpBmwcreditnoteId { get; set; }

    public decimal? BcnpSubjectId { get; set; }

    public DateTime BcnpTcreation { get; set; }

    public string BcnpPurchaseno { get; set; } = null!;

    public string? BcnpDeliverynote { get; set; }

    public DateTime BcnpDocumentdate { get; set; }

    public decimal BcnpQuantity { get; set; }

    public string? BcnpCustomersubjectno { get; set; }

    public decimal BcnpPartprice { get; set; }

    public decimal BcnpAmount { get; set; }

    public string? BcnpHeadertext { get; set; }

    public string? BcnpItemtext { get; set; }

    public string? BcnpMaterialdoc { get; set; }

    public string? BcnpMovementtype { get; set; }

    public virtual JBmwcreditnote BcnpBmwcreditnote { get; set; } = null!;

    public virtual JSubject? BcnpSubject { get; set; }
}
