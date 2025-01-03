using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMessagecfg
{
    public decimal MsgcId { get; set; }

    public decimal MsgcMessagecfgsetId { get; set; }

    public decimal? MsgcGrouptoId { get; set; }

    public decimal? MsgcGroupccId { get; set; }

    public decimal? MsgcPrinterId { get; set; }

    public decimal? MsgcAlerttypeId { get; set; }

    public decimal? MsgcLogId { get; set; }

    public DateTime MsgcTcreation { get; set; }

    public DateTime MsgcTupdate { get; set; }

    public byte MsgcPriority { get; set; }

    public string MsgcToolpattern { get; set; } = null!;

    public string MsgcContextpattern { get; set; } = null!;

    public string MsgcCodepattern { get; set; } = null!;

    public string MsgcSeveritypattern { get; set; } = null!;

    public string? MsgcMailsubject { get; set; }

    public decimal? MsgcGroupbccId { get; set; }

    public string? MsgcAlertkey { get; set; }

    public string MsgcMessagepattern { get; set; } = null!;

    public string? MsgcMailmessage { get; set; }

    public bool? MsgcProceed { get; set; }

    public decimal? MsgcMessagecommandId { get; set; }

    public decimal? MsgcAlertsetId { get; set; }

    public string MsgcInfopattern { get; set; } = null!;

    public virtual JAlertset? MsgcAlertset { get; set; }

    public virtual JAlerttype? MsgcAlerttype { get; set; }

    public virtual JGroup? MsgcGroupbcc { get; set; }

    public virtual JGroup? MsgcGroupcc { get; set; }

    public virtual JGroup? MsgcGroupto { get; set; }

    public virtual JLog? MsgcLog { get; set; }

    public virtual JMessagecfgset MsgcMessagecfgset { get; set; } = null!;

    public virtual JMessagecommand? MsgcMessagecommand { get; set; }

    public virtual JPrinter? MsgcPrinter { get; set; }
}
