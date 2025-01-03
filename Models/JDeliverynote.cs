using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JDeliverynote
{
    public decimal DlnId { get; set; }

    public decimal DlnDeliveryentryId { get; set; }

    public decimal? DlnLocationId { get; set; }

    public DateTime DlnTcreation { get; set; }

    public string DlnNo { get; set; } = null!;

    public string? DlnErpno { get; set; }

    public DateTime? DlnReceipttimestamp { get; set; }

    public string? DlnKeyinlocation { get; set; }

    public virtual JDeliveryentry DlnDeliveryentry { get; set; } = null!;

    public virtual JLocation? DlnLocation { get; set; }

    public virtual ICollection<JCreditnoteentry> JCreditnoteentries { get; set; } = new List<JCreditnoteentry>();

    public virtual ICollection<JDeliverynotecontainer> JDeliverynotecontainers { get; set; } = new List<JDeliverynotecontainer>();

    public virtual ICollection<JDeliverynoteentry> JDeliverynoteentries { get; set; } = new List<JDeliverynoteentry>();

    public virtual ICollection<JDeliverynoteinfo> JDeliverynoteinfos { get; set; } = new List<JDeliverynoteinfo>();

    public virtual ICollection<JDeliverynoteorder> JDeliverynoteorders { get; set; } = new List<JDeliverynoteorder>();

    public virtual ICollection<JLoadplanentry> JLoadplanentries { get; set; } = new List<JLoadplanentry>();

    public virtual ICollection<JTourcontainer> JTourcontainers { get; set; } = new List<JTourcontainer>();
}
