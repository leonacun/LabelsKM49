using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSavalStdpackqty
{
    public decimal SavSubjectId { get; set; }

    public int SavValue { get; set; }

    public virtual JSubject SavSubject { get; set; } = null!;
}
