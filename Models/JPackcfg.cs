using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPackcfg
{
    public decimal PcfId { get; set; }

    public decimal PcfPackcfgsetId { get; set; }

    public decimal? PcfSubjectId { get; set; }

    public decimal? PcfSubjectclassId { get; set; }

    public decimal? PcfChildctypeId { get; set; }

    public decimal PcfParentctypeId { get; set; }

    public decimal? PcfPackingmaterialId { get; set; }

    public DateTime PcfTcreation { get; set; }

    public DateTime PcfTupdate { get; set; }

    public byte PcfPriority { get; set; }

    public bool PcfIsroot { get; set; }

    public bool PcfUsestdpack { get; set; }

    public decimal PcfMaxquantity { get; set; }

    public decimal PcfPackingmaterialquantity { get; set; }

    public bool? PcfUsestdpackmultiple { get; set; }

    public decimal PcfMaxquantitymultiple { get; set; }

    public string PcfPackingmaterialassign { get; set; } = null!;

    public decimal? PcfInvalidid { get; set; }

    public DateTime? PcfTvalidfrom { get; set; }

    public DateTime? PcfTvaliduntil { get; set; }

    public byte PcfMaxchildcontainers { get; set; }

    public byte PcfChildcontainermultiple { get; set; }

    public decimal? PcfDeletionid { get; set; }

    public DateTime? PcfTdeletion { get; set; }

    public virtual JContainertype? PcfChildctype { get; set; }

    public virtual JPackcfgset PcfPackcfgset { get; set; } = null!;

    public virtual JSubject? PcfPackingmaterial { get; set; }

    public virtual JContainertype PcfParentctype { get; set; } = null!;

    public virtual JSubject? PcfSubject { get; set; }

    public virtual JSubjectclass? PcfSubjectclass { get; set; }
}
