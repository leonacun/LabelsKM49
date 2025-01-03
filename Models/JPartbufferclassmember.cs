using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPartbufferclassmember
{
    public decimal PbcmId { get; set; }

    public decimal PbcmPartbufferclassId { get; set; }

    public decimal PbcmPartbufferId { get; set; }

    public DateTime PbcmTcreation { get; set; }

    public DateTime PbcmTupdate { get; set; }

    public virtual JPartbuffer PbcmPartbuffer { get; set; } = null!;

    public virtual JPartbufferclass PbcmPartbufferclass { get; set; } = null!;
}
