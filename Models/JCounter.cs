using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JCounter
{
    public decimal CnId { get; set; }

    public decimal CnCountersetId { get; set; }

    public DateTime CnTcreation { get; set; }

    public DateTime CnTupdate { get; set; }

    public string CnKey { get; set; } = null!;

    public string CnDescr { get; set; } = null!;

    public string? CnEncoding { get; set; }

    public string? CnFormat { get; set; }

    public int CnMinvalue { get; set; }

    public int CnMaxvalue { get; set; }

    public int CnIncrement { get; set; }

    public int CnSkipmodulo { get; set; }

    public int CnLastvalue { get; set; }

    public bool? CnCyclic { get; set; }

    public DateTime? CnLastvaluetime { get; set; }

    public bool? CnIsinitial { get; set; }

    public string CnAutoreset { get; set; } = null!;

    public bool? CnUsesequence { get; set; }

    public string? CnSequencename { get; set; }

    public decimal? CnLastsequenceno { get; set; }

    public virtual JCounterset CnCounterset { get; set; } = null!;

    public virtual ICollection<JAdviceset> JAdvicesets { get; set; } = new List<JAdviceset>();

    public virtual ICollection<JCompanycounter> JCompanycounters { get; set; } = new List<JCompanycounter>();

    public virtual ICollection<JContainerset> JContainersetCtsAltcounters { get; set; } = new List<JContainerset>();

    public virtual ICollection<JContainerset> JContainersetCtsCounters { get; set; } = new List<JContainerset>();

    public virtual ICollection<JContainerset> JContainersetCtsOthercounters { get; set; } = new List<JContainerset>();

    public virtual ICollection<JContract> JContractCEntrynocounters { get; set; } = new List<JContract>();

    public virtual ICollection<JContract> JContractCNotenocounters { get; set; } = new List<JContract>();

    public virtual ICollection<JContractcounter> JContractcounters { get; set; } = new List<JContractcounter>();

    public virtual ICollection<JPaintunit> JPaintunits { get; set; } = new List<JPaintunit>();

    public virtual ICollection<JPartset> JPartsets { get; set; } = new List<JPartset>();

    public virtual ICollection<JProdjobbuffer> JProdjobbuffers { get; set; } = new List<JProdjobbuffer>();

    public virtual ICollection<JProdjobset> JProdjobsets { get; set; } = new List<JProdjobset>();

    public virtual ICollection<JProdlotset> JProdlotsets { get; set; } = new List<JProdlotset>();

    public virtual ICollection<JProdnoteset> JProdnotesets { get; set; } = new List<JProdnoteset>();

    public virtual ICollection<JStocktagset> JStocktagsets { get; set; } = new List<JStocktagset>();

    public virtual ICollection<JTicketset> JTicketsets { get; set; } = new List<JTicketset>();

    public virtual ICollection<JTour> JTours { get; set; } = new List<JTour>();

    public virtual ICollection<JTourtemplate> JTourtemplateTteBorderocounters { get; set; } = new List<JTourtemplate>();

    public virtual ICollection<JTourtemplate> JTourtemplateTteShortnames { get; set; } = new List<JTourtemplate>();

    public virtual ICollection<JWorkflowjobset> JWorkflowjobsets { get; set; } = new List<JWorkflowjobset>();
}
