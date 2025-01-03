using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdjobbufferclassm
{
    public decimal PjbcmId { get; set; }

    public decimal PjbcmProdjobbufferclassId { get; set; }

    public decimal PjbcmProdjobbufferId { get; set; }

    public DateTime PjbcmTcreation { get; set; }

    public DateTime PjbcmTupdate { get; set; }

    public virtual JProdjobbuffer PjbcmProdjobbuffer { get; set; } = null!;

    public virtual JProdjobbufferclass PjbcmProdjobbufferclass { get; set; } = null!;
}
