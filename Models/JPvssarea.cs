using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPvssarea
{
    public decimal PvaId { get; set; }

    public decimal PvaPvssId { get; set; }

    public DateTime PvaTcreation { get; set; }

    public DateTime PvaTupdate { get; set; }

    public string PvaCode { get; set; } = null!;

    public string PvaDescr { get; set; } = null!;

    public DateTime? PvaTimelastsync { get; set; }

    public bool? PvaSyncrequired { get; set; }

    public decimal? PvaPlantId { get; set; }

    public decimal? PvaStorageId { get; set; }

    public decimal? PvaStockId { get; set; }

    public virtual ICollection<JPvssareaprodunit> JPvssareaprodunits { get; set; } = new List<JPvssareaprodunit>();

    public virtual ICollection<JPvssloc> JPvsslocs { get; set; } = new List<JPvssloc>();

    public virtual ICollection<JPvsstype> JPvsstypes { get; set; } = new List<JPvsstype>();

    public virtual JErpentity? PvaPlant { get; set; }

    public virtual JPvss PvaPvss { get; set; } = null!;

    public virtual JStock? PvaStock { get; set; }

    public virtual JErpentity? PvaStorage { get; set; }
}
