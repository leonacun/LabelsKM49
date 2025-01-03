using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JObjectlog
{
    public decimal OlId { get; set; }

    public decimal? OlSessionId { get; set; }

    public decimal? OlSnapshotId { get; set; }

    public DateTime OlTcreation { get; set; }

    public string OlType { get; set; } = null!;

    public decimal OlObjectid { get; set; }

    public string OlObjectclassname { get; set; } = null!;

    public decimal? OlTransitionId { get; set; }

    public virtual ICollection<JCposimageregion> JCposimageregions { get; set; } = new List<JCposimageregion>();

    public virtual ICollection<JCposimage> JCposimages { get; set; } = new List<JCposimage>();

    public virtual ICollection<JCposname> JCposnames { get; set; } = new List<JCposname>();

    public virtual ICollection<JCposorder> JCposorders { get; set; } = new List<JCposorder>();

    public virtual ICollection<JCsclass> JCsclasses { get; set; } = new List<JCsclass>();

    public virtual ICollection<JCsclassmember> JCsclassmembers { get; set; } = new List<JCsclassmember>();

    public virtual ICollection<JCusageelem> JCusageelems { get; set; } = new List<JCusageelem>();

    public virtual ICollection<JLogadviceinfo> JLogadviceinfos { get; set; } = new List<JLogadviceinfo>();

    public virtual ICollection<JLogalert> JLogalerts { get; set; } = new List<JLogalert>();

    public virtual ICollection<JLogcontainerentry> JLogcontainerentries { get; set; } = new List<JLogcontainerentry>();

    public virtual ICollection<JLogcontainerrule> JLogcontainerrules { get; set; } = new List<JLogcontainerrule>();

    public virtual ICollection<JLogcontainer> JLogcontainers { get; set; } = new List<JLogcontainer>();

    public virtual ICollection<JLogcontainersetinfo> JLogcontainersetinfos { get; set; } = new List<JLogcontainersetinfo>();

    public virtual ICollection<JLogcontainersetloc> JLogcontainersetlocs { get; set; } = new List<JLogcontainersetloc>();

    public virtual ICollection<JLogcontainerset> JLogcontainersets { get; set; } = new List<JLogcontainerset>();

    public virtual ICollection<JLogcontainersubject> JLogcontainersubjects { get; set; } = new List<JLogcontainersubject>();

    public virtual ICollection<JLogcontainertype> JLogcontainertypes { get; set; } = new List<JLogcontainertype>();

    public virtual ICollection<JLogcontainerusage> JLogcontainerusages { get; set; } = new List<JLogcontainerusage>();

    public virtual ICollection<JLogcontractinfo> JLogcontractinfos { get; set; } = new List<JLogcontractinfo>();

    public virtual ICollection<JLoggroupmember> JLoggroupmembers { get; set; } = new List<JLoggroupmember>();

    public virtual ICollection<JLogprodjob> JLogprodjobs { get; set; } = new List<JLogprodjob>();

    public virtual ICollection<JLogprodstepinfo> JLogprodstepinfos { get; set; } = new List<JLogprodstepinfo>();

    public virtual ICollection<JLogprodunitinfo> JLogprodunitinfos { get; set; } = new List<JLogprodunitinfo>();

    public virtual ICollection<JLogproperty> JLogproperties { get; set; } = new List<JLogproperty>();

    public virtual ICollection<JLogpropertyset> JLogpropertysets { get; set; } = new List<JLogpropertyset>();

    public virtual ICollection<JLogserver> JLogservers { get; set; } = new List<JLogserver>();

    public virtual ICollection<JLogservicedefpropertyset> JLogservicedefpropertysets { get; set; } = new List<JLogservicedefpropertyset>();

    public virtual ICollection<JLogservicedef> JLogservicedefs { get; set; } = new List<JLogservicedef>();

    public virtual ICollection<JLogservicepropertyset> JLogservicepropertysets { get; set; } = new List<JLogservicepropertyset>();

    public virtual ICollection<JLogservice> JLogservices { get; set; } = new List<JLogservice>();

    public virtual ICollection<JLogstation> JLogstations { get; set; } = new List<JLogstation>();

    public virtual ICollection<JLogstockcfg> JLogstockcfgs { get; set; } = new List<JLogstockcfg>();

    public virtual ICollection<JLogsubjectcompelem> JLogsubjectcompelems { get; set; } = new List<JLogsubjectcompelem>();

    public virtual ICollection<JLogsubjectcomp> JLogsubjectcomps { get; set; } = new List<JLogsubjectcomp>();

    public virtual ICollection<JLogsubject> JLogsubjects { get; set; } = new List<JLogsubject>();

    public virtual ICollection<JLoguserinfo> JLoguserinfos { get; set; } = new List<JLoguserinfo>();

    public virtual ICollection<JLoguserrole> JLoguserroles { get; set; } = new List<JLoguserrole>();

    public virtual ICollection<JLoguser> JLogusers { get; set; } = new List<JLoguser>();

    public virtual JSession? OlSession { get; set; }

    public virtual JSnapshot? OlSnapshot { get; set; }

    public virtual JTransition? OlTransition { get; set; }
}
