using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdplanentrytype
{
    public decimal PpletId { get; set; }

    public decimal PpletProdplantypeId { get; set; }

    public DateTime PpletTcreation { get; set; }

    public DateTime PpletTupdate { get; set; }

    public string? PpletKey { get; set; }

    public string? PpletShortname { get; set; }

    public string? PpletDescr { get; set; }

    public bool? PpletEnabled { get; set; }

    public virtual ICollection<JProdplanentry> JProdplanentries { get; set; } = new List<JProdplanentry>();

    public virtual ICollection<JProdplanentrytypeelem> JProdplanentrytypeelems { get; set; } = new List<JProdplanentrytypeelem>();

    public virtual ICollection<JProdplanentrytypeinfo> JProdplanentrytypeinfos { get; set; } = new List<JProdplanentrytypeinfo>();

    public virtual JProdplantype PpletProdplantype { get; set; } = null!;
}
