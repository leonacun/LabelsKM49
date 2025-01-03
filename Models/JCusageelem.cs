using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCusageelem
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public decimal CtueMaxamount { get; set; }

    public decimal? CtueContainerusageId { get; set; }

    public decimal? CtueSubjectId { get; set; }

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
