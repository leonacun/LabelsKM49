using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCompanyclass
{
    public decimal CoclId { get; set; }

    public decimal CoclCompanyId { get; set; }

    public DateTime CoclTcreation { get; set; }

    public DateTime CoclTupdate { get; set; }

    public string CoclKey { get; set; } = null!;

    public string CoclDescr { get; set; } = null!;

    public string CoclDeftype { get; set; } = null!;

    public virtual JCompany CoclCompany { get; set; } = null!;

    public virtual ICollection<JCompanyclassdefelem> JCompanyclassdefelemCocldeCompanyclasses { get; set; } = new List<JCompanyclassdefelem>();

    public virtual ICollection<JCompanyclassdefelem> JCompanyclassdefelemCocldeIncompanyclasses { get; set; } = new List<JCompanyclassdefelem>();

    public virtual ICollection<JCompanyclassmember> JCompanyclassmembers { get; set; } = new List<JCompanyclassmember>();

    public virtual ICollection<JContractclassdefelem> JContractclassdefelems { get; set; } = new List<JContractclassdefelem>();
}
