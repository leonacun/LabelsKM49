using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPaintunit
{
    public decimal PauId { get; set; }

    public decimal PauProdunitId { get; set; }

    public decimal PauCounterId { get; set; }

    public decimal? PauDemandcategoryId { get; set; }

    public DateTime PauTcreation { get; set; }

    public short PauLoadtounloadinmin { get; set; }

    public decimal PauSkidinsec { get; set; }

    public short PauMaxplanageindays { get; set; }

    public decimal PauCostpercolorchange { get; set; }

    public decimal? PauAltdemandcategoryId { get; set; }

    public decimal? PauContainersetId { get; set; }

    public decimal? PauSkidtypesetId { get; set; }

    public virtual ICollection<JPaintarea> JPaintareas { get; set; } = new List<JPaintarea>();

    public virtual ICollection<JPaintchannel> JPaintchannels { get; set; } = new List<JPaintchannel>();

    public virtual ICollection<JPaintcolor> JPaintcolors { get; set; } = new List<JPaintcolor>();

    public virtual ICollection<JPaintcolorseq> JPaintcolorseqs { get; set; } = new List<JPaintcolorseq>();

    public virtual ICollection<JPaintplan> JPaintplans { get; set; } = new List<JPaintplan>();

    public virtual ICollection<JPaintplantemplate> JPaintplantemplates { get; set; } = new List<JPaintplantemplate>();

    public virtual ICollection<JPaintunitskidtype> JPaintunitskidtypes { get; set; } = new List<JPaintunitskidtype>();

    public virtual ICollection<JPaintunitstate> JPaintunitstates { get; set; } = new List<JPaintunitstate>();

    public virtual ICollection<JPolyconpaintevent> JPolyconpaintevents { get; set; } = new List<JPolyconpaintevent>();

    public virtual ICollection<JSkid> JSkids { get; set; } = new List<JSkid>();

    public virtual ICollection<JSkidtype> JSkidtypes { get; set; } = new List<JSkidtype>();

    public virtual JDemandcategory? PauAltdemandcategory { get; set; }

    public virtual JContainerset? PauContainerset { get; set; }

    public virtual JCounter PauCounter { get; set; } = null!;

    public virtual JDemandcategory? PauDemandcategory { get; set; }

    public virtual JProdunit PauProdunit { get; set; } = null!;

    public virtual JSkidtypeset? PauSkidtypeset { get; set; }
}
