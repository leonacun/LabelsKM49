using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JConvdefclass
{
    public decimal CvdcId { get; set; }

    public DateTime CvdcTcreation { get; set; }

    public DateTime CvdcTupdate { get; set; }

    public string CvdcKey { get; set; } = null!;

    public string CvdcDescr { get; set; } = null!;

    public virtual ICollection<JConvdefclassmember> JConvdefclassmembers { get; set; } = new List<JConvdefclassmember>();
}
