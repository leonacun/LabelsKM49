using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMaintdefinstr
{
    public decimal MadiId { get; set; }

    public decimal MadiMaintdefId { get; set; }

    public decimal? MadiFileId { get; set; }

    public DateTime MadiTcreation { get; set; }

    public DateTime MadiTupdate { get; set; }

    public byte MadiPos { get; set; }

    public string? MadiDescr { get; set; }

    public int MadiEstdurationinmin { get; set; }

    public string? MadiInfo1 { get; set; }

    public string? MadiInfo2 { get; set; }

    public virtual JFile? MadiFile { get; set; }

    public virtual JMaintdef MadiMaintdef { get; set; } = null!;
}
