﻿using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProperty
{
    public decimal ProId { get; set; }

    public decimal ProPropertysetId { get; set; }

    public DateTime ProTcreation { get; set; }

    public DateTime ProTupdate { get; set; }

    public string? ProKey { get; set; }

    public string ProName { get; set; } = null!;

    public string ProOwner { get; set; } = null!;

    public string? ProDescr { get; set; }

    public string ProValuetype { get; set; } = null!;

    public string? ProValue { get; set; }

    public byte ProLength { get; set; }

    public bool? ProEnabled { get; set; }

    public virtual JPropertyset ProPropertyset { get; set; } = null!;
}