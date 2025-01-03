using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSupplynoteinfo
{
    public decimal SuniId { get; set; }

    public decimal SuniSupplynoteId { get; set; }

    public decimal? SuniFailurereasonId { get; set; }

    public DateTime SuniTcreation { get; set; }

    public DateTime SuniTupdate { get; set; }

    public string SuniType { get; set; } = null!;

    public string? SuniKey1 { get; set; }

    public string? SuniKey2 { get; set; }

    public string? SuniKey3 { get; set; }

    public DateTime? SuniTimevalue { get; set; }

    public string? SuniStringvalue { get; set; }

    public virtual JFailurereason? SuniFailurereason { get; set; }

    public virtual JSupplynote SuniSupplynote { get; set; } = null!;
}
