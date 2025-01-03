using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContractclass
{
    public decimal CclId { get; set; }

    public decimal CclCompanyId { get; set; }

    public DateTime CclTcreation { get; set; }

    public DateTime CclTupdate { get; set; }

    public string CclKey { get; set; } = null!;

    public string CclDescr { get; set; } = null!;

    public string CclDeftype { get; set; } = null!;

    public virtual JCompany CclCompany { get; set; } = null!;

    public virtual ICollection<JContractclassdefelem> JContractclassdefelemCcldeContractclasses { get; set; } = new List<JContractclassdefelem>();

    public virtual ICollection<JContractclassdefelem> JContractclassdefelemCcldeIncontractclasses { get; set; } = new List<JContractclassdefelem>();

    public virtual ICollection<JContractclassmember> JContractclassmembers { get; set; } = new List<JContractclassmember>();
}
