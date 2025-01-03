using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSubjectclass
{
    public decimal SclId { get; set; }

    public decimal SclProductfamilyId { get; set; }

    public DateTime SclTcreation { get; set; }

    public DateTime SclTupdate { get; set; }

    public string? SclKey { get; set; }

    public string SclDescr { get; set; } = null!;

    public string SclDeftype { get; set; } = null!;

    public bool? SclIseditable { get; set; }

    public virtual ICollection<JContainerrule> JContainerrules { get; set; } = new List<JContainerrule>();

    public virtual ICollection<JContainertypeclass> JContainertypeclasses { get; set; } = new List<JContainertypeclass>();

    public virtual ICollection<JContainerusage> JContainerusages { get; set; } = new List<JContainerusage>();

    public virtual ICollection<JContract> JContracts { get; set; } = new List<JContract>();

    public virtual ICollection<JOrdercontrol> JOrdercontrolOcReqsubjectclasses { get; set; } = new List<JOrdercontrol>();

    public virtual ICollection<JOrdercontrol> JOrdercontrolOcSubjectclasses { get; set; } = new List<JOrdercontrol>();

    public virtual ICollection<JPackcfg> JPackcfgs { get; set; } = new List<JPackcfg>();

    public virtual ICollection<JProdstat> JProdstats { get; set; } = new List<JProdstat>();

    public virtual ICollection<JProdtoolusageelem> JProdtoolusageelems { get; set; } = new List<JProdtoolusageelem>();

    public virtual ICollection<JPvssareaprodunit> JPvssareaprodunits { get; set; } = new List<JPvssareaprodunit>();

    public virtual ICollection<JReportparam> JReportparams { get; set; } = new List<JReportparam>();

    public virtual ICollection<JStockcfg> JStockcfgs { get; set; } = new List<JStockcfg>();

    public virtual ICollection<JStockchannel> JStockchannels { get; set; } = new List<JStockchannel>();

    public virtual ICollection<JStockloc> JStocklocStlEffsubjectclasses { get; set; } = new List<JStockloc>();

    public virtual ICollection<JStockloc> JStocklocStlSubjectclasses { get; set; } = new List<JStockloc>();

    public virtual ICollection<JSubjectclassdefelem> JSubjectclassdefelemScldeInsubjectclasses { get; set; } = new List<JSubjectclassdefelem>();

    public virtual ICollection<JSubjectclassdefelem> JSubjectclassdefelemScldeSubjectclasses { get; set; } = new List<JSubjectclassdefelem>();

    public virtual JProductfamily SclProductfamily { get; set; } = null!;
}
