using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JAdvice
{
    public decimal AdvId { get; set; }

    public decimal AdvAdvicesetId { get; set; }

    public decimal? AdvAuthorId { get; set; }

    public decimal? AdvTogroupId { get; set; }

    public decimal? AdvConfirmedbyuserId { get; set; }

    public DateTime AdvTcreation { get; set; }

    public string AdvCode { get; set; } = null!;

    public string AdvType { get; set; } = null!;

    public string AdvPriority { get; set; } = null!;

    public string AdvConfirmationpolicy { get; set; } = null!;

    public string AdvDescr { get; set; } = null!;

    public string? AdvReference { get; set; }

    public DateTime? AdvValiduntiltime { get; set; }

    public DateTime? AdvTimeconfirmed { get; set; }

    public decimal? AdvImageId { get; set; }

    public decimal? AdvFileId { get; set; }

    public string AdvConfintervaltimescale { get; set; } = null!;

    public int AdvConfintervalcount { get; set; }

    public virtual JAdviceset AdvAdviceset { get; set; } = null!;

    public virtual JUser? AdvAuthor { get; set; }

    public virtual JUser? AdvConfirmedbyuser { get; set; }

    public virtual JFile? AdvFile { get; set; }

    public virtual JImage? AdvImage { get; set; }

    public virtual JGroup? AdvTogroup { get; set; }

    public virtual ICollection<JAdviceconfirmation> JAdviceconfirmations { get; set; } = new List<JAdviceconfirmation>();

    public virtual ICollection<JAdviceinfo> JAdviceinfos { get; set; } = new List<JAdviceinfo>();

    public virtual ICollection<JProdtooladvice> JProdtooladvices { get; set; } = new List<JProdtooladvice>();

    public virtual ICollection<JProdunitadvice> JProdunitadvices { get; set; } = new List<JProdunitadvice>();
}
