using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdstep
{
    public decimal PrsId { get; set; }

    public decimal PrsProdstepsetId { get; set; }

    public decimal? PrsFreasonsetId { get; set; }

    public decimal? PrsDoccfgId { get; set; }

    public DateTime PrsTcreation { get; set; }

    public string PrsCode { get; set; } = null!;

    public string PrsKey { get; set; } = null!;

    public string PrsDescr { get; set; } = null!;

    public string? PrsLabeltype { get; set; }

    public string? PrsAltlabeltype { get; set; }

    public string PrsKind { get; set; } = null!;

    public bool PrsDohandlestock { get; set; }

    public string? PrsShortdescr { get; set; }

    public decimal? PrsEdicfgId { get; set; }

    public virtual ICollection<JProdcounter> JProdcounters { get; set; } = new List<JProdcounter>();

    public virtual ICollection<JProdevent> JProdevents { get; set; } = new List<JProdevent>();

    public virtual ICollection<JProdflowaction> JProdflowactions { get; set; } = new List<JProdflowaction>();

    public virtual ICollection<JProdjob> JProdjobs { get; set; } = new List<JProdjob>();

    public virtual ICollection<JProdstepclassmember> JProdstepclassmembers { get; set; } = new List<JProdstepclassmember>();

    public virtual ICollection<JProdstepinfo> JProdstepinfos { get; set; } = new List<JProdstepinfo>();

    public virtual ICollection<JProdstepstatus> JProdstepstatuses { get; set; } = new List<JProdstepstatus>();

    public virtual ICollection<JReportparam> JReportparams { get; set; } = new List<JReportparam>();

    public virtual ICollection<JStockcfg> JStockcfgs { get; set; } = new List<JStockcfg>();

    public virtual ICollection<JStocksubstevent> JStocksubstevents { get; set; } = new List<JStocksubstevent>();

    public virtual ICollection<JSubjectcompelem> JSubjectcompelems { get; set; } = new List<JSubjectcompelem>();

    public virtual ICollection<JWorkflowtask> JWorkflowtasks { get; set; } = new List<JWorkflowtask>();

    public virtual JDoccfg? PrsDoccfg { get; set; }

    public virtual JEdicfg? PrsEdicfg { get; set; }

    public virtual JFailurereasonset? PrsFreasonset { get; set; }

    public virtual JProdstepset PrsProdstepset { get; set; } = null!;
}
