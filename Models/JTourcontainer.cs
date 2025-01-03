using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTourcontainer
{
    public decimal TcnId { get; set; }

    public decimal TcnTourId { get; set; }

    public decimal TcnContainerId { get; set; }

    public decimal? TcnOriglocationId { get; set; }

    public decimal? TcnOrigcontractId { get; set; }

    public DateTime TcnTcreation { get; set; }

    public DateTime? TcnTimestaged { get; set; }

    public DateTime? TcnTimeloaded { get; set; }

    public DateTime? TcnTimeverified { get; set; }

    public string? TcnLoadlocationinfo1 { get; set; }

    public string? TcnLoadlocationinfo2 { get; set; }

    public string? TcnLoadlocationinfo3 { get; set; }

    public string? TcnStagingorder { get; set; }

    public string? TcnLoadingorder { get; set; }

    public int TcnPosx { get; set; }

    public int TcnPosy { get; set; }

    public int TcnPosz { get; set; }

    public int TcnSizex { get; set; }

    public int TcnSizey { get; set; }

    public int TcnSizez { get; set; }

    public decimal? TcnPlanneddeliverynoteId { get; set; }

    public DateTime? TcnTimereplaced { get; set; }

    public virtual ICollection<JContainersubjectmark> JContainersubjectmarks { get; set; } = new List<JContainersubjectmark>();

    public virtual ICollection<JTourcontainerdemand> JTourcontainerdemands { get; set; } = new List<JTourcontainerdemand>();

    public virtual JContainer TcnContainer { get; set; } = null!;

    public virtual JContract? TcnOrigcontract { get; set; }

    public virtual JLocation? TcnOriglocation { get; set; }

    public virtual JDeliverynote? TcnPlanneddeliverynote { get; set; }

    public virtual JTour TcnTour { get; set; } = null!;
}
