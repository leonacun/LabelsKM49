using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JConvdefclassmember
{
    public decimal CvdcmId { get; set; }

    public decimal CvdcmConvdefclassId { get; set; }

    public decimal CvdcmConvdefId { get; set; }

    public DateTime CvdcmTcreation { get; set; }

    public DateTime CvdcmTupdate { get; set; }

    public virtual JConvdef CvdcmConvdef { get; set; } = null!;

    public virtual JConvdefclass CvdcmConvdefclass { get; set; } = null!;
}
