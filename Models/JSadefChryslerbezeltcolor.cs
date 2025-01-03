using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSadefChryslerbezeltcolor
{
    public string SadKey { get; set; } = null!;

    public string SadValue { get; set; } = null!;

    public byte SadPosno { get; set; }

    public virtual ICollection<JSavalChryslerbezeltrimcolor> JSavalChryslerbezeltrimcolors { get; set; } = new List<JSavalChryslerbezeltrimcolor>();
}
