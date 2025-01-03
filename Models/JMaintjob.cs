using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMaintjob
{
    public decimal MajId { get; set; }

    public decimal MajMaintjobsetId { get; set; }

    public decimal MajMaintdefId { get; set; }

    public decimal? MajProdtoolId { get; set; }

    public decimal? MajProdunitId { get; set; }

    public DateTime MajTcreation { get; set; }

    public DateTime MajTupdate { get; set; }

    public string? MajKey { get; set; }

    public string? MajDescr { get; set; }

    public string MajState { get; set; } = null!;

    public DateTime MajPlannedstarttime { get; set; }

    public int MajPlanneddurationinmin { get; set; }

    public DateTime? MajStarttime { get; set; }

    public int MajDurationinmin { get; set; }

    public decimal? MajMaintprovId { get; set; }

    public int MajCyclecount { get; set; }

    public DateTime? MajCyclecountresetdate { get; set; }

    public decimal? MajIssuermaintjobId { get; set; }

    public virtual ICollection<JMaintjob> InverseMajIssuermaintjob { get; set; } = new List<JMaintjob>();

    public virtual ICollection<JMaintjobdatum> JMaintjobdata { get; set; } = new List<JMaintjobdatum>();

    public virtual ICollection<JMaintjobmaterial> JMaintjobmaterials { get; set; } = new List<JMaintjobmaterial>();

    public virtual ICollection<JWorktime> JWorktimes { get; set; } = new List<JWorktime>();

    public virtual JMaintjob? MajIssuermaintjob { get; set; }

    public virtual JMaintdef MajMaintdef { get; set; } = null!;

    public virtual JMaintjobset MajMaintjobset { get; set; } = null!;

    public virtual JMaintprov? MajMaintprov { get; set; }

    public virtual JProdtool? MajProdtool { get; set; }

    public virtual JProdunit? MajProdunit { get; set; }
}
