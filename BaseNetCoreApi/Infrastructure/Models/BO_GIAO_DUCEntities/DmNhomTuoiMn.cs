using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class DmNhomTuoiMn
{
    public string Ma { get; set; } = null!;

    public string? MaNhomTre { get; set; }

    public string? Ten { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public string MaSource { get; set; } = null!;
}
