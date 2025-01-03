using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class DsNissanfromprod
{
    public decimal NfpId { get; set; }

    public DateTime NfpTcreation { get; set; }

    public decimal? NfpDeletionid { get; set; }

    public DateTime? NfpTdeletion { get; set; }

    public string NfpHdrserial { get; set; } = null!;

    public virtual ICollection<DsNissanfromproditem> DsNissanfromproditems { get; set; } = new List<DsNissanfromproditem>();
}
