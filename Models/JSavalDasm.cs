using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSavalDasm
{
    public decimal SavSubjectId { get; set; }

    public bool SavValue { get; set; }

    public virtual JSubject SavSubject { get; set; } = null!;
}
