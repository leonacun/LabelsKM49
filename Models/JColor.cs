using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JColor
{
    public decimal ColId { get; set; }

    public decimal ColCompanyId { get; set; }

    public DateTime ColTcreation { get; set; }

    public DateTime ColTupdate { get; set; }

    public string ColCode { get; set; } = null!;

    public string ColDescr { get; set; } = null!;

    public string? ColDisplaycolor { get; set; }

    public string? ColInfo1 { get; set; }

    public string? ColInfo2 { get; set; }

    public string? ColInfo3 { get; set; }

    public virtual JCompany ColCompany { get; set; } = null!;

    public virtual ICollection<JColorclassmember> JColorclassmembers { get; set; } = new List<JColorclassmember>();

    public virtual ICollection<JPaintcolor> JPaintcolors { get; set; } = new List<JPaintcolor>();

    public virtual ICollection<JPaintcolorseq> JPaintcolorseqPacsColors { get; set; } = new List<JPaintcolorseq>();

    public virtual ICollection<JPaintcolorseq> JPaintcolorseqPacsSucccolors { get; set; } = new List<JPaintcolorseq>();

    public virtual ICollection<JPaintplanentry> JPaintplanentries { get; set; } = new List<JPaintplanentry>();

    public virtual ICollection<JPvsssubject> JPvsssubjects { get; set; } = new List<JPvsssubject>();

    public virtual ICollection<JSavalColor> JSavalColors { get; set; } = new List<JSavalColor>();

    public virtual ICollection<JSkid> JSkids { get; set; } = new List<JSkid>();

    public virtual ICollection<JSkidtypecolor> JSkidtypecolors { get; set; } = new List<JSkidtypecolor>();
}
