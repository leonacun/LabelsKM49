using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainertypeclass
{
    public decimal CttcId { get; set; }

    public decimal CttcCompanyId { get; set; }

    public decimal? CttcSubjectclassId { get; set; }

    public decimal? CttcContainertypesetId { get; set; }

    public DateTime CttcTcreation { get; set; }

    public DateTime CttcTupdate { get; set; }

    public string CttcKey { get; set; } = null!;

    public string CttcDescr { get; set; } = null!;

    public string CttcDeftype { get; set; } = null!;

    public byte[]? CttcQuery { get; set; }

    public virtual JCompany CttcCompany { get; set; } = null!;

    public virtual JContainertypeset? CttcContainertypeset { get; set; }

    public virtual JSubjectclass? CttcSubjectclass { get; set; }

    public virtual ICollection<JContainerset> JContainersets { get; set; } = new List<JContainerset>();

    public virtual ICollection<JContainertypeclassm> JContainertypeclassms { get; set; } = new List<JContainertypeclassm>();
}
