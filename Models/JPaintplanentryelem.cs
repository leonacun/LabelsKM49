using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPaintplanentryelem
{
    public decimal PpeeId { get; set; }

    public decimal PpeePaintplanentryId { get; set; }

    public decimal? PpeePaintedsubjectId { get; set; }

    public decimal PpeeRawsubjectId { get; set; }

    public decimal? PpeeRawinchannelId { get; set; }

    public decimal? PpeePaintedoutchannelId { get; set; }

    public DateTime PpeeTcreation { get; set; }

    public byte PpeeIndex { get; set; }

    public decimal PpeeQuantity { get; set; }

    public decimal PpeeLoadedquantity { get; set; }

    public decimal PpeeUnloadedquantity { get; set; }

    public decimal PpeeTotalloadedquantity { get; set; }

    public decimal PpeeTotalunloadedquantity { get; set; }

    public decimal PpeeTotalscrapquantity { get; set; }

    public decimal? PpeeOrderentryId { get; set; }

    public virtual ICollection<JSkidinfoelem> JSkidinfoelems { get; set; } = new List<JSkidinfoelem>();

    public virtual JOrderentry? PpeeOrderentry { get; set; }

    public virtual JPaintchannel? PpeePaintedoutchannel { get; set; }

    public virtual JSubject? PpeePaintedsubject { get; set; }

    public virtual JPaintplanentry PpeePaintplanentry { get; set; } = null!;

    public virtual JPaintchannel? PpeeRawinchannel { get; set; }

    public virtual JSubject PpeeRawsubject { get; set; } = null!;
}
