using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSavalGmversion
{
    public decimal SavSubjectId { get; set; }

    public string SavValue { get; set; } = null!;

    public virtual JSubject SavSubject { get; set; } = null!;

    public virtual JSadefGmversion SavValueNavigation { get; set; } = null!;
}
