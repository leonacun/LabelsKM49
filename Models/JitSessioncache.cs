using System;
using System.Collections.Generic;

namespace Labels_KM49.Models;

public partial class JitSessioncache
{
    public decimal? Sid { get; set; }

    public decimal? Serial { get; set; }

    public string? Process { get; set; }

    public string? Machine { get; set; }

    public string? Program { get; set; }

    public decimal? RowWaitObj { get; set; }

    public decimal? RowWaitFile { get; set; }

    public decimal? RowWaitBlock { get; set; }

    public decimal? RowWaitRow { get; set; }
}
