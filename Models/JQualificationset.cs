using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JQualificationset
{
    public decimal QsId { get; set; }

    public decimal QsCompanyId { get; set; }

    public DateTime QsTcreation { get; set; }

    public DateTime QsTupdate { get; set; }

    public string QsKey { get; set; } = null!;

    public string QsDescr { get; set; } = null!;

    public virtual ICollection<JQualification> JQualifications { get; set; } = new List<JQualification>();

    public virtual JCompany QsCompany { get; set; } = null!;
}
