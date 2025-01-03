using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class DsNissantoprod
{
    public decimal NtpId { get; set; }

    public DateTime NtpTcreation { get; set; }

    public decimal? NtpDeletionid { get; set; }

    public DateTime? NtpTdeletion { get; set; }

    public string NtpHdrserial { get; set; } = null!;

    public string? NtpHdrouterprodjobno { get; set; }

    public string? NtpHdrinnerprodjobno { get; set; }

    public string? NtpHdrorderno { get; set; }

    public string? NtpHdrdescr { get; set; }

    public string? NtpOptionopcode { get; set; }

    public short NtpOptioncolor { get; set; }

    public short NtpOptionlic { get; set; }

    public short NtpOptionglass { get; set; }

    public short NtpOptionikey { get; set; }

    public short NtpOptionpbd { get; set; }

    public short NtpOptioncamera { get; set; }

    public short NtpOptionhandle { get; set; }

    public short NtpOptionharness { get; set; }
}
