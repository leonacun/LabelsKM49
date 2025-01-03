using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JToolaccessrightset
{
    public decimal ToarsId { get; set; }

    public decimal ToarsToolId { get; set; }

    public decimal? ToarsUserroleId { get; set; }

    public DateTime ToarsTcreation { get; set; }

    public DateTime ToarsTupdate { get; set; }

    public string? ToarsDescr { get; set; }

    public virtual ICollection<JToolaccessright> JToolaccessrights { get; set; } = new List<JToolaccessright>();

    public virtual JTool ToarsTool { get; set; } = null!;

    public virtual JUserrole? ToarsUserrole { get; set; }
}
