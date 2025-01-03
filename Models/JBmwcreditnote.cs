using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JBmwcreditnote
{
    public decimal BcnId { get; set; }

    public decimal BcnContractId { get; set; }

    public DateTime BcnTcreation { get; set; }

    public string BcnNo { get; set; } = null!;

    public decimal BcnTotalamount { get; set; }

    public virtual JContract BcnContract { get; set; } = null!;

    public virtual ICollection<JBmwcreditnotepo> JBmwcreditnotepos { get; set; } = new List<JBmwcreditnotepo>();
}
