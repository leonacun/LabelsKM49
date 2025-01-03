using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDemandcategoryinfo
{
    public decimal DciId { get; set; }

    public decimal DciDemandcategoryId { get; set; }

    public DateTime DciTcreation { get; set; }

    public DateTime DciTupdate { get; set; }

    public string DciType { get; set; } = null!;

    public string? DciKey { get; set; }

    public DateTime? DciTimevalue { get; set; }

    public string? DciStringvalue { get; set; }

    public int DciIntvalue { get; set; }

    public virtual JDemandcategory DciDemandcategory { get; set; } = null!;
}
