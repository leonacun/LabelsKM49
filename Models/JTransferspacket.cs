using Labels_KM49.Models.ViewModels;
using System;
using System.Collections.Generic;
using static Labels_KM49.Controllers.JTransferspacketsController;

namespace Labels_KM49.Models;

public partial class JTransferspacket
{
    public decimal TspId { get; set; }

    public decimal TspConnectionId { get; set; }

    public DateTime TspTcreation { get; set; }

    public DateTime? TspTimetransferred { get; set; }

    public string? TspExternalname { get; set; }

    public string? TspQualifier1 { get; set; }

    public string? TspQualifier2 { get; set; }

    public string TspStatus { get; set; } = null!;

    public string TspPrevstatus { get; set; } = null!;

    public string TspData { get; set; } = null!;

    public string? TspTransferrefno { get; set; }

    public virtual ICollection<JTransferspacketmessage> JTransferspacketmessages { get; set; } = new List<JTransferspacketmessage>();

    public virtual ICollection<JTransferspacketref> JTransferspacketrefs { get; set; } = new List<JTransferspacketref>();

    public virtual JTransferconnection TspConnection { get; set; } = null!;

    // Extencion de nueva lista de objetos

    public List<PilotoViewModel>? ListaPilotos { get; set; }

}
