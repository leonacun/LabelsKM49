using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdstepclass
{
    public decimal PrsclId { get; set; }

    public decimal PrsclCompanyId { get; set; }

    public DateTime PrsclTcreation { get; set; }

    public DateTime PrsclTupdate { get; set; }

    public string PrsclKey { get; set; } = null!;

    public string PrsclDescr { get; set; } = null!;

    public virtual ICollection<JProdstepclassmember> JProdstepclassmembers { get; set; } = new List<JProdstepclassmember>();

    public virtual JCompany PrsclCompany { get; set; } = null!;
}
