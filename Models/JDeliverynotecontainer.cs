using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDeliverynotecontainer
{
    public decimal DlncId { get; set; }

    public decimal DlncDeliverynoteId { get; set; }

    public decimal DlncContainerId { get; set; }

    public DateTime DlncTcreation { get; set; }

    public virtual JContainer DlncContainer { get; set; } = null!;

    public virtual JDeliverynote DlncDeliverynote { get; set; } = null!;
}
