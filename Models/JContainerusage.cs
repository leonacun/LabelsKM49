using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerusage
{
    public decimal CtuId { get; set; }

    public decimal CtuContainertypeId { get; set; }

    public decimal? CtuSubjectclassId { get; set; }

    public decimal? CtuImageId { get; set; }

    public DateTime CtuTcreation { get; set; }

    public DateTime CtuTupdate { get; set; }

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

    public bool? CtuPosimages { get; set; }

    public decimal? CtuInvalidid { get; set; }

    public DateTime? CtuTvalidfrom { get; set; }

    public DateTime? CtuTvaliduntil { get; set; }

    public string CtuElemexpression { get; set; } = null!;

    public byte CtuDepth { get; set; }

    public string CtuState { get; set; } = null!;

    public virtual JContainertype CtuContainertype { get; set; } = null!;

    public virtual JImage? CtuImage { get; set; }

    public virtual JSubjectclass? CtuSubjectclass { get; set; }

    public virtual ICollection<JContainerposimageregion> JContainerposimageregions { get; set; } = new List<JContainerposimageregion>();

    public virtual ICollection<JContainerposimage> JContainerposimages { get; set; } = new List<JContainerposimage>();

    public virtual ICollection<JContainerposname> JContainerposnames { get; set; } = new List<JContainerposname>();

    public virtual ICollection<JContainerposorderoption> JContainerposorderoptions { get; set; } = new List<JContainerposorderoption>();

    public virtual ICollection<JContainerposorder> JContainerposorders { get; set; } = new List<JContainerposorder>();

    public virtual ICollection<JContainerrule> JContainerrules { get; set; } = new List<JContainerrule>();

    public virtual ICollection<JContainer> JContainers { get; set; } = new List<JContainer>();

    public virtual ICollection<JContainerset> JContainersets { get; set; } = new List<JContainerset>();

    public virtual ICollection<JContainerusageelem> JContainerusageelems { get; set; } = new List<JContainerusageelem>();

    public virtual ICollection<JSkidusage> JSkidusages { get; set; } = new List<JSkidusage>();
}
