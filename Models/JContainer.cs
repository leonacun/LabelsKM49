using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JContainer
{
    public decimal CtId { get; set; }

    public decimal CtContainersetId { get; set; }

    public decimal? CtContractId { get; set; }

    public decimal? CtLocationId { get; set; }

    public decimal? CtProdunitId { get; set; }

    public decimal? CtStockId { get; set; }

    public decimal? CtContainerusageId { get; set; }

    public decimal CtRootcontainerId { get; set; }

    public DateTime CtTcreation { get; set; }

    public DateTime CtTupdate { get; set; }

    public decimal? CtDeletionid { get; set; }

    public DateTime? CtTdeletion { get; set; }

    public string CtNo { get; set; } = null!;

    public string? CtOtherno { get; set; }

    public string? CtTempno { get; set; }

    public string CtStatus { get; set; } = null!;

    public DateTime? CtTimeverified { get; set; }

    public decimal? CtOrderId { get; set; }

    public string? CtQualityclass { get; set; }

    public string? CtAltno { get; set; }

    public virtual JContainerset CtContainerset { get; set; } = null!;

    public virtual JContainerusage? CtContainerusage { get; set; }

    public virtual JContract? CtContract { get; set; }

    public virtual JLocation? CtLocation { get; set; }

    public virtual JOrder? CtOrder { get; set; }

    public virtual JProdunit? CtProdunit { get; set; }

    public virtual JContainer CtRootcontainer { get; set; } = null!;

    public virtual JStock? CtStock { get; set; }

    public virtual ICollection<JContainer> InverseCtRootcontainer { get; set; } = new List<JContainer>();

    public virtual ICollection<JContainerbufferentry> JContainerbufferentries { get; set; } = new List<JContainerbufferentry>();

    public virtual ICollection<JContainercontainer> JContainercontainers { get; set; } = new List<JContainercontainer>();

    public virtual ICollection<JContainerentry> JContainerentries { get; set; } = new List<JContainerentry>();

    public virtual ICollection<JContainerevent> JContainerevents { get; set; } = new List<JContainerevent>();

    public virtual ICollection<JContainerinfo> JContainerinfos { get; set; } = new List<JContainerinfo>();

    public virtual ICollection<JDeliverynotecontainer> JDeliverynotecontainers { get; set; } = new List<JDeliverynotecontainer>();

    public virtual ICollection<JLoaderevent> JLoaderevents { get; set; } = new List<JLoaderevent>();

    public virtual ICollection<JPackingmaterial> JPackingmaterials { get; set; } = new List<JPackingmaterial>();

    public virtual ICollection<JProdjob> JProdjobs { get; set; } = new List<JProdjob>();

    public virtual ICollection<JProdlotcontainer> JProdlotcontainers { get; set; } = new List<JProdlotcontainer>();

    public virtual ICollection<JProdstepstatus> JProdstepstatuses { get; set; } = new List<JProdstepstatus>();

    public virtual ICollection<JSkid> JSkids { get; set; } = new List<JSkid>();

    public virtual ICollection<JStockinvcresultitem> JStockinvcresultitems { get; set; } = new List<JStockinvcresultitem>();

    public virtual ICollection<JStockinvdiffitem> JStockinvdiffitemStidiNewcontainers { get; set; } = new List<JStockinvdiffitem>();

    public virtual ICollection<JStockinvdiffitem> JStockinvdiffitemStidiOldcontainers { get; set; } = new List<JStockinvdiffitem>();

    public virtual ICollection<JStockinvitem> JStockinvitems { get; set; } = new List<JStockinvitem>();

    public virtual ICollection<JStockinvstockloccnr> JStockinvstockloccnrStislcContainers { get; set; } = new List<JStockinvstockloccnr>();

    public virtual ICollection<JStockinvstockloccnr> JStockinvstockloccnrStislcSelectedcontainers { get; set; } = new List<JStockinvstockloccnr>();

    public virtual ICollection<JStockinvstockloccnr> JStockinvstockloccnrStislcUsedcontainers { get; set; } = new List<JStockinvstockloccnr>();

    public virtual ICollection<JStockloccontainer> JStockloccontainers { get; set; } = new List<JStockloccontainer>();

    public virtual ICollection<JSupplynotecontainer> JSupplynotecontainerSuncContainers { get; set; } = new List<JSupplynotecontainer>();

    public virtual ICollection<JSupplynotecontainer> JSupplynotecontainerSuncWhcontainers { get; set; } = new List<JSupplynotecontainer>();

    public virtual ICollection<JSupplynote> JSupplynotes { get; set; } = new List<JSupplynote>();

    public virtual ICollection<JTourcontainer> JTourcontainers { get; set; } = new List<JTourcontainer>();
}
