using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JConfigdef
{
    public decimal CdId { get; set; }

    public decimal? CdBaseId { get; set; }

    public DateTime CdTcreation { get; set; }

    public DateTime CdTupdate { get; set; }

    public string CdKey { get; set; } = null!;

    public string CdType { get; set; } = null!;

    public string? CdFilename { get; set; }

    public string? CdDescr { get; set; }

    public int CdDatasize { get; set; }

    public byte[]? CdData { get; set; }

    public string? CdName { get; set; }

    public byte CdMajorversion { get; set; }

    public byte CdMinorversion { get; set; }

    public virtual JConfigdef? CdBase { get; set; }

    public virtual ICollection<JConfigdef> InverseCdBase { get; set; } = new List<JConfigdef>();

    public virtual ICollection<JComponentdef> JComponentdefs { get; set; } = new List<JComponentdef>();

    public virtual ICollection<JConvdef> JConvdefs { get; set; } = new List<JConvdef>();

    public virtual ICollection<JDashboarddataprovider> JDashboarddataproviders { get; set; } = new List<JDashboarddataprovider>();

    public virtual ICollection<JDocdef> JDocdefs { get; set; } = new List<JDocdef>();

    public virtual ICollection<JEdidef> JEdidefs { get; set; } = new List<JEdidef>();

    public virtual ICollection<JInfotemplate> JInfotemplates { get; set; } = new List<JInfotemplate>();

    public virtual ICollection<JKpi> JKpis { get; set; } = new List<JKpi>();

    public virtual ICollection<JOrdermgr> JOrdermgrs { get; set; } = new List<JOrdermgr>();

    public virtual ICollection<JPlugindef> JPlugindefs { get; set; } = new List<JPlugindef>();

    public virtual ICollection<JServicedef> JServicedefs { get; set; } = new List<JServicedef>();

    public virtual ICollection<JTooldef> JTooldefs { get; set; } = new List<JTooldef>();

    public virtual ICollection<JTransferconnection> JTransferconnections { get; set; } = new List<JTransferconnection>();

    public virtual ICollection<JWorkflow> JWorkflows { get; set; } = new List<JWorkflow>();
}
