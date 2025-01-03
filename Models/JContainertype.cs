using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainertype
{
    public decimal CttId { get; set; }

    public decimal? CttDimuomId { get; set; }

    public decimal? CttWeightuomId { get; set; }

    public decimal CttContainertypesetId { get; set; }

    public decimal CttSubjectId { get; set; }

    public DateTime CttTcreation { get; set; }

    public DateTime CttTupdate { get; set; }

    public string CttKey { get; set; } = null!;

    public string CttDescr { get; set; } = null!;

    public string? CttShortdescr { get; set; }

    public string? CttIconfile { get; set; }

    public decimal CttWeight { get; set; }

    public decimal CttDimx { get; set; }

    public decimal CttDimy { get; set; }

    public decimal CttDimz { get; set; }

    public bool? CttExpendable { get; set; }

    public virtual JContainertypeset CttContainertypeset { get; set; } = null!;

    public virtual JUnitofmeasure? CttDimuom { get; set; }

    public virtual JSubject CttSubject { get; set; } = null!;

    public virtual JUnitofmeasure? CttWeightuom { get; set; }

    public virtual ICollection<JContainerset> JContainersets { get; set; } = new List<JContainerset>();

    public virtual ICollection<JContainertypeclassm> JContainertypeclassms { get; set; } = new List<JContainertypeclassm>();

    public virtual ICollection<JContainerusage> JContainerusages { get; set; } = new List<JContainerusage>();

    public virtual ICollection<JPackcfg> JPackcfgPcfChildctypes { get; set; } = new List<JPackcfg>();

    public virtual ICollection<JPackcfg> JPackcfgPcfParentctypes { get; set; } = new List<JPackcfg>();

    public virtual ICollection<JSkidtype> JSkidtypes { get; set; } = new List<JSkidtype>();
}
