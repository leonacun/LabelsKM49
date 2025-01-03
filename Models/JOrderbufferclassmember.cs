using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrderbufferclassmember
{
    public decimal ObcmId { get; set; }

    public decimal ObcmOrderbufferclassId { get; set; }

    public decimal ObcmOrderbufferId { get; set; }

    public DateTime ObcmTcreation { get; set; }

    public DateTime ObcmTupdate { get; set; }

    public virtual JOrderbuffer ObcmOrderbuffer { get; set; } = null!;

    public virtual JOrderbufferclass ObcmOrderbufferclass { get; set; } = null!;
}
