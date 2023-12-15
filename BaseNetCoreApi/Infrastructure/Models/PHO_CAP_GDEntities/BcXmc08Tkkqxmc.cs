using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcXmc08Tkkqxmc
{
    public long Id { get; set; }

    public string MaNamHoc { get; set; } = null!;

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public string? IdToThon { get; set; }

    public string Ma { get; set; } = null!;

    public decimal? T1525 { get; set; }

    public decimal? T1535 { get; set; }

    public decimal? T1560 { get; set; }
}
