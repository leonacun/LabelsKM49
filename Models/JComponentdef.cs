using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JComponentdef
{
    public decimal CodId { get; set; }

    public decimal? CodConfigdefId { get; set; }

    public DateTime CodTcreation { get; set; }

    public DateTime CodTupdate { get; set; }

    public string CodKey { get; set; } = null!;

    public string? CodDescr { get; set; }

    public virtual JConfigdef? CodConfigdef { get; set; }

    public virtual ICollection<JComponentdefpropertyset> JComponentdefpropertysets { get; set; } = new List<JComponentdefpropertyset>();

    public virtual ICollection<JTourtemplate> JTourtemplates { get; set; } = new List<JTourtemplate>();
}
