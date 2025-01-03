using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransferconnclassm
{
    public decimal TcclmId { get; set; }

    public decimal TcclmTransferconnclassId { get; set; }

    public decimal TcclmTransferconnectionId { get; set; }

    public DateTime TcclmTcreation { get; set; }

    public DateTime TcclmTupdate { get; set; }

    public virtual JTransferconnclass TcclmTransferconnclass { get; set; } = null!;

    public virtual JTransferconnection TcclmTransferconnection { get; set; } = null!;
}
