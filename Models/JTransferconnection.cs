using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JTransferconnection
{
    public decimal TcId { get; set; }

    public decimal TcCompanyId { get; set; }

    public decimal TcOthercompanyId { get; set; }

    public DateTime TcTcreation { get; set; }

    public DateTime TcTupdate { get; set; }

    public string TcKey { get; set; } = null!;

    public string TcDescr { get; set; } = null!;

    public string TcDirection { get; set; } = null!;

    public string TcProtocol { get; set; } = null!;

    public string? TcHandler { get; set; }

    public string TcDatatype { get; set; } = null!;

    public string? TcDatatypeadd { get; set; }

    public string TcTransport { get; set; } = null!;

    public int? TcLasttransmissionno { get; set; }

    public string TcTransmissionnotype { get; set; } = null!;

    public int? TcLastfileno { get; set; }

    public short TcMaxageindays { get; set; }

    public DateTime? TcLastevent { get; set; }

    public decimal? TcLasteventid { get; set; }

    public string TcPacketcoding { get; set; } = null!;

    public bool TcBlockinternal { get; set; }

    public bool TcBlockexternal { get; set; }

    public string TcNotificationtype { get; set; } = null!;

    public decimal? TcConfigdefId { get; set; }

    public string? TcInternalcharencoding { get; set; }

    public string? TcExternalcharencoding { get; set; }

    public virtual ICollection<JEdicfgitem> JEdicfgitems { get; set; } = new List<JEdicfgitem>();

    public virtual ICollection<JEdidef> JEdidefs { get; set; } = new List<JEdidef>();

    public virtual ICollection<JTransferconnclassm> JTransferconnclassms { get; set; } = new List<JTransferconnclassm>();

    public virtual ICollection<JTransfercontrol> JTransfercontrols { get; set; } = new List<JTransfercontrol>();

    public virtual ICollection<JTransfercpacketdone> JTransfercpacketdones { get; set; } = new List<JTransfercpacketdone>();

    public virtual ICollection<JTransfercpacket> JTransfercpackets { get; set; } = new List<JTransfercpacket>();

    public virtual ICollection<JTransferpacketdone> JTransferpacketdones { get; set; } = new List<JTransferpacketdone>();

    public virtual ICollection<JTransferpacket> JTransferpackets { get; set; } = new List<JTransferpacket>();

    public virtual ICollection<JTransferspacket> JTransferspackets { get; set; } = new List<JTransferspacket>();

    public virtual JCompany TcCompany { get; set; } = null!;

    public virtual JConfigdef? TcConfigdef { get; set; }

    public virtual JCompany TcOthercompany { get; set; } = null!;
}
