using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDocdef
{
    public decimal DdId { get; set; }

    public decimal DdCompanyId { get; set; }

    public decimal DdPrintitemId { get; set; }

    public decimal? DdConfigdefId { get; set; }

    public DateTime DdTcreation { get; set; }

    public DateTime DdTupdate { get; set; }

    public string DdKey { get; set; } = null!;

    public string DdDoctype { get; set; } = null!;

    public string? DdDescr { get; set; }

    public string? DdDriver { get; set; }

    public string? DdTemplate { get; set; }

    public string? DdParams { get; set; }

    public string? DdConfiguration { get; set; }

    public decimal? DdImageId { get; set; }

    public virtual JCompany DdCompany { get; set; } = null!;

    public virtual JConfigdef? DdConfigdef { get; set; }

    public virtual JImage? DdImage { get; set; }

    public virtual JPrintitem DdPrintitem { get; set; } = null!;

    public virtual ICollection<JDoccfgitem> JDoccfgitems { get; set; } = new List<JDoccfgitem>();

    public virtual ICollection<JDocdefpropertyset> JDocdefpropertysets { get; set; } = new List<JDocdefpropertyset>();
}
