using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdtoolusage
{
    public decimal PtuId { get; set; }

    public decimal PtuProdtoolId { get; set; }

    public DateTime PtuTcreation { get; set; }

    public DateTime PtuTupdate { get; set; }

    public string PtuCode { get; set; } = null!;

    public string PtuDescr { get; set; } = null!;

    public string? PtuParams { get; set; }

    public string PtuCycletimecalcmode { get; set; } = null!;

    public virtual ICollection<JProdevent> JProdevents { get; set; } = new List<JProdevent>();

    public virtual ICollection<JProdplanentry> JProdplanentries { get; set; } = new List<JProdplanentry>();

    public virtual ICollection<JProdtoolusageelem> JProdtoolusageelems { get; set; } = new List<JProdtoolusageelem>();

    public virtual ICollection<JProdunitevent> JProdunitevents { get; set; } = new List<JProdunitevent>();

    public virtual JProdtool PtuProdtool { get; set; } = null!;
}
