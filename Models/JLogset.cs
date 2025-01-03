using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogset
{
    public decimal LogsId { get; set; }

    public DateTime LogsTcreation { get; set; }

    public DateTime LogsTupdate { get; set; }

    public string LogsKey { get; set; } = null!;

    public string LogsDescr { get; set; } = null!;

    public virtual ICollection<JLog> JLogs { get; set; } = new List<JLog>();
}
