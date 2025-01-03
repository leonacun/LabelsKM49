using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMessagecommand
{
    public decimal MsgcmdId { get; set; }

    public DateTime MsgcmdTcreation { get; set; }

    public DateTime MsgcmdTupdate { get; set; }

    public string MsgcmdKey { get; set; } = null!;

    public string MsgcmdDescr { get; set; } = null!;

    public string? MsgcmdMessageform { get; set; }

    public virtual ICollection<JMessagecfg> JMessagecfgs { get; set; } = new List<JMessagecfg>();
}
