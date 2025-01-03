﻿using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSavalPartstyle
{
    public decimal SavSubjectId { get; set; }

    public string? SavValue { get; set; }

    public virtual JSubject SavSubject { get; set; } = null!;

    public virtual JSadefPartstyle? SavValueNavigation { get; set; }
}