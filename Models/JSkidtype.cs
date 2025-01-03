using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSkidtype
{
    public decimal SktId { get; set; }

    public decimal? SktPaintunitId { get; set; }

    public decimal? SktPaintareaId { get; set; }

    public DateTime SktTcreation { get; set; }

    public DateTime SktTupdate { get; set; }

    public string SktShortname { get; set; } = null!;

    public string SktDescr { get; set; } = null!;

    public bool SktNoskid { get; set; }

    public bool SktLocked { get; set; }

    public decimal? SktContainersetId { get; set; }

    public decimal? SktContainertypeId { get; set; }

    public decimal SktSkidtypesetId { get; set; }

    public virtual ICollection<JPaintplanentry> JPaintplanentries { get; set; } = new List<JPaintplanentry>();

    public virtual ICollection<JPaintplantemplateentry> JPaintplantemplateentries { get; set; } = new List<JPaintplantemplateentry>();

    public virtual ICollection<JPaintunitskidtype> JPaintunitskidtypes { get; set; } = new List<JPaintunitskidtype>();

    public virtual ICollection<JSkid> JSkidSkLastskidtypes { get; set; } = new List<JSkid>();

    public virtual ICollection<JSkid> JSkidSkSkidtypes { get; set; } = new List<JSkid>();

    public virtual ICollection<JSkidtypecolor> JSkidtypecolors { get; set; } = new List<JSkidtypecolor>();

    public virtual ICollection<JSkidtypeinfo> JSkidtypeinfos { get; set; } = new List<JSkidtypeinfo>();

    public virtual ICollection<JSkidusage> JSkidusages { get; set; } = new List<JSkidusage>();

    public virtual JContainerset? SktContainerset { get; set; }

    public virtual JContainertype? SktContainertype { get; set; }

    public virtual JPaintarea? SktPaintarea { get; set; }

    public virtual JPaintunit? SktPaintunit { get; set; }

    public virtual JSkidtypeset SktSkidtypeset { get; set; } = null!;
}
