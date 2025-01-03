using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSavalHorizposition
{
    public decimal SavSubjectId { get; set; }

    public string SavValue { get; set; } = null!;

    public virtual JSubject SavSubject { get; set; } = null!;

    public virtual JSadefHorizposition SavValueNavigation { get; set; } = null!;
}
