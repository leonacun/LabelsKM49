using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTicket
{
    public decimal TicId { get; set; }

    public decimal TicTicketsetId { get; set; }

    public decimal? TicAuthorId { get; set; }

    public decimal? TicProcessorId { get; set; }

    public decimal TicStateId { get; set; }

    public decimal? TicProdunitId { get; set; }

    public decimal? TicReasonId { get; set; }

    public DateTime TicTcreation { get; set; }

    public DateTime TicTupdate { get; set; }

    public decimal? TicHistoryid { get; set; }

    public decimal? TicHistoryrefid { get; set; }

    public string TicNo { get; set; } = null!;

    public string? TicComment { get; set; }

    public string? TicReleasecode { get; set; }

    public DateTime? TicTimeended { get; set; }

    public DateTime? TicTimeexpires { get; set; }

    public decimal? TicProcessorgroupId { get; set; }

    public DateTime? TicTimeworkstarted { get; set; }

    public virtual JUser? TicAuthor { get; set; }

    public virtual JUser? TicProcessor { get; set; }

    public virtual JGroup? TicProcessorgroup { get; set; }

    public virtual JProdunit? TicProdunit { get; set; }

    public virtual JFailurereason? TicReason { get; set; }

    public virtual JTicketworkflowstate TicState { get; set; } = null!;

    public virtual JTicketset TicTicketset { get; set; } = null!;
}
