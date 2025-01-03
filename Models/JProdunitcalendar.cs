using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JProdunitcalendar
{
    public decimal PucaId { get; set; }

    public decimal PucaProdunitId { get; set; }

    public decimal PucaCalendarId { get; set; }

    public DateTime PucaTcreation { get; set; }

    public DateTime PucaTupdate { get; set; }

    public short PucaIndex { get; set; }

    public virtual JCalendar PucaCalendar { get; set; } = null!;

    public virtual JProdunit PucaProdunit { get; set; } = null!;
}
