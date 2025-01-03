using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdtoolclass
{
    public decimal PtclId { get; set; }

    public decimal PtclCompanyId { get; set; }

    public DateTime PtclTcreation { get; set; }

    public DateTime PtclTupdate { get; set; }

    public string PtclKey { get; set; } = null!;

    public string PtclDescr { get; set; } = null!;

    public virtual ICollection<JMaintdef> JMaintdefs { get; set; } = new List<JMaintdef>();

    public virtual ICollection<JProdtoolclassmember> JProdtoolclassmembers { get; set; } = new List<JProdtoolclassmember>();

    public virtual JCompany PtclCompany { get; set; } = null!;
}
