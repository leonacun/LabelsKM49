using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPolyconpaintevent
{
    public decimal DpcpeId { get; set; }

    public decimal? DpcpePaintunitId { get; set; }

    public decimal? DpcpeSkidId { get; set; }

    public decimal? DpcpeSkidinfo1Id { get; set; }

    public decimal? DpcpeSkidinfo2Id { get; set; }

    public decimal? DpcpePaintedpartId { get; set; }

    public DateTime DpcpeTcreation { get; set; }

    public DateTime DpcpeTupdate { get; set; }

    public string? DpcpeStation { get; set; }

    public string? DpcpeState { get; set; }

    public long? DpcpeSeqno { get; set; }

    public long? DpcpeRndno { get; set; }

    public long? DpcpeCarno { get; set; }

    public long? DpcpeCarnoret { get; set; }

    public long? DpcpeErrcd { get; set; }

    public string? DpcpeErrmsg { get; set; }

    public long? DpcpeRetcode { get; set; }

    public long? DpcpeTrnscd { get; set; }

    public string? DpcpeTrnsmsg { get; set; }

    public string? DpcpePaintedpartno { get; set; }

    public string? DpcpeProgramtype { get; set; }

    public long? DpcpeResult1 { get; set; }

    public long? DpcpeResult2 { get; set; }

    public long? DpcpeB1sys { get; set; }

    public long? DpcpeB2sys { get; set; }

    public long? DpcpeB3sys { get; set; }

    public long? DpcpeC1sys { get; set; }

    public long? DpcpeC2sys { get; set; }

    public string? DpcpeWatch { get; set; }

    public virtual JSubject? DpcpePaintedpart { get; set; }

    public virtual JPaintunit? DpcpePaintunit { get; set; }

    public virtual JSkid? DpcpeSkid { get; set; }

    public virtual JSkidinfo? DpcpeSkidinfo1 { get; set; }

    public virtual JSkidinfo? DpcpeSkidinfo2 { get; set; }
}
