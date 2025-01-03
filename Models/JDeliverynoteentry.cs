using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDeliverynoteentry
{
    public decimal DlneId { get; set; }

    public decimal DlneDeliverynoteId { get; set; }

    public decimal DlneSubjectId { get; set; }

    public decimal? DlneOthersubjectId { get; set; }

    public decimal? DlneContractorderId { get; set; }

    public DateTime DlneTcreation { get; set; }

    public bool DlneIsinternal { get; set; }

    public bool DlneIspackage { get; set; }

    public decimal DlneAmount { get; set; }

    public decimal DlneTotalamount { get; set; }

    public decimal DlneCumulatedamount { get; set; }

    public int? DlneNo { get; set; }

    public virtual JOrder? DlneContractorder { get; set; }

    public virtual JDeliverynote DlneDeliverynote { get; set; } = null!;

    public virtual JSubject? DlneOthersubject { get; set; }

    public virtual JSubject DlneSubject { get; set; } = null!;

    public virtual ICollection<JDeliverynoteentryorder> JDeliverynoteentryorders { get; set; } = new List<JDeliverynoteentryorder>();
}
