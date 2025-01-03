using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSupplynotecontainer
{
    public decimal SuncId { get; set; }

    public decimal SuncSupplynoteId { get; set; }

    public decimal SuncContainerId { get; set; }

    public DateTime SuncTcreation { get; set; }

    public DateTime? SuncTimeadvised { get; set; }

    public DateTime? SuncTimeunloaded { get; set; }

    public bool? SuncHoldscontainers { get; set; }

    public decimal? SuncAdvisedsuncontainerId { get; set; }

    public decimal? SuncUnloadedbyuserId { get; set; }

    public decimal? SuncWhcontainerId { get; set; }

    public virtual ICollection<JSupplynotecontainer> InverseSuncAdvisedsuncontainer { get; set; } = new List<JSupplynotecontainer>();

    public virtual JSupplynotecontainer? SuncAdvisedsuncontainer { get; set; }

    public virtual JContainer SuncContainer { get; set; } = null!;

    public virtual JSupplynote SuncSupplynote { get; set; } = null!;

    public virtual JUser? SuncUnloadedbyuser { get; set; }

    public virtual JContainer? SuncWhcontainer { get; set; }
}
