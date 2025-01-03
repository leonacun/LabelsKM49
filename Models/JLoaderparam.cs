using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLoaderparam
{
    public decimal LopId { get; set; }

    public decimal LopLoadercontrolId { get; set; }

    public decimal LopContainersetclassId { get; set; }

    public decimal? LopOffsetcalendarId { get; set; }

    public decimal? LopLoadereventId { get; set; }

    public DateTime LopTcreation { get; set; }

    public DateTime LopTupdate { get; set; }

    public string LopType { get; set; } = null!;

    public string LopLoadermode { get; set; } = null!;

    public int LopOffsetinmin { get; set; }

    public DateTime? LopReftime { get; set; }

    public int LopContainercount { get; set; }

    public virtual JContainersetclass LopContainersetclass { get; set; } = null!;

    public virtual JLoadercontrol LopLoadercontrol { get; set; } = null!;

    public virtual JLoaderevent? LopLoaderevent { get; set; }

    public virtual JCalendar? LopOffsetcalendar { get; set; }
}
