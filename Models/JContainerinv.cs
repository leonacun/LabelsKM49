using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainerinv
{
    public decimal CtinvId { get; set; }

    public DateTime CtinvTcreation { get; set; }

    public DateTime CtinvTupdate { get; set; }

    public string CtinvState { get; set; } = null!;

    public string CtinvDescr { get; set; } = null!;

    public DateTime? CtinvTimestarted { get; set; }

    public DateTime? CtinvTimeended { get; set; }

    public virtual ICollection<JContainerinvcontainerset> JContainerinvcontainersets { get; set; } = new List<JContainerinvcontainerset>();

    public virtual ICollection<JContainerinvsubject> JContainerinvsubjects { get; set; } = new List<JContainerinvsubject>();
}
