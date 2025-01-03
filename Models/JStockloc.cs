using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JStockloc
{
    public decimal StlId { get; set; }

    public decimal StlStockId { get; set; }

    public decimal? StlParentId { get; set; }

    public decimal? StlStockloctypeId { get; set; }

    public decimal StlStocklocstatusId { get; set; }

    public decimal? StlSubjectId { get; set; }

    public decimal? StlSubjectclassId { get; set; }

    public decimal? StlEffsubjectclassId { get; set; }

    public DateTime StlTcreation { get; set; }

    public DateTime StlTupdate { get; set; }

    public decimal? StlDeletionid { get; set; }

    public DateTime? StlTdeletion { get; set; }

    public byte StlDepth { get; set; }

    public int StlIndex { get; set; }

    public string StlName { get; set; } = null!;

    public string StlFullname { get; set; } = null!;

    public string? StlFullorder1 { get; set; }

    public string? StlKeyinstock { get; set; }

    public string? StlDescr { get; set; }

    public string? StlChildnameformat { get; set; }

    public bool StlEnablecontainers { get; set; }

    public bool? StlEnablesubjects { get; set; }

    public int StlMaxcontainers { get; set; }

    public int StlNumcontainers { get; set; }

    public string? StlCheckcode { get; set; }

    public byte StlNumactiveinv { get; set; }

    public decimal? StlBeforeinvstocklocstatusId { get; set; }

    public bool? StlHomogeneous { get; set; }

    public virtual ICollection<JStockloc> InverseStlParent { get; set; } = new List<JStockloc>();

    public virtual ICollection<JProdjob> JProdjobPjDeststocklocs { get; set; } = new List<JProdjob>();

    public virtual ICollection<JProdjob> JProdjobPjSourcestocklocs { get; set; } = new List<JProdjob>();

    public virtual ICollection<JStockcfg> JStockcfgs { get; set; } = new List<JStockcfg>();

    public virtual ICollection<JStockevent> JStockevents { get; set; } = new List<JStockevent>();

    public virtual ICollection<JStockinvcresultitem> JStockinvcresultitemSticriOtherstocklocs { get; set; } = new List<JStockinvcresultitem>();

    public virtual ICollection<JStockinvcresultitem> JStockinvcresultitemSticriStocklocs { get; set; } = new List<JStockinvcresultitem>();

    public virtual ICollection<JStockinvdiffitem> JStockinvdiffitems { get; set; } = new List<JStockinvdiffitem>();

    public virtual ICollection<JStockinvitem> JStockinvitems { get; set; } = new List<JStockinvitem>();

    public virtual ICollection<JStockinvstockloc> JStockinvstocklocs { get; set; } = new List<JStockinvstockloc>();

    public virtual ICollection<JStocklocclassmember> JStocklocclassmembers { get; set; } = new List<JStocklocclassmember>();

    public virtual ICollection<JStockloccontainer> JStockloccontainers { get; set; } = new List<JStockloccontainer>();

    public virtual ICollection<JStocklocinfo> JStocklocinfos { get; set; } = new List<JStocklocinfo>();

    public virtual ICollection<JStocklocpart> JStocklocparts { get; set; } = new List<JStocklocpart>();

    public virtual ICollection<JStocklocsubject> JStocklocsubjects { get; set; } = new List<JStocklocsubject>();

    public virtual ICollection<JStockre> JStockres { get; set; } = new List<JStockre>();

    public virtual ICollection<JStockstorageelemloc> JStockstorageelemlocs { get; set; } = new List<JStockstorageelemloc>();

    public virtual JStocklocstatus? StlBeforeinvstocklocstatus { get; set; }

    public virtual JSubjectclass? StlEffsubjectclass { get; set; }

    public virtual JStockloc? StlParent { get; set; }

    public virtual JStock StlStock { get; set; } = null!;

    public virtual JStocklocstatus StlStocklocstatus { get; set; } = null!;

    public virtual JStockloctype? StlStockloctype { get; set; }

    public virtual JSubject? StlSubject { get; set; }

    public virtual JSubjectclass? StlSubjectclass { get; set; }
}
