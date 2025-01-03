using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTool
{
    public decimal ToId { get; set; }

    public decimal ToToolgroupId { get; set; }

    public decimal? ToTooldefId { get; set; }

    public decimal? ToAccessrightsetId { get; set; }

    public DateTime ToTcreation { get; set; }

    public DateTime ToTupdate { get; set; }

    public string? ToKey { get; set; }

    public string ToDescr { get; set; } = null!;

    public string ToCommand { get; set; } = null!;

    public string? ToIconfile { get; set; }

    public string? ToUrl { get; set; }

    public virtual ICollection<JMenuitem> JMenuitems { get; set; } = new List<JMenuitem>();

    public virtual ICollection<JSearchdef> JSearchdefs { get; set; } = new List<JSearchdef>();

    public virtual ICollection<JToolaccessrightset> JToolaccessrightsets { get; set; } = new List<JToolaccessrightset>();

    public virtual ICollection<JToolpropertyset> JToolpropertysets { get; set; } = new List<JToolpropertyset>();

    public virtual JAccessrightset? ToAccessrightset { get; set; }

    public virtual JTooldef? ToTooldef { get; set; }

    public virtual JToolgroup ToToolgroup { get; set; } = null!;
}
