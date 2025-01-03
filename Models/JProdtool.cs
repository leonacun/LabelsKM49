using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdtool
{
    public decimal PtId { get; set; }

    public decimal PtProdtoolsetId { get; set; }

    public DateTime PtTcreation { get; set; }

    public DateTime PtTupdate { get; set; }

    public string PtKey { get; set; } = null!;

    public string? PtCode { get; set; }

    public string PtKind { get; set; } = null!;

    public string PtDescr { get; set; } = null!;

    public decimal PtMincycletimeinsec { get; set; }

    public decimal PtSetuptimeinsec { get; set; }

    public decimal PtTeardowntimeinsec { get; set; }

    public bool? PtEnabled { get; set; }

    public virtual ICollection<JAdviceconfirmation> JAdviceconfirmations { get; set; } = new List<JAdviceconfirmation>();

    public virtual ICollection<JMaintjob> JMaintjobs { get; set; } = new List<JMaintjob>();

    public virtual ICollection<JProdtooladvice> JProdtooladvices { get; set; } = new List<JProdtooladvice>();

    public virtual ICollection<JProdtoolclassmember> JProdtoolclassmembers { get; set; } = new List<JProdtoolclassmember>();

    public virtual ICollection<JProdtoolinfo> JProdtoolinfos { get; set; } = new List<JProdtoolinfo>();

    public virtual ICollection<JProdtoolusage> JProdtoolusages { get; set; } = new List<JProdtoolusage>();

    public virtual ICollection<JProduniteventdatum> JProduniteventdata { get; set; } = new List<JProduniteventdatum>();

    public virtual ICollection<JProdunittool> JProdunittools { get; set; } = new List<JProdunittool>();

    public virtual JProdtoolset PtProdtoolset { get; set; } = null!;
}
