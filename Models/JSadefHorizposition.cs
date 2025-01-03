using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSadefHorizposition
{
    public string SadKey { get; set; } = null!;

    public string SadValue { get; set; } = null!;

    public byte SadPosno { get; set; }

    public virtual ICollection<JSavalHorizposition> JSavalHorizpositions { get; set; } = new List<JSavalHorizposition>();
}
