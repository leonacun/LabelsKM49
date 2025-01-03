﻿using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSadefGmcountry
{
    public string SadKey { get; set; } = null!;

    public string SadValue { get; set; } = null!;

    public byte SadPosno { get; set; }

    public virtual ICollection<JSavalGmcountry> JSavalGmcountries { get; set; } = new List<JSavalGmcountry>();
}
