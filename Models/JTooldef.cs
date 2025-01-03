using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTooldef
{
    public decimal TodId { get; set; }

    public decimal? TodConfigdefId { get; set; }

    public DateTime TodTcreation { get; set; }

    public DateTime TodTupdate { get; set; }

    public string TodKey { get; set; } = null!;

    public string? TodDescr { get; set; }

    public string? TodUrl { get; set; }

    public string? TodCommand { get; set; }

    public bool TodIswebjit { get; set; }

    public bool TodIsx11 { get; set; }

    public bool TodIsservice { get; set; }

    public bool TodIsbatchjob { get; set; }

    public virtual ICollection<JSearchdef> JSearchdefs { get; set; } = new List<JSearchdef>();

    public virtual ICollection<JTooldefpropertyset> JTooldefpropertysets { get; set; } = new List<JTooldefpropertyset>();

    public virtual ICollection<JTool> JTools { get; set; } = new List<JTool>();

    public virtual JConfigdef? TodConfigdef { get; set; }
}
