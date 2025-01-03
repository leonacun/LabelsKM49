using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSavalChryslerengdevidate
{
    public decimal SavSubjectId { get; set; }

    public DateTime? SavValue { get; set; }

    public virtual JSubject SavSubject { get; set; } = null!;
}
