using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransfercontrol
{
    public decimal TctrlId { get; set; }

    public decimal TctrlConnectionId { get; set; }

    public decimal? TctrlCalendarId { get; set; }

    public DateTime TctrlTcreation { get; set; }

    public short TctrlIntervalinminutes { get; set; }

    public bool TctrlCheckidletime { get; set; }

    public short TctrlMaxidletimeinminutes { get; set; }

    public DateTime? TctrlTimelastcheck { get; set; }

    public string TctrlInterface { get; set; } = null!;

    public string TctrlKeyinconnection { get; set; } = null!;

    public bool? TctrlNotifyactivity { get; set; }

    public string? TctrlPacketdatarx { get; set; }

    public decimal? TctrlPacketidlastcheck { get; set; }

    public decimal? TctrlAlerttypeId { get; set; }

    public string? TctrlDescr { get; set; }

    public bool? TctrlEnabled { get; set; }

    public string? TctrlMsgcontext { get; set; }

    public DateTime TctrlTupdate { get; set; }

    public DateTime? TctrlTimelastmatch { get; set; }

    public decimal? TctrlPacketidlastmatch { get; set; }

    public string TctrlMode { get; set; } = null!;

    public virtual JAlerttype? TctrlAlerttype { get; set; }

    public virtual JCalendar? TctrlCalendar { get; set; }

    public virtual JTransferconnection TctrlConnection { get; set; } = null!;
}
