using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMenuitem
{
    public decimal MiId { get; set; }

    public decimal MiMenuId { get; set; }

    public decimal? MiToolId { get; set; }

    public decimal? MiSubmenuId { get; set; }

    public DateTime MiTcreation { get; set; }

    public DateTime MiTupdate { get; set; }

    public string MiKind { get; set; } = null!;

    public string MiDescr { get; set; } = null!;

    public byte MiPosno { get; set; }

    public string? MiIconfile { get; set; }

    public virtual JMenu MiMenu { get; set; } = null!;

    public virtual JMenu? MiSubmenu { get; set; }

    public virtual JTool? MiTool { get; set; }
}
