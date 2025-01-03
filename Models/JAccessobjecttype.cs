using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JAccessobjecttype
{
    public decimal AcotId { get; set; }

    public DateTime AcotTcreation { get; set; }

    public DateTime AcotTupdate { get; set; }

    public string AcotKey { get; set; } = null!;

    public string AcotDescr { get; set; } = null!;

    public bool? AcotIseditable { get; set; }

    public virtual ICollection<JAccessright> JAccessrights { get; set; } = new List<JAccessright>();

    public virtual ICollection<JToolaccessright> JToolaccessrights { get; set; } = new List<JToolaccessright>();
}
