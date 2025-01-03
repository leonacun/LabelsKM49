using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSchedule
{
    public decimal SchId { get; set; }

    public decimal SchOrderentryId { get; set; }

    public decimal? SchPredscheduleId { get; set; }

    public DateTime SchTcreation { get; set; }

    public DateTime SchTupdate { get; set; }

    public string? SchNo { get; set; }

    public DateTime? SchTimeissued { get; set; }

    public DateTime? SchValiduntiltime { get; set; }

    public decimal SchCumreceiptquantity { get; set; }

    public DateTime? SchCumreceiptreftime { get; set; }

    public string? SchPrevno { get; set; }

    public DateTime? SchPrevtimeissued { get; set; }

    public decimal SchBackorderquantity { get; set; }

    public decimal SchCumreqquantity { get; set; }

    public DateTime? SchCumreqreftime { get; set; }

    public string? SchLastnoteno { get; set; }

    public DateTime? SchLastnotetime { get; set; }

    public decimal SchLastnotequantity { get; set; }

    public decimal? SchSchedulereleaseId { get; set; }

    public virtual ICollection<JSchedule> InverseSchPredschedule { get; set; } = new List<JSchedule>();

    public virtual ICollection<JScheduleentry> JScheduleentries { get; set; } = new List<JScheduleentry>();

    public virtual ICollection<JScheduleinfo> JScheduleinfos { get; set; } = new List<JScheduleinfo>();

    public virtual JOrderentry SchOrderentry { get; set; } = null!;

    public virtual JSchedule? SchPredschedule { get; set; }

    public virtual JSchedulerelease? SchSchedulerelease { get; set; }
}
