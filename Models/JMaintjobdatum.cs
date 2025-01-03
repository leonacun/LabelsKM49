using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JMaintjobdatum
{
    public decimal MajdId { get; set; }

    public decimal MajdMaintjobId { get; set; }

    public decimal? MajdImageId { get; set; }

    public decimal? MajdFileId { get; set; }

    public DateTime MajdTcreation { get; set; }

    public DateTime MajdTupdate { get; set; }

    public decimal? MajdDeletionid { get; set; }

    public DateTime? MajdTdeletion { get; set; }

    public string MajdKind { get; set; } = null!;

    public string? MajdKey { get; set; }

    public string? MajdValue { get; set; }

    public virtual JFile? MajdFile { get; set; }

    public virtual JImage? MajdImage { get; set; }

    public virtual JMaintjob MajdMaintjob { get; set; } = null!;
}
