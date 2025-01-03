using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSadefLighting
{
    public string SadKey { get; set; } = null!;

    public string SadValue { get; set; } = null!;

    public byte SadPosno { get; set; }

    public virtual ICollection<JSavalLighting> JSavalLightings { get; set; } = new List<JSavalLighting>();
}
