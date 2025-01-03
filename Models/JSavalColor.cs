﻿using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSavalColor
{
    public decimal SavSubjectId { get; set; }

    public decimal SavValue { get; set; }

    public virtual JSubject SavSubject { get; set; } = null!;

    public virtual JColor SavValueNavigation { get; set; } = null!;
}
