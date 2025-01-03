using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JPart
{
    public decimal PId { get; set; }

    public decimal PPartsetId { get; set; }

    public decimal? PSubjectId { get; set; }

    public decimal? PStockId { get; set; }

    public decimal? PContainerentryId { get; set; }

    public decimal? POrderentryId { get; set; }

    public decimal? PRefpartId { get; set; }

    public decimal? PDoccfgId { get; set; }

    public decimal? PProdunitId { get; set; }

    public decimal? PParentpartId { get; set; }

    public DateTime PTcreation { get; set; }

    public DateTime PTupdate { get; set; }

    public string PNo { get; set; } = null!;

    public string? PQualityclass { get; set; }

    public virtual ICollection<JPart> InversePParentpart { get; set; } = new List<JPart>();

    public virtual ICollection<JPart> InversePRefpart { get; set; } = new List<JPart>();

    public virtual ICollection<JMeasurement> JMeasurements { get; set; } = new List<JMeasurement>();

    public virtual ICollection<JPartbufferentry> JPartbufferentries { get; set; } = new List<JPartbufferentry>();

    public virtual ICollection<JPartdatum> JPartdata { get; set; } = new List<JPartdatum>();

    public virtual ICollection<JPartevent> JParteventPeParentparts { get; set; } = new List<JPartevent>();

    public virtual ICollection<JPartevent> JParteventPeParts { get; set; } = new List<JPartevent>();

    public virtual ICollection<JProdevent> JProdevents { get; set; } = new List<JProdevent>();

    public virtual ICollection<JProdlotpart> JProdlotparts { get; set; } = new List<JProdlotpart>();

    public virtual ICollection<JStockinvdiffitem> JStockinvdiffitemStidiNewparts { get; set; } = new List<JStockinvdiffitem>();

    public virtual ICollection<JStockinvdiffitem> JStockinvdiffitemStidiOldparts { get; set; } = new List<JStockinvdiffitem>();

    public virtual ICollection<JStockinvitem> JStockinvitems { get; set; } = new List<JStockinvitem>();

    public virtual ICollection<JStockinvstockloccnrpart> JStockinvstockloccnrparts { get; set; } = new List<JStockinvstockloccnrpart>();

    public virtual ICollection<JStockinvstocklocpart> JStockinvstocklocparts { get; set; } = new List<JStockinvstocklocpart>();

    public virtual JStocklocpart? JStocklocpart { get; set; }

    public virtual JContainerentry? PContainerentry { get; set; }

    public virtual JDoccfg? PDoccfg { get; set; }

    public virtual JOrderentry? POrderentry { get; set; }

    public virtual JPart? PParentpart { get; set; }

    public virtual JPartset PPartset { get; set; } = null!;

    public virtual JProdunit? PProdunit { get; set; }

    public virtual JPart? PRefpart { get; set; }

    public virtual JStock? PStock { get; set; }

    public virtual JSubject? PSubject { get; set; }
}
