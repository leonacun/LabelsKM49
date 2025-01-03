using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JColorclassmember
{
    public decimal ColcmId { get; set; }

    public decimal ColcmColorclassId { get; set; }

    public decimal ColcmColorId { get; set; }

    public DateTime ColcmTcreation { get; set; }

    public DateTime ColcmTupdate { get; set; }

    public virtual JColor ColcmColor { get; set; } = null!;

    public virtual JColorclass ColcmColorclass { get; set; } = null!;
}
