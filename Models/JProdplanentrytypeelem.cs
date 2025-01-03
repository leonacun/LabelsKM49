using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdplanentrytypeelem
{
    public decimal PpleteId { get; set; }

    public decimal PpleteProdplanentrytypeId { get; set; }

    public decimal PpleteSubjectId { get; set; }

    public DateTime PpleteTcreation { get; set; }

    public DateTime PpleteTupdate { get; set; }

    public decimal PpleteQuantity { get; set; }

    public virtual JProdplanentrytype PpleteProdplanentrytype { get; set; } = null!;

    public virtual JSubject PpleteSubject { get; set; } = null!;
}
