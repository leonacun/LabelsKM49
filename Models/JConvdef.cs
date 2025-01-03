using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JConvdef
{
    public decimal CvdId { get; set; }

    public decimal? CvdConfigdefId { get; set; }

    public DateTime CvdTcreation { get; set; }

    public DateTime CvdTupdate { get; set; }

    public string CvdKey { get; set; } = null!;

    public string? CvdDescr { get; set; }

    public bool CvdOpimport { get; set; }

    public bool CvdOpexport { get; set; }

    public virtual JConfigdef? CvdConfigdef { get; set; }

    public virtual ICollection<JConvdefclassmember> JConvdefclassmembers { get; set; } = new List<JConvdefclassmember>();
}
