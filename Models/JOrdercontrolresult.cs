using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JOrdercontrolresult
{
    public decimal OcrId { get; set; }

    public decimal OcrOrdercontrolId { get; set; }

    public DateTime OcrTcreation { get; set; }

    public DateTime OcrTupdate { get; set; }

    public bool? OcrSimulation { get; set; }

    public int OcrCycle { get; set; }

    public virtual ICollection<JOrdercontrolresultitem> JOrdercontrolresultitems { get; set; } = new List<JOrdercontrolresultitem>();

    public virtual JOrdercontrol OcrOrdercontrol { get; set; } = null!;
}
