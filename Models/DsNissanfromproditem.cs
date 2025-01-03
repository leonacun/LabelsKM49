using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class DsNissanfromproditem
{
    public decimal NfpiId { get; set; }

    public decimal NfpiNissanfromprodId { get; set; }

    public DateTime NfpiTcreation { get; set; }

    public string? NfpiKey1 { get; set; }

    public string? NfpiKey2 { get; set; }

    public string? NfpiKey3 { get; set; }

    public DateTime? NfpiTimevalue { get; set; }

    public string? NfpiStringvalue { get; set; }

    public virtual DsNissanfromprod NfpiNissanfromprod { get; set; } = null!;
}
