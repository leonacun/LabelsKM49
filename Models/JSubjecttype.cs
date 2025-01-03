using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSubjecttype
{
    public decimal StyId { get; set; }

    public decimal StyCompanyId { get; set; }

    public decimal StyProductfamilyId { get; set; }

    public decimal? StyDoccfgId { get; set; }

    public DateTime StyTcreation { get; set; }

    public DateTime StyTupdate { get; set; }

    public string StyKeyincompany { get; set; } = null!;

    public string StyDescr { get; set; } = null!;

    public string? StyShortdescr { get; set; }

    public string? StyCommodity { get; set; }

    public string? StyGroup { get; set; }

    public string? StyIconfile { get; set; }

    public bool StyContainertypes { get; set; }

    public bool StyPackingmaterial { get; set; }

    public virtual ICollection<JContainermapcfg> JContainermapcfgs { get; set; } = new List<JContainermapcfg>();

    public virtual ICollection<JProdflowusage> JProdflowusages { get; set; } = new List<JProdflowusage>();

    public virtual ICollection<JStockcfg> JStockcfgs { get; set; } = new List<JStockcfg>();

    public virtual ICollection<JSubjectclassdefelem> JSubjectclassdefelems { get; set; } = new List<JSubjectclassdefelem>();

    public virtual ICollection<JSubject> JSubjects { get; set; } = new List<JSubject>();

    public virtual ICollection<JSubjecttypeattr> JSubjecttypeattrs { get; set; } = new List<JSubjecttypeattr>();

    public virtual ICollection<JSubjecttypeinfo> JSubjecttypeinfos { get; set; } = new List<JSubjecttypeinfo>();

    public virtual JCompany StyCompany { get; set; } = null!;

    public virtual JDoccfg? StyDoccfg { get; set; }

    public virtual JProductfamily StyProductfamily { get; set; } = null!;
}
