using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMessagecfgset
{
    public decimal MsgcsId { get; set; }

    public DateTime MsgcsTcreation { get; set; }

    public DateTime MsgcsTupdate { get; set; }

    public string MsgcsKey { get; set; } = null!;

    public string MsgcsDescr { get; set; } = null!;

    public bool? MsgcsEnabled { get; set; }

    public virtual ICollection<JMessagecfg> JMessagecfgs { get; set; } = new List<JMessagecfg>();
}
