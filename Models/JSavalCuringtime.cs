using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSavalCuringtime
{
    public decimal SavSubjectId { get; set; }

    public short SavValue { get; set; }

    public virtual JSubject SavSubject { get; set; } = null!;
}
