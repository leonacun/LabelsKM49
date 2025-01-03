using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdplantype
{
    public decimal PpltId { get; set; }

    public decimal PpltProdplantypesetId { get; set; }

    public DateTime PpltTcreation { get; set; }

    public DateTime PpltTupdate { get; set; }

    public string? PpltKey { get; set; }

    public string? PpltShortname { get; set; }

    public string? PpltDescr { get; set; }

    public virtual ICollection<JProdplanentrytype> JProdplanentrytypes { get; set; } = new List<JProdplanentrytype>();

    public virtual ICollection<JProdplan> JProdplans { get; set; } = new List<JProdplan>();

    public virtual ICollection<JProdplantypeinfo> JProdplantypeinfos { get; set; } = new List<JProdplantypeinfo>();

    public virtual JProdplantypeset PpltProdplantypeset { get; set; } = null!;
}
