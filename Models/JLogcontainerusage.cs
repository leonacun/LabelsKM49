using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JLogcontainerusage
{
    public decimal OlsId { get; set; }

    public decimal OlsObjectlogId { get; set; }

    public string? CtuKey { get; set; }

    public byte CtuMaxentries { get; set; }

    public bool CtuHoldssubjects { get; set; }

    public bool CtuHoldscontainers { get; set; }

    public bool CtuHoldspackingmaterial { get; set; }

    public bool? CtuHomogeneousentries { get; set; }

    public decimal CtuMaxamount { get; set; }

    public bool CtuHomogeneous { get; set; }

    public bool CtuChomogeneous { get; set; }

    public bool CtuNegativeallowed { get; set; }

    public byte CtuMaxcontainers { get; set; }

    public byte CtuContainermultiple { get; set; }

    public bool CtuHomogeneouscontainers { get; set; }

    public string CtuOrderconstraint { get; set; } = null!;

    public byte CtuColumns { get; set; }

    public string CtuDescr { get; set; } = null!;

    public string CtuPosordermaptype { get; set; } = null!;

    public bool CtuSwaprows { get; set; }

    public bool CtuSwapcolumns { get; set; }

    public bool CtuPosnamemap { get; set; }

    public bool CtuPosimages { get; set; }

    public decimal? CtuContainertypeId { get; set; }

    public decimal? CtuSubjectclassId { get; set; }

    public decimal? CtuImageId { get; set; }

    public decimal? CtuInvalidid { get; set; }

    public DateTime? CtuTvalidfrom { get; set; }

    public DateTime? CtuTvaliduntil { get; set; }

    public string CtuElemexpression { get; set; } = null!;

    public byte CtuDepth { get; set; }

    public string CtuState { get; set; } = null!;

    public virtual JObjectlog OlsObjectlog { get; set; } = null!;
}
