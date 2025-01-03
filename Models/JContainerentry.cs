using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerentry
{
    public decimal CteId { get; set; }

    public decimal CteContainerId { get; set; }

    public DateTime CteTcreation { get; set; }

    public DateTime CteTupdate { get; set; }

    public decimal? CteDeletionid { get; set; }

    public DateTime? CteTdeletion { get; set; }

    public short CteIndex { get; set; }

    public string? CtePos { get; set; }

    public virtual JContainer CteContainer { get; set; } = null!;

    public virtual ICollection<JContainercontainer> JContainercontainers { get; set; } = new List<JContainercontainer>();

    public virtual ICollection<JContainersubject> JContainersubjects { get; set; } = new List<JContainersubject>();

    public virtual ICollection<JMsignotification> JMsignotifications { get; set; } = new List<JMsignotification>();

    public virtual ICollection<JPartevent> JPartevents { get; set; } = new List<JPartevent>();

    public virtual ICollection<JPart> JParts { get; set; } = new List<JPart>();

    public virtual ICollection<JProdevent> JProdevents { get; set; } = new List<JProdevent>();

    public virtual ICollection<JProdjobentry> JProdjobentries { get; set; } = new List<JProdjobentry>();

    public virtual ICollection<JStockevent> JStockevents { get; set; } = new List<JStockevent>();

    public virtual ICollection<JStockinvstockloccnrpart> JStockinvstockloccnrparts { get; set; } = new List<JStockinvstockloccnrpart>();

    public virtual ICollection<JSupplynotepart> JSupplynoteparts { get; set; } = new List<JSupplynotepart>();

    public virtual ICollection<JWorkflowjobentry> JWorkflowjobentries { get; set; } = new List<JWorkflowjobentry>();
}
