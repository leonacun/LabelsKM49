using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JSystem
{
    public decimal SysId { get; set; }

    public DateTime SysTcreation { get; set; }

    public DateTime SysTupdate { get; set; }

    public decimal SysUpdateversionno { get; set; }

    public string SysName { get; set; } = null!;

    public string SysSite { get; set; } = null!;

    public string SysCopyright { get; set; } = null!;

    public byte SysMajorschemaversion { get; set; }

    public byte SysMinorschemaversion { get; set; }

    public string SysMode { get; set; } = null!;
}
