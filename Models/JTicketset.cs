using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTicketset
{
    public decimal TicsId { get; set; }

    public decimal TicsCounterId { get; set; }

    public DateTime TicsTcreation { get; set; }

    public DateTime TicsTupdate { get; set; }

    public decimal? TicsDeletionid { get; set; }

    public DateTime? TicsTdeletion { get; set; }

    public string TicsKey { get; set; } = null!;

    public string TicsDescr { get; set; } = null!;

    public string TicsType { get; set; } = null!;

    public short TicsTanvalidityinsec { get; set; }

    public byte TicsTanlength { get; set; }

    public virtual ICollection<JStation> JStations { get; set; } = new List<JStation>();

    public virtual ICollection<JTicket> JTickets { get; set; } = new List<JTicket>();

    public virtual JCounter TicsCounter { get; set; } = null!;
}
