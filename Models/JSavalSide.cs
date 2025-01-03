using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSavalSide
{
    public decimal SavSubjectId { get; set; }

    public string SavValue { get; set; } = null!;

    public virtual JSubject SavSubject { get; set; } = null!;

    public virtual JSadefSide SavValueNavigation { get; set; } = null!;
}
