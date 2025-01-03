using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLoguser
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string UShortname { get; set; } = null!;

    public string UPassword { get; set; } = null!;

    public string UDescr { get; set; } = null!;

    public string? UFirstname { get; set; }

    public string? ULastname { get; set; }

    public string? UNo { get; set; }

    public string? UCardid { get; set; }

    public string? UEmail { get; set; }

    public DateTime? UTimelastlogin { get; set; }

    public string UAuthentication { get; set; } = null!;

    public decimal? UUsersetId { get; set; }

    public decimal? UMenuId { get; set; }

    public decimal? UDefaultuserroleId { get; set; }

    public decimal? ULoginpolicyId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
