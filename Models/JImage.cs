using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JImage
{
    public decimal ImId { get; set; }

    public decimal ImImagesetId { get; set; }

    public DateTime ImTcreation { get; set; }

    public DateTime ImTupdate { get; set; }

    public decimal? ImDeletionid { get; set; }

    public DateTime? ImTdeletion { get; set; }

    public string? ImKey { get; set; }

    public string? ImDescr { get; set; }

    public string? ImFilename { get; set; }

    public string? ImEncoding { get; set; }

    public int ImDatasize { get; set; }

    public byte[] ImData { get; set; } = null!;

    public virtual JImageset ImImageset { get; set; } = null!;

    public virtual ICollection<JAdviceinfo> JAdviceinfos { get; set; } = new List<JAdviceinfo>();

    public virtual ICollection<JAdvice> JAdvices { get; set; } = new List<JAdvice>();

    public virtual ICollection<JCompany> JCompanies { get; set; } = new List<JCompany>();

    public virtual ICollection<JContainerposimage> JContainerposimages { get; set; } = new List<JContainerposimage>();

    public virtual ICollection<JContainerusage> JContainerusages { get; set; } = new List<JContainerusage>();

    public virtual ICollection<JDocdef> JDocdefs { get; set; } = new List<JDocdef>();

    public virtual ICollection<JImageregionmap> JImageregionmaps { get; set; } = new List<JImageregionmap>();

    public virtual ICollection<JImageregion> JImageregions { get; set; } = new List<JImageregion>();

    public virtual ICollection<JMaintjobdatum> JMaintjobdata { get; set; } = new List<JMaintjobdatum>();

    public virtual ICollection<JProdeventdatum> JProdeventdata { get; set; } = new List<JProdeventdatum>();

    public virtual ICollection<JProdunitinfo> JProdunitinfos { get; set; } = new List<JProdunitinfo>();

    public virtual ICollection<JSavalImage> JSavalImages { get; set; } = new List<JSavalImage>();
}
