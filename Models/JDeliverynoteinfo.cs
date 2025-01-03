using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDeliverynoteinfo
{
    public decimal DlniId { get; set; }

    public decimal DlniDeliverynoteId { get; set; }

    public DateTime DlniTcreation { get; set; }

    public DateTime DlniTupdate { get; set; }

    public string DlniType { get; set; } = null!;

    public string? DlniKey1 { get; set; }

    public string? DlniKey2 { get; set; }

    public string? DlniKey3 { get; set; }

    public DateTime? DlniTimevalue { get; set; }

    public string? DlniStringvalue { get; set; }

    public virtual JDeliverynote DlniDeliverynote { get; set; } = null!;
}
