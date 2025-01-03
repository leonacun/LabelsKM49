using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JChoice
{
    public decimal ChId { get; set; }

    public decimal ChCompanyId { get; set; }

    public DateTime ChTcreation { get; set; }

    public DateTime ChTupdate { get; set; }

    public string ChKeyincompany { get; set; } = null!;

    public string ChDescr { get; set; } = null!;

    public string ChTablename { get; set; } = null!;

    public string ChKeycolumnname { get; set; } = null!;

    public string ChValuecolumnname { get; set; } = null!;

    public string ChOrdercolumnname { get; set; } = null!;

    public virtual JCompany ChCompany { get; set; } = null!;

    public virtual ICollection<JSubjectattr> JSubjectattrs { get; set; } = new List<JSubjectattr>();
}
