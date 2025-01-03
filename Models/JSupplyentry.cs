using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSupplyentry
{
    public decimal SueId { get; set; }

    public decimal SueSupplyId { get; set; }

    public decimal SueContractId { get; set; }

    public decimal? SueConfirmedbyuserId { get; set; }

    public DateTime SueTcreation { get; set; }

    public string SueNo { get; set; } = null!;

    public DateTime? SueClosedtimestamp { get; set; }

    public bool SueConfirmed { get; set; }

    public string SueCreatorkind { get; set; } = null!;

    public DateTime? SueTimeverified { get; set; }

    public decimal? SueConfirmedbyprodunitId { get; set; }

    public DateTime SueTupdate { get; set; }

    public virtual ICollection<JSupplynote> JSupplynotes { get; set; } = new List<JSupplynote>();

    public virtual JProdunit? SueConfirmedbyprodunit { get; set; }

    public virtual JUser? SueConfirmedbyuser { get; set; }

    public virtual JContract SueContract { get; set; } = null!;

    public virtual JSupply SueSupply { get; set; } = null!;
}
