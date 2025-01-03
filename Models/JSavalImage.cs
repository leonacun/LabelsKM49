﻿using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSavalImage
{
    public decimal SavSubjectId { get; set; }

    public decimal? SavValue { get; set; }

    public virtual JSubject SavSubject { get; set; } = null!;

    public virtual JImage? SavValueNavigation { get; set; }
}
